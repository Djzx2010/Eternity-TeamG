using DynamicExpresso;
using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class CalculatorForm : Form
    {
        private ScientificCalculator.Interpreter interpreter;
        private ColorScheme lightColorScheme;
        private ColorScheme darkColorScheme;
        private bool darkModeEnabled;
        private bool audioEnabled;
        private int taskCount;
        private Mutex writeOutMutex;
        String toStrip;
        

        public CalculatorForm()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            interpreter = new ScientificCalculator.Interpreter();

            //Add an audio event to all the buttons
            foreach (var button in tableLayoutPanel2.Controls.OfType<Button>())
            {
                button.Click += new System.EventHandler(this.clearTextAfterEvaluate);
                button.Click += new System.EventHandler(this.audioEvent_Click);
            }
            foreach (var button in tableLayoutPanel1.Controls.OfType<Button>())
            {
                button.Click += new System.EventHandler(this.clearTextAfterEvaluate);
                button.Click += new System.EventHandler(this.audioEvent_Click);
            }

            //Set the light color scheme based on the colors used in the current form
            lightColorScheme.baseColors.background = this.BackColor;
            lightColorScheme.baseColors.foreground = this.ForeColor;
            lightColorScheme.menuPanelColors.background = menuStrip1.BackColor;
            lightColorScheme.menuPanelColors.foreground = menuStrip1.ForeColor;
            lightColorScheme.buttonsColors.background = Color.White;
            lightColorScheme.buttonsColors.foreground = Color.Black;
            lightColorScheme.historyColors.background = listBoxHistory.BackColor;
            lightColorScheme.historyColors.foreground = listBoxHistory.ForeColor;
            lightColorScheme.displayFeildColors.background = displayField.BackColor;
            lightColorScheme.displayFeildColors.foreground = displayField.ForeColor;

            //Set the dark color scheme
            darkColorScheme.baseColors.background = Color.Black;
            darkColorScheme.baseColors.foreground = Color.White;
            darkColorScheme.menuPanelColors.background = Color.Black;
            darkColorScheme.menuPanelColors.foreground = Color.White;
            darkColorScheme.buttonsColors.background = Color.FromArgb(200, 30, 30, 30);
            darkColorScheme.buttonsColors.foreground = Color.WhiteSmoke;
            darkColorScheme.historyColors.background = Color.FromArgb(30, 30, 30);
            darkColorScheme.historyColors.foreground = Color.WhiteSmoke;
            darkColorScheme.displayFeildColors.background = Color.FromArgb(30, 30, 30);
            darkColorScheme.displayFeildColors.foreground = Color.WhiteSmoke;

            darkModeEnabled = true;
            this.darkModeToolStripMenuItem.Checked = darkModeEnabled;
            SetColorScheme(darkColorScheme);

            audioEnabled = false;

            timer1.Enabled = true;
            timer1.Tick += new EventHandler(TickEvent);
            taskCount = 0;
            writeOutMutex = new Mutex();

            clearAfterEvaluate = false;
        }

        private void SetColorScheme(ColorScheme scheme)
        {
            this.BackColor = scheme.baseColors.background;
            menuStrip1.BackColor = scheme.menuPanelColors.background;
            menuStrip1.ForeColor = scheme.menuPanelColors.foreground;
            foreach (var button in tableLayoutPanel2.Controls.OfType<Button>())
            {
                button.BackColor = scheme.buttonsColors.background;
                button.ForeColor = scheme.buttonsColors.foreground;
            }

            foreach (var button in tableLayoutPanel1.Controls.OfType<Button>())
            {
                button.BackColor = scheme.buttonsColors.background;
                button.ForeColor = scheme.buttonsColors.foreground;
            }
            listBoxHistory.BackColor = scheme.historyColors.background;
            listBoxHistory.ForeColor = scheme.historyColors.foreground;
            displayField.BackColor = scheme.displayFeildColors.background;
            displayField.ForeColor = scheme.displayFeildColors.foreground;

        }

        /*
          _   _ _   _ __  __ ____  _____ ____  ____  
         | \ | | | | |  \/  | __ )| ____|  _ \/ ___| 
         |  \| | | | | |\/| |  _ \|  _| | |_) \___ \ 
         | |\  | |_| | |  | | |_) | |___|  _ < ___) |
         |_| \_|\___/|_|  |_|____/|_____|_| \_\____/ 
                                             
         */
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

        private void button0_Click(object sender, EventArgs e)
        {
            displayField.AppendText("0");
        }

        /*
          ______   ____  __ ____   ___  _     ____  
         / ___\ \ / /  \/  | __ ) / _ \| |   / ___| 
         \___ \\ V /| |\/| |  _ \| | | | |   \___ \ 
          ___) || | | |  | | |_) | |_| | |___ ___) |
         |____/ |_| |_|  |_|____/ \___/|_____|____/ 

         */

        // Open Bracket - (
        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            displayField.AppendText("(");
        }

        // Closed Bracket - )
        private void buttonClosedBracket_Click(object sender, EventArgs e)
        {
            displayField.AppendText(")");
        }

        // Modulus - %
        private void buttonModulus_Click(object sender, EventArgs e)
        {
            displayField.AppendText("%");
        }

        // Multiplication - x
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            displayField.AppendText("x");
        }

        // Addition - +
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            displayField.AppendText("+");
        }

        // Subtraction - -
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            displayField.AppendText("-");
        }

        // Division - ÷
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            displayField.AppendText("÷");
        }

        // Decimal - .
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            displayField.AppendText(".");
        }

        // Comma - ,
        private void buttonComma_Click(object sender, EventArgs e)
        {
            displayField.AppendText(",");
        }

        // Evaluate - =
        private async void buttonEvaluate_Click(object sender, EventArgs e)
        {
            String expression = displayField.Text;
            int numMissingCloseParenthesis = expression.Count(x => x == '(') - expression.Count(x => x == ')');
            if (numMissingCloseParenthesis > 0)
                expression += new String(')', numMissingCloseParenthesis);
            taskCount++;
            Double res = await Task.Run(() => interpreter.EvaluateString(expression));
            taskCount--;
            displayField.Text = res.ToString();
            writeOutMutex.WaitOne();
            listBoxHistory.Items.Insert(0, "= " + res.ToString());
            listBoxHistory.Items.Insert(0, expression);
            writeOutMutex.ReleaseMutex();
            clearAfterEvaluate = true;
            toStrip = displayField.Text;
        }

        // CLEAR
        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayField.Text = "";
        }

        /*
          _____ _   _ _   _  ____ _____ ___ ___  _   _ ____  
         |  ___| | | | \ | |/ ___|_   _|_ _/ _ \| \ | / ___| 
         | |_  | | | |  \| | |     | |  | | | | |  \| \___ \ 
         |  _| | |_| | |\  | |___  | |  | | |_| | |\  |___) |
         |_|    \___/|_| \_|\____| |_| |___\___/|_| \_|____/                                        
         */

        // ARCCOS
        private void buttonArccos_Click(object sender, EventArgs e)
        {
            displayField.AppendText("Arccos(");
        }

        // EXPONENT
        private void buttonExponent_Click(object sender, EventArgs e)
        {
            displayField.AppendText("Pow(");
        }

        // STANDARD DEVIATION
        private void buttonSTD_Click(object sender, EventArgs e)
        {
            displayField.AppendText("σ(");
        }

        // LOG
        private void buttonLog_Click(object sender, EventArgs e)
        {
            displayField.AppendText("Log(");
        }

        // GAMMA
        private void buttonGamma_Click(object sender, EventArgs e)
        {
            displayField.AppendText("Γ(");
        }

        // SINH
        private void buttonSinh_Click(object sender, EventArgs e)
        {
            displayField.AppendText("Sinh(");
        }

        // MAD
        private void buttonMAD_Click(object sender, EventArgs e)
        {
            displayField.AppendText("MAD(");
        }

        /*
          _____ ___  ____  __  __    ____ ___  _   _ _____ ____   ___  _     ____  
         |  ___/ _ \|  _ \|  \/  |  / ___/ _ \| \ | |_   _|  _ \ / _ \| |   / ___| 
         | |_ | | | | |_) | |\/| | | |  | | | |  \| | | | | |_) | | | | |   \___ \ 
         |  _|| |_| |  _ <| |  | | | |__| |_| | |\  | | | |  _ <| |_| | |___ ___) |
         |_|   \___/|_| \_\_|  |_|  \____\___/|_| \_| |_| |_| \_\\___/|_____|____/ 
        */

        private KeysConverter keyConverter = new KeysConverter();
        private bool clearAfterEvaluate;

        private void audioEvent_Click(object sender, EventArgs e)
        {
            if (audioEnabled)
                System.Media.SystemSounds.Beep.Play();
        }

        private async void form_KeyDown(object sender, KeyEventArgs e)
        {
            if(!displayField.Focused)
                displayField.Focus();
            clearTextAfterEvaluate(sender, e);
            if (e.KeyCode == Keys.Enter)
            {
                buttonEvaluate_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Back)
            {
                if(displayField.Text.Length>0)
                    displayField.Text = displayField.Text.Substring(0, displayField.Text.Length);
                displayField.SelectionStart = displayField.Text.Length;
            }
        }

        // HISTORY / MEMORY LISTBOX
        private void listBoxHistory_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxHistory.SelectedItem != null)
            {
                displayField.Text = listBoxHistory.SelectedItem.ToString().TrimStart('=');
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            displayField.AppendText("arr");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            displayField.AppendText("π");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            displayField.AppendText("e");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            displayField.AppendText("ans");
        }

        // Toggle the results of Trig functions between radians and degrees
        private void buttonTrigUnits_Click(object sender, EventArgs e)
        {
            ScientificCalculator.Math.toggleTrigUnits();
            ScientificCalculator.TrigUnits unitType = ScientificCalculator.Math.GetUnitType();

            if (unitType == ScientificCalculator.TrigUnits.RAD)
            {
                buttonTrigUnits.Text = "RAD";
            }
            else
            {
                buttonTrigUnits.Text = "DEG";
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            interpreter.MemoryClear();
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            Double memory = interpreter.MemoryRecall();
            if (!Double.IsNaN(memory))
                displayField.AppendText(memory.ToString());
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(displayField.Text))
                {
                    Double tryParse = Double.Parse(displayField.Text);
                    interpreter.MemorySave(tryParse);
                }
            }
            catch (Exception exc)
            {
                displayField.Text = "Invalid Number";
            }

        }

        // DRAW EVENTS/FUNCTIONS

        // Every tick
        private void TickEvent(object o, EventArgs e)
        {
            if (taskCount > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
        }

        // MENU STRIP CLICK HANDLERS

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm openForm = new OpenForm();
            openForm.Text = "Load From CSV File";
            DialogResult res = openForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                interpreter.LoadArrayFromCSV(openForm.fileLocation, (uint)openForm.column);
            }
            openForm.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handle dark mode toggling on menu item click
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkModeEnabled)
            {
                darkModeEnabled = false;
                SetColorScheme(lightColorScheme);
                this.darkModeToolStripMenuItem.Checked = darkModeEnabled;
            }
            else
            {
                darkModeEnabled = true;
                SetColorScheme(darkColorScheme);
                this.darkModeToolStripMenuItem.Checked = darkModeEnabled;
            }
        }

        // Handle audio feedback toggling on menu item click
        private void audioFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (audioEnabled)
            {
                audioEnabled = false;
                this.audioFeedbackToolStripMenuItem.Checked = audioEnabled;
            }
            else
            {
                audioEnabled = true;
                this.audioFeedbackToolStripMenuItem.Checked = audioEnabled;
            }
        }

        private void clearHistoryMenuItem_Click(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();
        }

        private void clearTextAfterEvaluate(object sender, EventArgs e)
        {
            if (clearAfterEvaluate)
            {
                int pos = displayField.Text.IndexOf(toStrip);
                if(pos>=0)
                    displayField.Text = displayField.Text.Remove(pos, toStrip.Length);
                clearAfterEvaluate = false;
                displayField.SelectionStart = displayField.Text.Length;
            }
        }

        private void displayField_TextChanged(object sender, EventArgs e)
        {
            clearTextAfterEvaluate(sender, e);
        }
    }
}
