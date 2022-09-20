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

    public partial class MainFrm : Form
    {
        DataTable dt = new DataTable();
        public string taroltAdat { get; set; }

        public MainFrm()
        {
            InitializeComponent();
            comboBox1.Items.Add(0);
            dt.Columns.Add("Típus");
            dt.Columns.Add("Leírás");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //filePath = ofd.FileName;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    //comboBox1.Items.Add(streamReader.ReadToEnd());
                    //string mostaniSor = (streamReader.ReadLine());
                    taroltAdat = streamReader.ReadToEnd();
                    //comboBox1.Items.Add(taroltAdat);

                }
            }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //filePath = ofd.FileName;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    //label10.Text = streamReader.ReadToEnd();
                    taroltAdat = streamReader.ReadToEnd();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = taroltAdat;
        }
    }
}
