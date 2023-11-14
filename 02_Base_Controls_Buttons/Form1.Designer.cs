namespace Dz_na._18._11
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
            btn_Order = new Button();
            textBox_Last_Name = new TextBox();
            Last_Name_Label = new Label();
            Name_Label = new Label();
            textBox_Name = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            Number_Label = new Label();
            numericUpDown_People = new NumericUpDown();
            People_Label = new Label();
            radioButton_Econom = new RadioButton();
            radioButton_Standart = new RadioButton();
            radioButton_Luxe = new RadioButton();
            Number_of_type_Label = new Label();
            monthCalendar1 = new MonthCalendar();
            textBox_Comentar = new TextBox();
            label2 = new Label();
            Data_Label = new Label();
            Casel_Batton = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_People).BeginInit();
            SuspendLayout();
            // 
            // btn_Order
            // 
            btn_Order.BackColor = Color.FromArgb(192, 255, 192);
            btn_Order.Location = new Point(642, 399);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(146, 39);
            btn_Order.TabIndex = 0;
            btn_Order.Text = "Замовити";
            btn_Order.UseVisualStyleBackColor = false;
            btn_Order.Click += btn_Order_Click;
            // 
            // textBox_Last_Name
            // 
            textBox_Last_Name.Location = new Point(246, 126);
            textBox_Last_Name.Name = "textBox_Last_Name";
            textBox_Last_Name.Size = new Size(161, 27);
            textBox_Last_Name.TabIndex = 1;
            // 
            // Last_Name_Label
            // 
            Last_Name_Label.AutoSize = true;
            Last_Name_Label.Location = new Point(246, 103);
            Last_Name_Label.Name = "Last_Name_Label";
            Last_Name_Label.Size = new Size(87, 20);
            Last_Name_Label.TabIndex = 2;
            Last_Name_Label.Text = "* Прізвище";
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.Location = new Point(48, 103);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(45, 20);
            Name_Label.TabIndex = 3;
            Name_Label.Text = "* Ім'я";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(48, 126);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(162, 27);
            textBox_Name.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(49, 192);
            maskedTextBox1.Mask = "+380(99)-999-99-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(161, 27);
            maskedTextBox1.TabIndex = 5;
            // 
            // Number_Label
            // 
            Number_Label.AutoSize = true;
            Number_Label.Location = new Point(49, 169);
            Number_Label.Name = "Number_Label";
            Number_Label.Size = new Size(128, 20);
            Number_Label.TabIndex = 6;
            Number_Label.Text = "Номер Телефону";
            // 
            // numericUpDown_People
            // 
            numericUpDown_People.Location = new Point(246, 193);
            numericUpDown_People.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_People.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_People.Name = "numericUpDown_People";
            numericUpDown_People.Size = new Size(162, 27);
            numericUpDown_People.TabIndex = 7;
            numericUpDown_People.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // People_Label
            // 
            People_Label.AutoSize = true;
            People_Label.Location = new Point(246, 170);
            People_Label.Name = "People_Label";
            People_Label.Size = new Size(119, 20);
            People_Label.TabIndex = 8;
            People_Label.Text = "Кількість людей";
            // 
            // radioButton_Econom
            // 
            radioButton_Econom.AutoSize = true;
            radioButton_Econom.Location = new Point(363, 286);
            radioButton_Econom.Name = "radioButton_Econom";
            radioButton_Econom.Size = new Size(83, 24);
            radioButton_Econom.TabIndex = 9;
            radioButton_Econom.TabStop = true;
            radioButton_Econom.Text = "Економ";
            radioButton_Econom.UseVisualStyleBackColor = true;
            // 
            // radioButton_Standart
            // 
            radioButton_Standart.AutoSize = true;
            radioButton_Standart.Location = new Point(363, 316);
            radioButton_Standart.Name = "radioButton_Standart";
            radioButton_Standart.Size = new Size(93, 24);
            radioButton_Standart.TabIndex = 10;
            radioButton_Standart.TabStop = true;
            radioButton_Standart.Text = "Стандарт";
            radioButton_Standart.UseVisualStyleBackColor = true;
            // 
            // radioButton_Luxe
            // 
            radioButton_Luxe.AutoSize = true;
            radioButton_Luxe.Location = new Point(363, 346);
            radioButton_Luxe.Name = "radioButton_Luxe";
            radioButton_Luxe.Size = new Size(66, 24);
            radioButton_Luxe.TabIndex = 11;
            radioButton_Luxe.TabStop = true;
            radioButton_Luxe.Text = "Люкс";
            radioButton_Luxe.UseVisualStyleBackColor = true;
            // 
            // Number_of_type_Label
            // 
            Number_of_type_Label.AutoSize = true;
            Number_of_type_Label.Location = new Point(353, 263);
            Number_of_type_Label.Name = "Number_of_type_Label";
            Number_of_type_Label.Size = new Size(103, 20);
            Number_of_type_Label.TabIndex = 12;
            Number_of_type_Label.Text = "* Тип номера";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(590, 126);
            monthCalendar1.MaxSelectionCount = 365;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ScrollChange = 1;
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.TabIndex = 13;
            monthCalendar1.TodayDate = new DateTime(2023, 11, 12, 0, 0, 0, 0);
            // 
            // textBox_Comentar
            // 
            textBox_Comentar.Location = new Point(47, 271);
            textBox_Comentar.Multiline = true;
            textBox_Comentar.Name = "textBox_Comentar";
            textBox_Comentar.Size = new Size(276, 124);
            textBox_Comentar.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 248);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 16;
            label2.Text = "Коментар";
            // 
            // Data_Label
            // 
            Data_Label.AutoSize = true;
            Data_Label.Location = new Point(585, 97);
            Data_Label.Name = "Data_Label";
            Data_Label.Size = new Size(197, 20);
            Data_Label.TabIndex = 17;
            Data_Label.Text = "Виберіть дату проживання";
            // 
            // Casel_Batton
            // 
            Casel_Batton.BackColor = Color.FromArgb(255, 128, 128);
            Casel_Batton.Location = new Point(473, 399);
            Casel_Batton.Name = "Casel_Batton";
            Casel_Batton.Size = new Size(146, 39);
            Casel_Batton.TabIndex = 18;
            Casel_Batton.Text = "Відмінити";
            Casel_Batton.UseVisualStyleBackColor = false;
            Casel_Batton.Click += Casel_Batton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(264, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 49);
            label1.TabIndex = 19;
            label1.Text = "Готель  Мрія";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(642, 369);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 24);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Я не робот";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(Casel_Batton);
            Controls.Add(Data_Label);
            Controls.Add(label2);
            Controls.Add(textBox_Comentar);
            Controls.Add(monthCalendar1);
            Controls.Add(Number_of_type_Label);
            Controls.Add(radioButton_Luxe);
            Controls.Add(radioButton_Standart);
            Controls.Add(radioButton_Econom);
            Controls.Add(People_Label);
            Controls.Add(numericUpDown_People);
            Controls.Add(Number_Label);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox_Name);
            Controls.Add(Name_Label);
            Controls.Add(Last_Name_Label);
            Controls.Add(textBox_Last_Name);
            Controls.Add(btn_Order);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_People).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Order;
        private TextBox textBox_Last_Name;
        private Label Last_Name_Label;
        private Label Name_Label;
        private TextBox textBox_Name;
        private MaskedTextBox maskedTextBox1;
        private Label Number_Label;
        private NumericUpDown numericUpDown_People;
        private Label People_Label;
        private RadioButton radioButton_Econom;
        private RadioButton radioButton_Standart;
        private RadioButton radioButton_Luxe;
        private Label Number_of_type_Label;
        private MonthCalendar monthCalendar1;
        private TextBox textBox_Comentar;
        private Label label2;
        private Label Data_Label;
        private Button Casel_Batton;
        private Label label1;
        private CheckBox checkBox1;
    }
}