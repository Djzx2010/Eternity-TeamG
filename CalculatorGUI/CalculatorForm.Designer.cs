
using System;
using System.Windows.Forms;

namespace CalculatorGUI
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonModulus = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonClosedBracket = new System.Windows.Forms.Button();
            this.buttonOpenBracket = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.buttonSTD = new System.Windows.Forms.Button();
            this.buttonArccos = new System.Windows.Forms.Button();
            this.buttonExponent = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonGamma = new System.Windows.Forms.Button();
            this.buttonMAD = new System.Windows.Forms.Button();
            this.buttonSinh = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonTrigUnits = new System.Windows.Forms.Button();
            this.displayField = new System.Windows.Forms.TextBox();
            this.MC = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEvaluate, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDecimal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDivide, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiply, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonModulus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonComma, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonClosedBracket, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpenBracket, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(172, 206);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEvaluate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEvaluate.Location = new System.Drawing.Point(252, 311);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(80, 73);
            this.buttonEvaluate.TabIndex = 19;
            this.buttonEvaluate.Text = "=";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecimal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDecimal.Location = new System.Drawing.Point(169, 311);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(77, 73);
            this.buttonDecimal.TabIndex = 18;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlus.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(252, 234);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(80, 71);
            this.buttonPlus.TabIndex = 15;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(169, 234);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 71);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(86, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 71);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(3, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 71);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinus.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(252, 157);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(80, 71);
            this.buttonMinus.TabIndex = 11;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(169, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 71);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(86, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 71);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(3, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 71);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDivide.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(252, 80);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(80, 71);
            this.buttonDivide.TabIndex = 7;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(169, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 71);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(86, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 71);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultiply.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(252, 3);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(80, 71);
            this.buttonMultiply.TabIndex = 3;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonModulus
            // 
            this.buttonModulus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModulus.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModulus.Location = new System.Drawing.Point(169, 3);
            this.buttonModulus.Name = "buttonModulus";
            this.buttonModulus.Size = new System.Drawing.Size(77, 71);
            this.buttonModulus.TabIndex = 2;
            this.buttonModulus.Text = "%";
            this.buttonModulus.UseVisualStyleBackColor = true;
            this.buttonModulus.Click += new System.EventHandler(this.buttonModulus_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Location = new System.Drawing.Point(3, 311);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(77, 73);
            this.buttonComma.TabIndex = 4;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.buttonComma_Click);
            // 
            // buttonClosedBracket
            // 
            this.buttonClosedBracket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClosedBracket.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClosedBracket.Location = new System.Drawing.Point(86, 3);
            this.buttonClosedBracket.Name = "buttonClosedBracket";
            this.buttonClosedBracket.Size = new System.Drawing.Size(77, 71);
            this.buttonClosedBracket.TabIndex = 1;
            this.buttonClosedBracket.Text = ")";
            this.buttonClosedBracket.UseVisualStyleBackColor = true;
            this.buttonClosedBracket.Click += new System.EventHandler(this.buttonClosedBracket_Click);
            // 
            // buttonOpenBracket
            // 
            this.buttonOpenBracket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenBracket.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenBracket.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenBracket.Name = "buttonOpenBracket";
            this.buttonOpenBracket.Size = new System.Drawing.Size(77, 71);
            this.buttonOpenBracket.TabIndex = 0;
            this.buttonOpenBracket.Text = "(";
            this.buttonOpenBracket.UseVisualStyleBackColor = true;
            this.buttonOpenBracket.Click += new System.EventHandler(this.buttonOpenBracket_Click);
            // 
            // button0
            // 
            this.button0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button0.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(86, 311);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(77, 73);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 20;
            this.listBoxHistory.Location = new System.Drawing.Point(172, 31);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(335, 104);
            this.listBoxHistory.TabIndex = 2;
            this.listBoxHistory.DoubleClick += new System.EventHandler(this.listBoxHistory_DoubleClick);
            // 
            // buttonSTD
            // 
            this.buttonSTD.Location = new System.Drawing.Point(12, 195);
            this.buttonSTD.Name = "buttonSTD";
            this.buttonSTD.Size = new System.Drawing.Size(62, 53);
            this.buttonSTD.TabIndex = 3;
            this.buttonSTD.Text = "σ";
            this.toolTipInfo.SetToolTip(this.buttonSTD, "σ(x1, x2, x3, ..., xn)");
            this.buttonSTD.UseVisualStyleBackColor = true;
            this.buttonSTD.Click += new System.EventHandler(this.buttonSTD_Click);
            // 
            // buttonArccos
            // 
            this.buttonArccos.Location = new System.Drawing.Point(80, 198);
            this.buttonArccos.Name = "buttonArccos";
            this.buttonArccos.Size = new System.Drawing.Size(64, 53);
            this.buttonArccos.TabIndex = 5;
            this.buttonArccos.Text = "Arccos";
            this.toolTipInfo.SetToolTip(this.buttonArccos, "Arccos(x)");
            this.buttonArccos.UseVisualStyleBackColor = true;
            this.buttonArccos.Click += new System.EventHandler(this.buttonArccos_Click);
            // 
            // buttonExponent
            // 
            this.buttonExponent.Location = new System.Drawing.Point(10, 254);
            this.buttonExponent.Name = "buttonExponent";
            this.buttonExponent.Size = new System.Drawing.Size(64, 54);
            this.buttonExponent.TabIndex = 6;
            this.buttonExponent.Text = "ab˟";
            this.toolTipInfo.SetToolTip(this.buttonExponent, "Pow(base, exponent)");
            this.buttonExponent.UseVisualStyleBackColor = true;
            this.buttonExponent.Click += new System.EventHandler(this.buttonExponent_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(81, 254);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(64, 54);
            this.buttonLog.TabIndex = 7;
            this.buttonLog.Text = "log";
            this.toolTipInfo.SetToolTip(this.buttonLog, "log(base, x) ");
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonGamma
            // 
            this.buttonGamma.Location = new System.Drawing.Point(12, 141);
            this.buttonGamma.Name = "buttonGamma";
            this.buttonGamma.Size = new System.Drawing.Size(64, 48);
            this.buttonGamma.TabIndex = 8;
            this.buttonGamma.Text = "Γ";
            this.buttonGamma.UseVisualStyleBackColor = true;
            this.buttonGamma.Click += new System.EventHandler(this.buttonGamma_Click);
            // 
            // buttonMAD
            // 
            this.buttonMAD.Location = new System.Drawing.Point(12, 314);
            this.buttonMAD.Name = "buttonMAD";
            this.buttonMAD.Size = new System.Drawing.Size(62, 51);
            this.buttonMAD.TabIndex = 9;
            this.buttonMAD.Text = "MAD";
            this.buttonMAD.UseVisualStyleBackColor = true;
            this.buttonMAD.Click += new System.EventHandler(this.buttonMAD_Click);
            // 
            // buttonSinh
            // 
            this.buttonSinh.Location = new System.Drawing.Point(80, 314);
            this.buttonSinh.Name = "buttonSinh";
            this.buttonSinh.Size = new System.Drawing.Size(65, 51);
            this.buttonSinh.TabIndex = 10;
            this.buttonSinh.Text = "sinh";
            this.buttonSinh.UseVisualStyleBackColor = true;
            this.buttonSinh.Click += new System.EventHandler(this.buttonSinh_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 431);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 48);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "CLR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.newToolStripMenuItem.Text = "&Settings";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.openToolStripMenuItem.Text = "&Open CSV";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(208, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(10, 485);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(134, 54);
            this.button11.TabIndex = 14;
            this.button11.Text = "arr";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(13, 371);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 54);
            this.button10.TabIndex = 15;
            this.button10.Text = "π";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 545);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(134, 54);
            this.button12.TabIndex = 16;
            this.button12.Text = "ans";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(83, 371);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 54);
            this.button13.TabIndex = 17;
            this.button13.Text = "e";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonTrigUnits
            // 
            this.buttonTrigUnits.Location = new System.Drawing.Point(82, 141);
            this.buttonTrigUnits.Name = "buttonTrigUnits";
            this.buttonTrigUnits.Size = new System.Drawing.Size(64, 51);
            this.buttonTrigUnits.TabIndex = 18;
            this.buttonTrigUnits.Text = "RAD";
            this.buttonTrigUnits.UseVisualStyleBackColor = true;
            this.buttonTrigUnits.Click += new System.EventHandler(this.buttonTrigUnits_Click);
            // 
            // displayField
            // 
            this.displayField.BackColor = System.Drawing.SystemColors.Menu;
            this.displayField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayField.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayField.Location = new System.Drawing.Point(175, 139);
            this.displayField.Name = "displayField";
            this.displayField.Size = new System.Drawing.Size(332, 61);
            this.displayField.TabIndex = 19;
            this.displayField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(13, 31);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(64, 47);
            this.MC.TabIndex = 20;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(80, 31);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(64, 47);
            this.MR.TabIndex = 21;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(13, 84);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(133, 47);
            this.MS.TabIndex = 22;
            this.MS.Text = "MS";
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(519, 605);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.displayField);
            this.Controls.Add(this.buttonTrigUnits);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSinh);
            this.Controls.Add(this.buttonMAD);
            this.Controls.Add(this.buttonGamma);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonExponent);
            this.Controls.Add(this.buttonArccos);
            this.Controls.Add(this.buttonSTD);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button evaluate;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonModulus;
        private System.Windows.Forms.Button buttonClosedBracket;
        private System.Windows.Forms.Button buttonOpenBracket;
        private System.Windows.Forms.Button buttonEvaluate;
        private ListBox listBoxHistory;
        private Button buttonSTD;
        private Button buttonComma;
        private Button buttonArccos;
        private Button buttonExponent;
        private Button buttonLog;
        private Button buttonGamma;
        private Button buttonMAD;
        private Button buttonSinh;
        private Button buttonClear;
        private ToolTip toolTipInfo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button11;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button buttonTrigUnits;
        private TextBox displayField;
        private Button MC;
        private Button MR;
        private Button MS;
    }
}

