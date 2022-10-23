using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopvsPC
{
    public partial class ResultFrm : Form
    {
        public int rdBttnState { get; set; }

        static DataTable dt = new DataTable();
        static string filePath = @"..\..\RawData\Adatok.txt";

        public ResultFrm(int rdBttn)
        {
            InitializeComponent();
            this.rdBttnState = rdBttn;

        }

        private void ResultFrm_Load(object sender, EventArgs e)
        {

            inicializeDataTable();
            dataProcessing();
            fillRchTxtBx();
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
        private void fillRchTxtBx()
        {
            for (int i = 1; i < dt.Columns.Count; ++i)
            {
                rchTxtBxResult.SelectionFont = new Font(rchTxtBxResult.Font, FontStyle.Bold);
                rchTxtBxResult.AppendText(dt.Columns[i].ColumnName.ToString() + ": \n");
                rchTxtBxResult.SelectionFont = new Font(rchTxtBxResult.Font, FontStyle.Regular);
                rchTxtBxResult.AppendText(dt.Rows[rdBttnState][i].ToString() + "\n\n");                
            }
        }
    }
}
