using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class SettingsForm : Form
    {

        public bool darkModeEnabled { get; set; }
        public bool audioEnabled { get; set; }
        public SettingsForm(bool darkModeEnabled, bool audioEnabled)
        {
            InitializeComponent();
            checkBox1.Checked = darkModeEnabled;
            this.darkModeEnabled = darkModeEnabled;
            checkBox2.Checked = audioEnabled;
            this.audioEnabled = audioEnabled;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.darkModeEnabled = !this.darkModeEnabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.audioEnabled = !this.audioEnabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
