using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;




namespace LaptopvsPC
{

    public partial class MainFrm : Form
    {
        DataTable dt = new DataTable();
        string filePath = @"..\..\RawData\Adatok.txt";
        int? rdBttn = null;

        public enum Rating
        {
            Egyátalán_nem_fontos,
            Nem_fontos,
            Közepesen_fontos,
            Eléggé_fontos,
            Nagyon_fontos
        }

        public MainFrm()
        {
            InitializeComponent();
        }


        private void MainFrm_Load(object sender, EventArgs e)
        {
            inicializeDataTable();
            //dtGrdVw.DataSource = dt;
            dataProcessing();
            //dtGrdVw.Columns[0].Visible = false;
            //dtGrdVw.Visible = false;
            inicializeComboBoxes();
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label10.Font = new Font(label10.Font, FontStyle.Bold);
        }

        private void inicializeComboBoxes()
        {
            string[] enumElements = Enum.GetNames(typeof(Rating));
            foreach (ComboBox cb in groupBox1.Controls.OfType<ComboBox>())
            {
                //cb.DataSource = Enum.GetNames(typeof(Rating));
                foreach (var item in enumElements)
                {
                    cb.Items.Add(item.Replace("_", " "));
                }
                cb.SelectedIndex = -1;
            }

        }

        private void inicializeDataTable()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Processzor");
            dt.Columns.Add("Memória");
            dt.Columns.Add("Videókártya");
            dt.Columns.Add("Kivitel");
            dt.Columns.Add("Javaslatok");
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

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //dtGrdVw.AutoResizeColumns();
        }

        private void bttnFinish_Click(object sender, EventArgs e)
        {

            var buttons = this.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            if (buttons != null)
            {
                switch (buttons.Name)
                {
                    case "rdBttn1":
                        rdBttn = 0;
                        break;
                    case "rdBttn2":
                        rdBttn = 1;
                        break;
                    case "rdBttn3":
                        rdBttn = 4;
                        break;
                    case "rdBttn4":
                        rdBttn = 3;
                        break;
                    case "rdBttn5":
                        rdBttn = 2;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Kérlek válassz ki egy radiobutton-t, ne legyél buta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            if (rdBttn != null)
            {
                //(dtGrdVw.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID = '{0}'", rdBttn);
                //dtGrdVw.Visible = true;
                //dtGrdVw.AutoResizeColumns();
            }
            
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            //dtGrdVw.Visible=false;
            //rdBttn = null;
            var buttons = this.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            if (buttons != null)
            {
                buttons.Checked = false;

            }
            else
            {
                MessageBox.Show("Válassz ki valamit, mielőtt reset-elnél, ember...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbBx4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
