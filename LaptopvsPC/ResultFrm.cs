using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LaptopvsPC
{
    public partial class ResultFrm : Form
    {
        private int rdBttnState { get; set; }

        Results results;
        DataTable dt = new DataTable();
        string filePath = @"..\..\RawData\Adatok.txt";

        public ResultFrm(int rdBttn, Results results)
        {
            InitializeComponent();
            rdBttnState = rdBttn;
            this.results = results;
        }

        private void ResultFrm_Load(object sender, EventArgs e)
        {
            inicializeDataTable();
            dataProcessing();
            fillRchTxtBx();
            chrt.Series["PC"].Points.AddXY("", results.getPCPercentage());
            chrt.Series["Laptop"].Points.AddXY("", results.getLaptopPercentage());
        }

        private void inicializeDataTable()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Processzor");
            dt.Columns.Add("Memória");
            dt.Columns.Add("Videókártya");
            dt.Columns.Add("Kivitel");
        }

        private void dataProcessing()
        {
            string text;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    text = sr.ReadToEnd();
                    string[] lines = text.Split(new char[] { '*' });
                    for (int i = 0; i < lines.Length; ++i)
                    {
                        string[] splices = lines[i].Split(new char[] { ',' });
                        string[] row = new string[splices.Length];
                        for (int x = 0; x < splices.Length; ++x)
                        {
                            row[x] = splices[x].Trim();
                        }

                        dt.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void fillRchTxtBx()
        {
            rchTxtBxResult.AppendText($"PC pontok: {results.PointsOfPC}\n");
            rchTxtBxResult.AppendText($"Laptop pontok: {results.PointsOfLaptop}\n\n");
            for (int i = 1; i < dt.Columns.Count; ++i)
            {
                rchTxtBxResult.SelectionFont = new Font(rchTxtBxResult.Font, FontStyle.Bold);
                rchTxtBxResult.AppendText(dt.Columns[i].ColumnName.ToString() + ": \n");
                rchTxtBxResult.SelectionFont = new Font(rchTxtBxResult.Font, FontStyle.Regular);
                rchTxtBxResult.AppendText(dt.Rows[rdBttnState][i].ToString() + "\n\n");                
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File | *.txt";
            dialog.FileName = "results.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(dialog.OpenFile()))
                    {
                        streamWriter.WriteLine(rchTxtBxResult.Text);
                        streamWriter.Dispose();
                        streamWriter.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bttnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
