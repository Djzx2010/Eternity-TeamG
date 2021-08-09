using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Text.RegularExpressions;
using System.IO;

namespace CalculatorGUI
{
    public partial class OpenForm : Form
    {
        public String fileLocation { get; set; }
        private String invalidFilePath = "Enter a valid file path";
        private String invalidFileType = "Enter a valid .csv file";
        public decimal column { get; set; }
        public OpenForm()
        {
            InitializeComponent();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".csv",
            };


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = Color.White;
                textBox1.Text = ofd.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            column = numericUpDown1.Value;
            fileLocation = textBox1.Text;
            bool fileExists = true;
            try
            {
                String extension = Path.GetExtension(fileLocation);
                if (File.Exists(fileLocation) && !extension.Equals(".csv"))
                {
                    MessageBox.Show("Invalid file type, the file you are trying to open is not a valid .csv file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.BackColor = Color.Red;
                    label2.Text = invalidFileType;
                    label2.Show();
                    fileExists = false;
                    throw new Exception();
                }
                //Try to open the file, if the file doesn't exist notify the user
                else if (!File.Exists(fileLocation))
                {
                    MessageBox.Show("Invalid file, the file you are attempting to open does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.BackColor = Color.White;
                    label2.Text = invalidFilePath;
                    label2.Show();
                    fileExists = false;
                }

                //an exception is thown if the file doesnt exist.
                var file = new StreamReader(fileLocation);
                String line = file.ReadLine();
                String[] tokens = line.Split(',');
                //if the file exists but the column is invalid, then throw and exception
                if (column >= tokens.Length)
                    throw new Exception();
                file.Close();

                //If no exceptions are thrown the file and column are valid
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                if (fileExists)
                {
                    MessageBox.Show("Invalid index, enter an index of a valid column within the .csv file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.BackColor = Color.White;
                    label2.Hide();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
