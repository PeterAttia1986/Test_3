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

namespace Test_3
{
    public partial class Form1 : Form
    {
        public string myFile;

        private void Form1_Load(object sender, EventArgs e)
        {
            Car_radioButton.Checked = true;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Make_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model_comboBox.Items.Clear();

            if (Make_comboBox.SelectedItem.ToString().ToUpper() == "Honda")
            {
                Model_comboBox.Items.Add("Civic");
                Model_comboBox.Items.Add("HRV");
                Model_comboBox.Items.Add("CRV");
                Year_comboBox.Items.Add("2017");
                Year_comboBox.Items.Add("2018");
                Year_comboBox.Items.Add("2019");
            }

            if (Make_comboBox.SelectedItem.ToString().ToUpper() == "Toyota")
            {
                Model_comboBox.Items.Add("Corolla");
                Model_comboBox.Items.Add("Camry");
                Model_comboBox.Items.Add("yaris");
                Year_comboBox.Items.Add("2017");
                Year_comboBox.Items.Add("2018");
                Year_comboBox.Items.Add("2019");
            }
            if (Make_comboBox.SelectedItem.ToString().ToUpper() == "Lamborghini")
            {

                Model_comboBox.Items.Add("350 GT");
                Model_comboBox.Items.Add("Islero GT");
                Model_comboBox.Items.Add("Jarama");
                Year_comboBox.Items.Add("2017");
                Year_comboBox.Items.Add("2018");
                Year_comboBox.Items.Add("2019");
            }
        }



        private void Car_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Car_radioButton.Checked == true)
            {
                Owner_Registration_groupBox.Enabled = false;
                Car_Registration_groupBox.Enabled = true;
            }
        }

        private void Owner_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Owner_radioButton.Checked == true)
            {
                Owner_Registration_groupBox.Enabled = true;
                Car_Registration_groupBox.Enabled = false;
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Make_comboBox.Text = String.Empty;
            Model_comboBox.Text = String.Empty;
            Year_comboBox.Text = String.Empty;
            First_Name_comboBox.Text = String.Empty;
            Last_Name_comboBox.Text = String.Empty;
            Telephone_comboBox.Text = String.Empty;
        }



        private void writeToFile(String output)
        {
            using (StreamWriter sw = new StreamWriter("Registration.txt", true))
            {
                sw.WriteLine(output);
            }

        }

        private void Save_button_Click(object sender, EventArgs e)
        {


            try { 
            /*
            if (Car_Registration_groupBox.Enabled = true)
            {
                if (Make_comboBox.Text.Trim().Equals("") || Model_comboBox.Text.Trim().Equals("") || Year_comboBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill out all the fields in Car Registration", "Required", MessageBoxButtons.OK);
                }
            } else if (Owner_Registration_groupBox.Enabled = true) {
                if (First_Name_comboBox.Text.Trim().Equals("") || Last_Name_comboBox.Text.Trim().Equals("") || Telephone_comboBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill out all the fields in Owner", "Required", MessageBoxButtons.OK);
                    
                }
            }else */
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.OverwritePrompt = false;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        myFile = saveFileDialog.FileName;
                        MessageBox.Show(myFile);
                    }
                }
                FileStream fileStream = new FileStream(myFile, FileMode.Append, FileAccess.Write);

                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine($"{Make_comboBox.Text},{Model_comboBox.Text},{Year_comboBox.Text},{First_Name_comboBox.Text},{Last_Name_comboBox.Text},{Telephone_comboBox.Text}");
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }
  
    }
}
