namespace Dz_na_25._11
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            labelInfo = new Label();
            textBoxName = new TextBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownQuantity = new NumericUpDown();
            comboBoxCountri = new ComboBox();
            numericUpDownDiscount = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonCancel = new Button();
            buttonOK = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = SystemColors.ActiveCaption;
            labelInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfo.ForeColor = Color.Red;
            labelInfo.Location = new Point(68, 31);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(211, 31);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "vrora Info Product";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.Location = new Point(115, 65);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(164, 30);
            textBoxName.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownPrice.Location = new Point(115, 98);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(164, 30);
            numericUpDownPrice.TabIndex = 2;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownQuantity.Location = new Point(115, 131);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(164, 30);
            numericUpDownQuantity.TabIndex = 3;
            // 
            // comboBoxCountri
            // 
            comboBoxCountri.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCountri.FormattingEnabled = true;
            comboBoxCountri.Location = new Point(115, 164);
            comboBoxCountri.Name = "comboBoxCountri";
            comboBoxCountri.Size = new Size(164, 31);
            comboBoxCountri.TabIndex = 4;
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownDiscount.Location = new Point(115, 198);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(164, 30);
            numericUpDownDiscount.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 65);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 97);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 130);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 164);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 9;
            label5.Text = "Cauntry";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 197);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 10;
            label6.Text = "Discount";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 255, 192);
            buttonCancel.Location = new Point(115, 231);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(79, 29);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = SystemColors.GradientInactiveCaption;
            buttonOK.Location = new Point(200, 231);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(79, 29);
            buttonOK.TabIndex = 12;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(19, 26);
            button3.Name = "button3";
            button3.Size = new Size(47, 36);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(327, 283);
            Controls.Add(button3);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(comboBoxCountri);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelInfo);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownQuantity;
        private ComboBox comboBoxCountri;
        private NumericUpDown numericUpDownDiscount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonCancel;
        private Button buttonOK;
        private Button button3;
    }
}