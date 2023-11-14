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
            MaxSymbolsLabel = new Label();
            TextBox = new TextBox();
            SymbolsProgressBar = new ProgressBar();
            SymbolsLabel = new Label();
            MaxLenghtLabel = new Label();
            MaxSymbolsNumericUpDown = new NumericUpDown();
            ToolTipProgresBar = new ToolTip(components);
            ToolTipNumericUpDown = new ToolTip(components);
            CountWordLabel = new Label();
            WordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MaxSymbolsNumericUpDown).BeginInit();
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
            TextBox.Location = new Point(23, 40);
            TextBox.MaxLength = 100;
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.ScrollBars = ScrollBars.Vertical;
            TextBox.Size = new Size(765, 363);
            TextBox.TabIndex = 3;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // SymbolsProgressBar
            // 
            SymbolsProgressBar.ForeColor = SystemColors.ControlText;
            SymbolsProgressBar.Location = new Point(112, 417);
            SymbolsProgressBar.Name = "SymbolsProgressBar";
            SymbolsProgressBar.Size = new Size(140, 17);
            SymbolsProgressBar.TabIndex = 4;
            ToolTipProgresBar.SetToolTip(SymbolsProgressBar, "Показує кількість введених слів у вигляді шкали прогресу");
            // 
            // SymbolsLabel
            // 
            SymbolsLabel.AutoSize = true;
            SymbolsLabel.Font = new Font("Ink Free", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            SymbolsLabel.Location = new Point(23, 412);
            SymbolsLabel.Name = "SymbolsLabel";
            SymbolsLabel.Size = new Size(93, 25);
            SymbolsLabel.TabIndex = 5;
            SymbolsLabel.Text = "Symbols ";
            // 
            // MaxLenghtLabel
            // 
            MaxLenghtLabel.AutoSize = true;
            MaxLenghtLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaxLenghtLabel.Location = new Point(269, 409);
            MaxLenghtLabel.Name = "MaxLenghtLabel";
            MaxLenghtLabel.Size = new Size(30, 28);
            MaxLenghtLabel.TabIndex = 6;
            MaxLenghtLabel.Text = ":D";
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
            // CountWordLabel
            // 
            CountWordLabel.AutoSize = true;
            CountWordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountWordLabel.Location = new Point(721, 406);
            CountWordLabel.Name = "CountWordLabel";
            CountWordLabel.Size = new Size(30, 28);
            CountWordLabel.TabIndex = 8;
            CountWordLabel.Text = ";D";
            // 
            // WordLabel
            // 
            WordLabel.AutoSize = true;
            WordLabel.Font = new Font("Ink Free", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            WordLabel.Location = new Point(658, 409);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(60, 27);
            WordLabel.TabIndex = 9;
            WordLabel.Text = "Word";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(WordLabel);
            Controls.Add(CountWordLabel);
            Controls.Add(MaxSymbolsNumericUpDown);
            Controls.Add(MaxLenghtLabel);
            Controls.Add(SymbolsLabel);
            Controls.Add(SymbolsProgressBar);
            Controls.Add(TextBox);
            Controls.Add(MaxSymbolsLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)MaxSymbolsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MaxSymbolsLabel;
        private TextBox TextBox;
        private ProgressBar SymbolsProgressBar;
        private Label SymbolsLabel;
        private Label MaxLenghtLabel;
        private NumericUpDown MaxSymbolsNumericUpDown;
        private ToolTip ToolTipProgresBar;
        private ToolTip ToolTipNumericUpDown;
        private Label CountWordLabel;
        private Label WordLabel;
    }
}