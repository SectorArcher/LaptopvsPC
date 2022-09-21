using System;
using System.Data;
using System.IO;
using System.Windows.Forms;




namespace LaptopvsPC
{

    public partial class MainFrm : Form
    {
        DataTable dt = new DataTable();
        string filePath = @"..\..\RawData\Adatok.txt";

        public MainFrm()
        {
            InitializeComponent();           
        }


        private void MainFrm_Load(object sender, EventArgs e)
        {
            inicializeDataTable();
            dtGrdVw.DataSource = dt;
            dataProcessing();
        }
     
        private void inicializeDataTable()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Processzor");
            dt.Columns.Add("Memória");
            dt.Columns.Add("Videókártya");
            dt.Columns.Add("Kivitel");
            dt.Columns.Add("Javaslatok");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = dt.Columns[0];
            dt.PrimaryKey = keys;
        }

        private void dataProcessing()
        {
            string text;
            using (StreamReader sr = new StreamReader(filePath))
            {
                text = sr.ReadToEnd();
            }
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
            dtGrdVw.AutoResizeColumns();
        }

        private void bttnFinish_Click(object sender, EventArgs e)
        {

            

        }
    }
}
