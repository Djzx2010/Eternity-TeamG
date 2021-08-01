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
        public decimal column { get; set; }
        public OpenForm()
        {
            InitializeComponent();
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


            if(ofd.ShowDialog() == DialogResult.OK)
            {
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

            //File path should be in C:/something/filename.csv
            //will verify format with the following regex
            Regex rx = new Regex(@"[a-zA-Z]:[\\\/](?:[a-zA-Z0-9]+[\\\/])*([a-zA-Z0-9]+.csv)",
            RegexOptions.Compiled);
            MatchCollection matches = rx.Matches(fileLocation);
            bool invalidIndex = false;
            if (matches.Count > 0)
            {
                try
                {
                    var file = new StreamReader(fileLocation);
                    String line = file.ReadLine();
                    String[] tokens = line.Split(',');
                    if (column >= tokens.Length)
                    {
                        invalidIndex = true;
                        throw new Exception();
                    }
                    file.Close();

                    //If no exceptions are thrown the file and column are valid
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception exception)
                {
                    if (!invalidIndex)
                    {
                        MessageBox.Show("Error, invalid file, enter a valid file.");
                        textBox1.BackColor = Color.Red;
                    }
                    else
                        MessageBox.Show("Invalid index, enter an index of a valid column within the .csv file.");
                }
            }
            else
            {
                MessageBox.Show("Error, invalid file path, enter a valid file path.");
                textBox1.BackColor = Color.Red;
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
