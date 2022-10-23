using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;




namespace LaptopvsPC
{
    public enum Rating
    {
        Egyátalán_nem_fontos,
        Nem_fontos,
        Közepesen_fontos,
        Eléggé_fontos,
        Nagyon_fontos
    }

    public partial class MainFrm : Form
    {
        int rdBttn = -1;
        int pointsOfPC = 0;
        int pointsOfLaptop = 0;

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

            inicializeComboBoxes();
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label10.Font = new Font(label10.Font, FontStyle.Bold);
        }

        private void inicializeComboBoxes()
        {
            string[] enumElements = Enum.GetNames(typeof(Rating));
            foreach (ComboBox cb in grpBx.Controls.OfType<ComboBox>())
            {
                foreach (var item in enumElements)
                {
                    cb.Items.Add(item.Replace("_", " "));
                }
                cb.SelectedIndex = -1;
            }

        }
        private void bttnResults_Click(object sender, EventArgs e)
        {
            var buttons = grpBx2.Controls.OfType<RadioButton>()
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

            if (prgrssBr.Value == 100)
            {
                settingPoints();
                ResultFrm resultFrm = new ResultFrm(rdBttn, new Results(pointsOfPC, pointsOfLaptop));
                resultFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kérlek minden szükséges adatot adj meg!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingPoints()
        {
            pointsFavL(cmbBx1 as ComboBox);
            pointsFavL(cmbBx4 as ComboBox);
            pointsFavL(cmbBx6 as ComboBox);
            pointsFavPC(cmbBx2 as ComboBox);
            pointsFavPC(cmbBx3 as ComboBox);
            pointsFavPC(cmbBx5 as ComboBox);

        }

        private void pointsFavPC(ComboBox comboBox)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    pointsOfLaptop = pointsOfLaptop + 5;
                    break;
                case 1:
                    pointsOfPC = pointsOfPC + 2;
                    pointsOfLaptop = pointsOfLaptop + 4;
                    break;
                case 2:
                    pointsOfPC = pointsOfPC + 3;
                    pointsOfLaptop = pointsOfLaptop + 3;
                    break;
                case 3:
                    pointsOfPC = pointsOfPC + 4;
                    pointsOfLaptop = pointsOfLaptop + 2;
                    break;
                case 4:
                    pointsOfPC = pointsOfPC + 5;

                    break;
            }
        }
        private void pointsFavL(ComboBox comboBox)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    pointsOfPC = pointsOfPC + 5;
                    break;
                case 1:
                    pointsOfPC = pointsOfPC + 4;
                    pointsOfLaptop = pointsOfLaptop + 2;
                    break;
                case 2:
                    pointsOfPC = pointsOfPC + 3;
                    pointsOfLaptop = pointsOfLaptop + 3;
                    break;
                case 3:
                    pointsOfPC = pointsOfPC + 2;
                    pointsOfLaptop = pointsOfLaptop + 4;
                    break;
                case 4:
                    pointsOfLaptop = pointsOfLaptop + 5;
                    break;
            }
        }

        private void prgrssBrInitialization()
        {
            int numberOfCheckedComponents = 0;

            var buttons = grpBx2.Controls.OfType<RadioButton>()
                          .FirstOrDefault(n => n.Checked);
            if (buttons != null)
            {
                numberOfCheckedComponents = numberOfCheckedComponents + 1;
            }


            foreach (Control cmbBx in grpBx.Controls)
            {
                if (cmbBx.Text != "")                
                {
                    ++numberOfCheckedComponents;
                }
            }

            prgrssBr.Value = (int)Math.Round((double)(numberOfCheckedComponents -7)/ 7 * 100, 0);


        }

        private void cmbBx4_SelectedIndexChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void cmbBx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void cmbBx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void cmbBx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void cmbBx5_SelectedIndexChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void cmbBx6_SelectedIndexChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        } 

        private void rdBttn1_CheckedChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void rdBttn2_CheckedChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void rdBttn3_CheckedChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void rdBttn4_CheckedChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

        private void rdBttn5_CheckedChanged(object sender, EventArgs e)
        {
            prgrssBrInitialization();
        }

    }
}
