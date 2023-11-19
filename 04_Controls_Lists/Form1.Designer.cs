namespace Dz_na_23._11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxModel = new TextBox();
            numericUpDownYear = new NumericUpDown();
            comboBoxColors = new ComboBox();
            numericUpDownProbig = new NumericUpDown();
            labelNewCar = new Label();
            labelModel = new Label();
            labelYear = new Label();
            labelColors = new Label();
            labelProbig = new Label();
            labelValue = new Label();
            buttonAddCar = new Button();
            buttonDeleteCar = new Button();
            buttonShowCar = new Button();
            listBoxCars = new ListBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            labelCarList = new Label();
            numericUpDownValue = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProbig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).BeginInit();
            SuspendLayout();
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxModel.Location = new Point(117, 53);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(151, 27);
            textBoxModel.TabIndex = 0;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.AccessibleDescription = "";
            numericUpDownYear.AccessibleName = "";
            numericUpDownYear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownYear.Location = new Point(117, 100);
            numericUpDownYear.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(150, 27);
            numericUpDownYear.TabIndex = 1;
            numericUpDownYear.Tag = "";
            numericUpDownYear.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // comboBoxColors
            // 
            comboBoxColors.DropDownWidth = 300;
            comboBoxColors.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxColors.ItemHeight = 20;
            comboBoxColors.Items.AddRange(new object[] { "Red", "Orange", "Yellow", "Green", "Blue", "Рurple", "Pink", "White", "Black", "Brown", "Gray", "Gold – золотий", "Olive – оливковий", "Amber – бурштиновий", "Peach – персиковий", "Body color – тілесний відтінок", "Sky color – небесний", "Chocolate – шоколадний", "Cream – кремовий", "Lilac - сірий", "Emerald - смарагдовий", "Orange – помаранчевий", "Snow – сніговий", "Camel – жовтувато-коричневий колір" });
            comboBoxColors.Location = new Point(117, 144);
            comboBoxColors.Name = "comboBoxColors";
            comboBoxColors.Size = new Size(151, 28);
            comboBoxColors.TabIndex = 2;
            // 
            // numericUpDownProbig
            // 
            numericUpDownProbig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownProbig.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownProbig.Location = new Point(116, 191);
            numericUpDownProbig.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownProbig.Name = "numericUpDownProbig";
            numericUpDownProbig.Size = new Size(152, 27);
            numericUpDownProbig.TabIndex = 3;
            // 
            // labelNewCar
            // 
            labelNewCar.AutoSize = true;
            labelNewCar.BackColor = Color.FromArgb(224, 224, 224);
            labelNewCar.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            labelNewCar.Location = new Point(117, 6);
            labelNewCar.Name = "labelNewCar";
            labelNewCar.Size = new Size(118, 31);
            labelNewCar.TabIndex = 5;
            labelNewCar.Text = "NEW CAR";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.BackColor = Color.FromArgb(224, 224, 224);
            labelModel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.Location = new Point(32, 55);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(66, 25);
            labelModel.TabIndex = 6;
            labelModel.Text = "Model";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.FromArgb(224, 224, 224);
            labelYear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelYear.Location = new Point(32, 100);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(48, 25);
            labelYear.TabIndex = 7;
            labelYear.Text = "Year";
            // 
            // labelColors
            // 
            labelColors.AutoSize = true;
            labelColors.BackColor = Color.FromArgb(224, 224, 224);
            labelColors.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelColors.Location = new Point(32, 152);
            labelColors.Name = "labelColors";
            labelColors.Size = new Size(65, 25);
            labelColors.TabIndex = 8;
            labelColors.Text = "Colors";
            // 
            // labelProbig
            // 
            labelProbig.AutoSize = true;
            labelProbig.BackColor = Color.FromArgb(224, 224, 224);
            labelProbig.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelProbig.Location = new Point(32, 198);
            labelProbig.Name = "labelProbig";
            labelProbig.Size = new Size(68, 25);
            labelProbig.TabIndex = 9;
            labelProbig.Text = "Probig";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.BackColor = Color.FromArgb(224, 224, 224);
            labelValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelValue.Location = new Point(32, 238);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(59, 25);
            labelValue.TabIndex = 10;
            labelValue.Text = "Value";
            // 
            // buttonAddCar
            // 
            buttonAddCar.BackColor = Color.FromArgb(192, 255, 192);
            buttonAddCar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCar.Location = new Point(32, 278);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(236, 37);
            buttonAddCar.TabIndex = 11;
            buttonAddCar.Text = "ADD CAR";
            buttonAddCar.UseVisualStyleBackColor = false;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonDeleteCar
            // 
            buttonDeleteCar.BackColor = Color.FromArgb(255, 192, 192);
            buttonDeleteCar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteCar.Location = new Point(31, 332);
            buttonDeleteCar.Name = "buttonDeleteCar";
            buttonDeleteCar.Size = new Size(236, 37);
            buttonDeleteCar.TabIndex = 12;
            buttonDeleteCar.Text = "DELETE SELECTED CAR";
            buttonDeleteCar.UseVisualStyleBackColor = false;
            buttonDeleteCar.Click += buttonDeleteCar_Click;
            // 
            // buttonShowCar
            // 
            buttonShowCar.BackColor = Color.FromArgb(255, 255, 192);
            buttonShowCar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowCar.Location = new Point(31, 386);
            buttonShowCar.Name = "buttonShowCar";
            buttonShowCar.Size = new Size(236, 37);
            buttonShowCar.TabIndex = 13;
            buttonShowCar.Text = "SHOW CAR";
            buttonShowCar.UseVisualStyleBackColor = false;
            buttonShowCar.Click += buttonShowCar_Click;
            // 
            // listBoxCars
            // 
            listBoxCars.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxCars.ForeColor = SystemColors.WindowText;
            listBoxCars.FormattingEnabled = true;
            listBoxCars.ItemHeight = 23;
            listBoxCars.Location = new Point(375, 53);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.Size = new Size(386, 303);
            listBoxCars.TabIndex = 14;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkSeaGreen;
            buttonSave.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Location = new Point(375, 386);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 37);
            buttonSave.TabIndex = 15;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.DarkSalmon;
            buttonLoad.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLoad.Location = new Point(581, 386);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(180, 37);
            buttonLoad.TabIndex = 16;
            buttonLoad.Text = "LOAD";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // labelCarList
            // 
            labelCarList.AutoSize = true;
            labelCarList.BackColor = Color.FromArgb(224, 224, 224);
            labelCarList.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            labelCarList.Location = new Point(507, 9);
            labelCarList.Name = "labelCarList";
            labelCarList.Size = new Size(110, 31);
            labelCarList.TabIndex = 17;
            labelCarList.Text = "CAR LIST";
            // 
            // numericUpDownValue
            // 
            numericUpDownValue.DecimalPlaces = 1;
            numericUpDownValue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownValue.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownValue.Location = new Point(115, 236);
            numericUpDownValue.Maximum = new decimal(new int[] { 240, 0, 0, 65536 });
            numericUpDownValue.Minimum = new decimal(new int[] { 10, 0, 0, 65536 });
            numericUpDownValue.Name = "numericUpDownValue";
            numericUpDownValue.Size = new Size(152, 27);
            numericUpDownValue.TabIndex = 18;
            numericUpDownValue.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownValue);
            Controls.Add(labelCarList);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(listBoxCars);
            Controls.Add(buttonShowCar);
            Controls.Add(buttonDeleteCar);
            Controls.Add(buttonAddCar);
            Controls.Add(labelValue);
            Controls.Add(labelProbig);
            Controls.Add(labelColors);
            Controls.Add(labelYear);
            Controls.Add(labelModel);
            Controls.Add(labelNewCar);
            Controls.Add(numericUpDownProbig);
            Controls.Add(comboBoxColors);
            Controls.Add(numericUpDownYear);
            Controls.Add(textBoxModel);
            Name = "Form1";
            Tag = "dsfdsf";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProbig).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxModel;
        private NumericUpDown numericUpDownYear;
        private ComboBox comboBoxColors;
        private NumericUpDown numericUpDownProbig;
        private Label labelNewCar;
        private Label labelModel;
        private Label labelYear;
        private Label labelColors;
        private Label labelProbig;
        private Label labelValue;
        private Button buttonAddCar;
        private Button buttonDeleteCar;
        private Button buttonShowCar;
        private ListBox listBoxCars;
        private Button buttonSave;
        private Button buttonLoad;
        private Label labelCarList;
        private NumericUpDown numericUpDownValue;
    }
}