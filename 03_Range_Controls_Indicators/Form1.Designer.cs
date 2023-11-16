namespace Dz_na_20._11
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MaxSymbolsLabel = new Label();
            TextBox = new TextBox();
            MaxSymbolsNumericUpDown = new NumericUpDown();
            ToolTipProgresBar = new ToolTip(components);
            ToolTipNumericUpDown = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripSymbolsProgressBar = new ToolStripProgressBar();
            toolStripMaxLenghtLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripCountNumbersLabel = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripCountSymbolsLabel = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripCountWordsLabel = new ToolStripStatusLabel();
            toolStripSetingBatton = new ToolStripSplitButton();
            setingColorToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)MaxSymbolsNumericUpDown).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MaxSymbolsLabel
            // 
            MaxSymbolsLabel.AutoSize = true;
            MaxSymbolsLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MaxSymbolsLabel.Location = new Point(23, 3);
            MaxSymbolsLabel.Name = "MaxSymbolsLabel";
            MaxSymbolsLabel.Size = new Size(175, 34);
            MaxSymbolsLabel.TabIndex = 1;
            MaxSymbolsLabel.Text = "Max Symbols";
            // 
            // TextBox
            // 
            TextBox.BackColor = Color.LightCyan;
            TextBox.Font = new Font("Ink Free", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            TextBox.Location = new Point(12, 40);
            TextBox.MaxLength = 100;
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.ScrollBars = ScrollBars.Vertical;
            TextBox.Size = new Size(776, 359);
            TextBox.TabIndex = 3;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // MaxSymbolsNumericUpDown
            // 
            MaxSymbolsNumericUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MaxSymbolsNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            MaxSymbolsNumericUpDown.Location = new Point(199, 3);
            MaxSymbolsNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            MaxSymbolsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MaxSymbolsNumericUpDown.Name = "MaxSymbolsNumericUpDown";
            MaxSymbolsNumericUpDown.Size = new Size(150, 30);
            MaxSymbolsNumericUpDown.TabIndex = 7;
            ToolTipNumericUpDown.SetToolTip(MaxSymbolsNumericUpDown, "Діапазон від 0 до 10 000\r\n\r\n");
            ToolTipProgresBar.SetToolTip(MaxSymbolsNumericUpDown, "\r\n");
            MaxSymbolsNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            MaxSymbolsNumericUpDown.ValueChanged += MaxSymbolsNumericUpDown_ValueChanged;
            // 
            // ToolTipProgresBar
            // 
            ToolTipProgresBar.Tag = "";
            ToolTipProgresBar.ToolTipIcon = ToolTipIcon.Info;
            // 
            // ToolTipNumericUpDown
            // 
            ToolTipNumericUpDown.Tag = "";
            ToolTipNumericUpDown.ToolTipIcon = ToolTipIcon.Info;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripSymbolsProgressBar, toolStripMaxLenghtLabel, toolStripStatusLabel2, toolStripCountNumbersLabel, toolStripStatusLabel3, toolStripCountSymbolsLabel, toolStripStatusLabel4, toolStripCountWordsLabel, toolStripSetingBatton });
            statusStrip1.Location = new Point(0, 417);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 33);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Ink Free", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(90, 27);
            toolStripStatusLabel1.Text = "Symbols";
            // 
            // toolStripSymbolsProgressBar
            // 
            toolStripSymbolsProgressBar.Name = "toolStripSymbolsProgressBar";
            toolStripSymbolsProgressBar.Size = new Size(140, 25);
            // 
            // toolStripMaxLenghtLabel
            // 
            toolStripMaxLenghtLabel.Name = "toolStripMaxLenghtLabel";
            toolStripMaxLenghtLabel.Size = new Size(47, 27);
            toolStripMaxLenghtLabel.Text = "0/100";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(73, 27);
            toolStripStatusLabel2.Text = "Number";
            // 
            // toolStripCountNumbersLabel
            // 
            toolStripCountNumbersLabel.Name = "toolStripCountNumbersLabel";
            toolStripCountNumbersLabel.Size = new Size(17, 27);
            toolStripCountNumbersLabel.Text = "0";
            toolStripCountNumbersLabel.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(64, 27);
            toolStripStatusLabel3.Text = "Symbol";
            // 
            // toolStripCountSymbolsLabel
            // 
            toolStripCountSymbolsLabel.Name = "toolStripCountSymbolsLabel";
            toolStripCountSymbolsLabel.Size = new Size(17, 27);
            toolStripCountSymbolsLabel.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(48, 27);
            toolStripStatusLabel4.Text = "Word";
            // 
            // toolStripCountWordsLabel
            // 
            toolStripCountWordsLabel.Name = "toolStripCountWordsLabel";
            toolStripCountWordsLabel.Size = new Size(17, 27);
            toolStripCountWordsLabel.Text = "0";
            // 
            // toolStripSetingBatton
            // 
            toolStripSetingBatton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSetingBatton.DropDownItems.AddRange(new ToolStripItem[] { setingColorToolStripMenuItem });
            toolStripSetingBatton.Image = (Image)resources.GetObject("toolStripSetingBatton.Image");
            toolStripSetingBatton.ImageTransparentColor = Color.Magenta;
            toolStripSetingBatton.Name = "toolStripSetingBatton";
            toolStripSetingBatton.Size = new Size(39, 31);
            toolStripSetingBatton.Text = "toolStripSplitButton1";
            toolStripSetingBatton.ButtonClick += toolStripSetingBatton_ButtonClick;
            // 
            // setingColorToolStripMenuItem
            // 
            setingColorToolStripMenuItem.Name = "setingColorToolStripMenuItem";
            setingColorToolStripMenuItem.Size = new Size(172, 26);
            setingColorToolStripMenuItem.Text = "Seting color";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(MaxSymbolsNumericUpDown);
            Controls.Add(TextBox);
            Controls.Add(MaxSymbolsLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Notepad--";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)MaxSymbolsNumericUpDown).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MaxSymbolsLabel;
        private TextBox TextBox;
        private NumericUpDown MaxSymbolsNumericUpDown;
        private ToolTip ToolTipProgresBar;
        private ToolTip ToolTipNumericUpDown;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripSymbolsProgressBar;
        private ToolStripStatusLabel toolStripMaxLenghtLabel;
        private ToolStripStatusLabel toolStripCountNumbersLabel;
        private ToolStripStatusLabel toolStripCountSymbolsLabel;
        private ToolStripStatusLabel toolStripCountWordsLabel;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripSplitButton toolStripSetingBatton;
        private ToolStripMenuItem setingColorToolStripMenuItem;
    }
}