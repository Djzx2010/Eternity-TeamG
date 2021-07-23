using DynamicExpresso;
using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        private ScientificCalculator.Interpreter interpreter;
        bool shiftHeld = false;
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.displayField.ForeColor = Color.Red;
            interpreter = new ScientificCalculator.Interpreter();
            
        }


        private void displayField_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            displayField.AppendText("(");
        }

        private void buttonClosedBracket_Click(object sender, EventArgs e)
        {
            displayField.AppendText(")");
        }

        private void buttonModulus_Click(object sender, EventArgs e)
        {
            displayField.AppendText("%");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            displayField.AppendText("x");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayField.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayField.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayField.AppendText("3");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            displayField.AppendText("÷");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayField.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayField.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayField.AppendText("6");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            displayField.AppendText("-");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayField.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayField.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayField.AppendText("9");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            displayField.AppendText("+");
        }

        private void buttonPlusMinusAlt_Click(object sender, EventArgs e)
        {
            //if(displayField.Text[0]!='-')
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            displayField.AppendText( "0");
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            displayField.AppendText(".");
        }



        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(displayField.Text);
            Double res = interpreter.EvaluateString(displayField.Text);
            displayField.Text = res.ToString();
            listBox1.Items.Add(res.ToString());
        }

        private KeysConverter keyConverter = new KeysConverter();
        private void form_KeyDown(object sender, KeyEventArgs e)
        {

            //if(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            if(e.KeyCode == Keys.Shift)
            {
                shiftHeld = true;
            }
           else if (e.KeyCode == Keys.Back)
            {
                if(displayField.Text.Length>0)
                    displayField.Text = displayField.Text.Substring(0, displayField.Text.Length - 1);

            }
            else
            {
                String prevKey = "";
                char c = Convert.ToChar(e.KeyCode);
                prevKey += c;
                prevKey = prevKey.ToLower();
                displayField.AppendText(prevKey);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            displayField.AppendText("σ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            displayField.AppendText(",");
        }
    }
}
