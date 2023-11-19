namespace Dz_na_25._11
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ListBox = new ListBox();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonAdd = new Button();
            buttonInfo = new Button();
            labelAvrora = new Label();
            button1 = new Button();
            toolTipEdit = new ToolTip(components);
            toolTipInfo = new ToolTip(components);
            toolTipRemove = new ToolTip(components);
            toolTipAdd = new ToolTip(components);
            SuspendLayout();
            // 
            // ListBox
            // 
            ListBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ListBox.ItemHeight = 31;
            ListBox.Location = new Point(32, 54);
            ListBox.Name = "ListBox";
            ListBox.ScrollAlwaysVisible = true;
            ListBox.Size = new Size(609, 252);
            ListBox.Sorted = true;
            ListBox.TabIndex = 0;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.NavajoWhite;
            buttonEdit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(32, 321);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(131, 42);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            toolTipEdit.SetToolTip(buttonEdit, "Редагувати продукт\r\n");
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(255, 128, 128);
            buttonRemove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.ForeColor = Color.Black;
            buttonRemove.Location = new Point(373, 321);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(131, 42);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "-";
            toolTipRemove.SetToolTip(buttonRemove, "Видалити продукт\r\n");
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(128, 255, 128);
            buttonAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAdd.Location = new Point(510, 321);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(131, 42);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "+";
            toolTipAdd.SetToolTip(buttonAdd, "Додати продукт\r\n");
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.OldLace;
            buttonInfo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInfo.Location = new Point(169, 321);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(131, 42);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "Info";
            toolTipInfo.SetToolTip(buttonInfo, "Інформація про продукт");
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // labelAvrora
            // 
            labelAvrora.AutoSize = true;
            labelAvrora.BackColor = Color.Gold;
            labelAvrora.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelAvrora.ForeColor = Color.Red;
            labelAvrora.Location = new Point(75, 17);
            labelAvrora.Name = "labelAvrora";
            labelAvrora.Size = new Size(71, 31);
            labelAvrora.TabIndex = 5;
            labelAvrora.Text = "vrora";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gold;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(32, 12);
            button1.Name = "button1";
            button1.Size = new Size(47, 36);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(675, 391);
            Controls.Add(button1);
            Controls.Add(labelAvrora);
            Controls.Add(buttonInfo);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(ListBox);
            Name = "MainForm";
            Text = "Avrora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBox;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonAdd;
        private Button buttonInfo;
        private Label labelAvrora;
        private Button button1;
        private ToolTip toolTipEdit;
        private ToolTip toolTipRemove;
        private ToolTip toolTipAdd;
        private ToolTip toolTipInfo;
    }
}