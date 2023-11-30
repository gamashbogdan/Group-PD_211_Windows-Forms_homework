namespace _09_Graphics_GDI
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
            pictureBox = new PictureBox();
            panelMenu = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            trackBar1 = new TrackBar();
            trackBar = new TrackBar();
            label = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            pic_color = new Button();
            colorPicker = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colorPicker).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1527, 700);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += button1_Click;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DimGray;
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(toolStrip1);
            panelMenu.Controls.Add(pic_color);
            panelMenu.Controls.Add(colorPicker);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1527, 187);
            panelMenu.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(trackBar);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(485, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 150);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(236, 91);
            label3.Name = "label3";
            label3.Size = new Size(27, 31);
            label3.TabIndex = 17;
            label3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(236, 18);
            label2.Name = "label2";
            label2.Size = new Size(27, 31);
            label2.TabIndex = 16;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(204, 31);
            label1.TabIndex = 15;
            label1.Text = "Товщина лінії гумки";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(329, 18);
            trackBar1.Maximum = 500;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(634, 56);
            trackBar1.TabIndex = 14;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(329, 91);
            trackBar.Maximum = 500;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(634, 56);
            trackBar.TabIndex = 12;
            trackBar.ValueChanged += trackBar1_ValueChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(0, 91);
            label.Name = "label";
            label.Size = new Size(230, 31);
            label.TabIndex = 13;
            label.Text = "Товщина лінії пензлика";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3, toolStripButton2 });
            toolStrip1.Location = new Point(485, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1042, 37);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 34);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += buttonClear_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 34);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 34);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += buttonSave_Click;
            // 
            // pic_color
            // 
            pic_color.FlatStyle = FlatStyle.Flat;
            pic_color.Location = new Point(427, 93);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(41, 37);
            pic_color.TabIndex = 15;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // colorPicker
            // 
            colorPicker.BackColor = Color.DimGray;
            colorPicker.Dock = DockStyle.Left;
            colorPicker.Image = (Image)resources.GetObject("colorPicker.Image");
            colorPicker.Location = new Point(0, 0);
            colorPicker.Name = "colorPicker";
            colorPicker.Size = new Size(485, 187);
            colorPicker.TabIndex = 14;
            colorPicker.TabStop = false;
            colorPicker.MouseClick += colorPicker_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 700);
            Controls.Add(panelMenu);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)colorPicker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Panel panelMenu;
        private Label label;
        private TrackBar trackBar;
        private PictureBox colorPicker;
        private Panel panel1;
        private Button pic_color;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private TrackBar trackBar1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}