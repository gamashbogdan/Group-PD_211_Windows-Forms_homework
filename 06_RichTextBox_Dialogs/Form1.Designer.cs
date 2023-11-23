namespace Dz_na_27._11
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
            richTextBox1 = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButtonLoadFile = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonNewDocument = new ToolStripButton();
            toolStripButtonCopy = new ToolStripButton();
            toolStripButtonCut = new ToolStripButton();
            toolStripButtonPaste = new ToolStripButton();
            toolStripButtonClear = new ToolStripButton();
            toolStripButtonSetingColorText = new ToolStripButton();
            toolStripButtonSetingColorFont = new ToolStripButton();
            toolStripButtonSetingText = new ToolStripButton();
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            newDocumentToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItemExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyPasteToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            catToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            formaterToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            foreColorToolStripMenuItem = new ToolStripMenuItem();
            bacColorToolStripMenuItem = new ToolStripMenuItem();
            setingToolStripMenuItem = new ToolStripMenuItem();
            fontAllTextToolStripMenuItem = new ToolStripMenuItem();
            bacColorAllTexlToolStripMenuItem = new ToolStripMenuItem();
            foreColorAllTextToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 80);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.MaxLength = 10000;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(812, 469);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += TextBox_TextChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonLoadFile, toolStripButtonSave, toolStripButtonNewDocument, toolStripButtonCopy, toolStripButtonCut, toolStripButtonPaste, toolStripButtonClear, toolStripButtonSetingColorText, toolStripButtonSetingColorFont, toolStripButtonSetingText });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(838, 27);
            toolStrip1.TabIndex = 23;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLoadFile
            // 
            toolStripButtonLoadFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonLoadFile.Image = (Image)resources.GetObject("toolStripButtonLoadFile.Image");
            toolStripButtonLoadFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonLoadFile.Name = "toolStripButtonLoadFile";
            toolStripButtonLoadFile.Size = new Size(29, 24);
            toolStripButtonLoadFile.Click += toolStripButtonLoadFile_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(29, 24);
            toolStripButtonSave.Text = "Save";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripButtonNewDocument
            // 
            toolStripButtonNewDocument.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNewDocument.Image = (Image)resources.GetObject("toolStripButtonNewDocument.Image");
            toolStripButtonNewDocument.ImageTransparentColor = Color.Magenta;
            toolStripButtonNewDocument.Name = "toolStripButtonNewDocument";
            toolStripButtonNewDocument.Size = new Size(29, 24);
            toolStripButtonNewDocument.Text = "New Document";
            toolStripButtonNewDocument.Click += toolStripButtonNewDocument_Click;
            // 
            // toolStripButtonCopy
            // 
            toolStripButtonCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCopy.Image = (Image)resources.GetObject("toolStripButtonCopy.Image");
            toolStripButtonCopy.ImageTransparentColor = Color.Magenta;
            toolStripButtonCopy.Name = "toolStripButtonCopy";
            toolStripButtonCopy.Size = new Size(29, 24);
            toolStripButtonCopy.Text = "Copy";
            toolStripButtonCopy.Click += toolStripButtonCopy_Click;
            // 
            // toolStripButtonCut
            // 
            toolStripButtonCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCut.Image = (Image)resources.GetObject("toolStripButtonCut.Image");
            toolStripButtonCut.ImageTransparentColor = Color.Magenta;
            toolStripButtonCut.Name = "toolStripButtonCut";
            toolStripButtonCut.Size = new Size(29, 24);
            toolStripButtonCut.Text = "Cut";
            toolStripButtonCut.Click += toolStripButtonCut_Click;
            // 
            // toolStripButtonPaste
            // 
            toolStripButtonPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPaste.Image = (Image)resources.GetObject("toolStripButtonPaste.Image");
            toolStripButtonPaste.ImageTransparentColor = Color.Magenta;
            toolStripButtonPaste.Name = "toolStripButtonPaste";
            toolStripButtonPaste.Size = new Size(29, 24);
            toolStripButtonPaste.Text = "Paste";
            toolStripButtonPaste.Click += toolStripButtonPaste_Click;
            // 
            // toolStripButtonClear
            // 
            toolStripButtonClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClear.Image = (Image)resources.GetObject("toolStripButtonClear.Image");
            toolStripButtonClear.ImageTransparentColor = Color.Magenta;
            toolStripButtonClear.Name = "toolStripButtonClear";
            toolStripButtonClear.Size = new Size(29, 24);
            toolStripButtonClear.Text = "Clear";
            toolStripButtonClear.Click += toolStripButtonClear_Click;
            // 
            // toolStripButtonSetingColorText
            // 
            toolStripButtonSetingColorText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSetingColorText.Image = (Image)resources.GetObject("toolStripButtonSetingColorText.Image");
            toolStripButtonSetingColorText.ImageTransparentColor = Color.Magenta;
            toolStripButtonSetingColorText.Name = "toolStripButtonSetingColorText";
            toolStripButtonSetingColorText.Size = new Size(29, 24);
            toolStripButtonSetingColorText.Text = "Seting Color Text";
            toolStripButtonSetingColorText.Click += toolStripButtonSetingColorText_Click;
            // 
            // toolStripButtonSetingColorFont
            // 
            toolStripButtonSetingColorFont.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSetingColorFont.Image = (Image)resources.GetObject("toolStripButtonSetingColorFont.Image");
            toolStripButtonSetingColorFont.ImageTransparentColor = Color.Magenta;
            toolStripButtonSetingColorFont.Name = "toolStripButtonSetingColorFont";
            toolStripButtonSetingColorFont.Size = new Size(29, 24);
            toolStripButtonSetingColorFont.Text = "Seting Color  Font";
            toolStripButtonSetingColorFont.Click += toolStripButtonSetingColorFont_Click;
            // 
            // toolStripButtonSetingText
            // 
            toolStripButtonSetingText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSetingText.Image = (Image)resources.GetObject("toolStripButtonSetingText.Image");
            toolStripButtonSetingText.ImageTransparentColor = Color.Magenta;
            toolStripButtonSetingText.Name = "toolStripButtonSetingText";
            toolStripButtonSetingText.Size = new Size(29, 24);
            toolStripButtonSetingText.Text = "Seting Text";
            toolStripButtonSetingText.Click += toolStripButtonSetingText_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(128, 128, 255);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripSymbolsProgressBar, toolStripMaxLenghtLabel, toolStripStatusLabel2, toolStripCountNumbersLabel, toolStripStatusLabel3, toolStripCountSymbolsLabel, toolStripStatusLabel4, toolStripCountWordsLabel });
            statusStrip1.Location = new Point(0, 567);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(838, 33);
            statusStrip1.TabIndex = 22;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.FromArgb(192, 192, 255);
            toolStripStatusLabel1.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(97, 27);
            toolStripStatusLabel1.Text = "Symbols";
            // 
            // toolStripSymbolsProgressBar
            // 
            toolStripSymbolsProgressBar.BackColor = Color.Gray;
            toolStripSymbolsProgressBar.ForeColor = SystemColors.ActiveCaptionText;
            toolStripSymbolsProgressBar.Name = "toolStripSymbolsProgressBar";
            toolStripSymbolsProgressBar.Size = new Size(139, 25);
            // 
            // toolStripMaxLenghtLabel
            // 
            toolStripMaxLenghtLabel.BackColor = Color.LightSkyBlue;
            toolStripMaxLenghtLabel.Name = "toolStripMaxLenghtLabel";
            toolStripMaxLenghtLabel.Size = new Size(47, 27);
            toolStripMaxLenghtLabel.Text = "0/100";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BackColor = Color.FromArgb(192, 192, 255);
            toolStripStatusLabel2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel2.ForeColor = SystemColors.ControlText;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(68, 27);
            toolStripStatusLabel2.Text = "Number";
            // 
            // toolStripCountNumbersLabel
            // 
            toolStripCountNumbersLabel.BackColor = Color.LightSkyBlue;
            toolStripCountNumbersLabel.Name = "toolStripCountNumbersLabel";
            toolStripCountNumbersLabel.Size = new Size(17, 27);
            toolStripCountNumbersLabel.Text = "0";
            toolStripCountNumbersLabel.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.BackColor = Color.FromArgb(192, 192, 255);
            toolStripStatusLabel3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(64, 27);
            toolStripStatusLabel3.Text = "Symbol";
            // 
            // toolStripCountSymbolsLabel
            // 
            toolStripCountSymbolsLabel.BackColor = Color.LightSkyBlue;
            toolStripCountSymbolsLabel.Name = "toolStripCountSymbolsLabel";
            toolStripCountSymbolsLabel.Size = new Size(17, 27);
            toolStripCountSymbolsLabel.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.BackColor = Color.FromArgb(192, 192, 255);
            toolStripStatusLabel4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(49, 27);
            toolStripStatusLabel4.Text = "Word";
            // 
            // toolStripCountWordsLabel
            // 
            toolStripCountWordsLabel.BackColor = Color.LightSkyBlue;
            toolStripCountWordsLabel.Name = "toolStripCountWordsLabel";
            toolStripCountWordsLabel.Size = new Size(17, 27);
            toolStripCountWordsLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formaterToolStripMenuItem, setingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(838, 30);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, newDocumentToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItemExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(246, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += toolStripButtonLoadFile_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(246, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += toolStripButtonSave_Click;
            // 
            // newDocumentToolStripMenuItem
            // 
            newDocumentToolStripMenuItem.Image = (Image)resources.GetObject("newDocumentToolStripMenuItem.Image");
            newDocumentToolStripMenuItem.Name = "newDocumentToolStripMenuItem";
            newDocumentToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newDocumentToolStripMenuItem.Size = new Size(246, 26);
            newDocumentToolStripMenuItem.Text = "New document";
            newDocumentToolStripMenuItem.Click += toolStripButtonNewDocument_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(243, 6);
            // 
            // exitToolStripMenuItemExit
            // 
            exitToolStripMenuItemExit.Image = (Image)resources.GetObject("exitToolStripMenuItemExit.Image");
            exitToolStripMenuItemExit.Name = "exitToolStripMenuItemExit";
            exitToolStripMenuItemExit.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItemExit.Size = new Size(246, 26);
            exitToolStripMenuItemExit.Text = "Exit";
            exitToolStripMenuItemExit.Click += exitToolStripMenuItemExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyPasteToolStripMenuItem, pasteToolStripMenuItem, catToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyPasteToolStripMenuItem
            // 
            copyPasteToolStripMenuItem.Image = (Image)resources.GetObject("copyPasteToolStripMenuItem.Image");
            copyPasteToolStripMenuItem.Name = "copyPasteToolStripMenuItem";
            copyPasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyPasteToolStripMenuItem.Size = new Size(177, 26);
            copyPasteToolStripMenuItem.Text = "Copy";
            copyPasteToolStripMenuItem.Click += toolStripButtonCopy_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(177, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += toolStripButtonPaste_Click;
            // 
            // catToolStripMenuItem
            // 
            catToolStripMenuItem.Image = (Image)resources.GetObject("catToolStripMenuItem.Image");
            catToolStripMenuItem.Name = "catToolStripMenuItem";
            catToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            catToolStripMenuItem.Size = new Size(177, 26);
            catToolStripMenuItem.Text = "Cut";
            catToolStripMenuItem.Click += toolStripButtonCut_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Image = (Image)resources.GetObject("clearToolStripMenuItem.Image");
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Delete;
            clearToolStripMenuItem.Size = new Size(177, 26);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += toolStripButtonClear_Click;
            // 
            // formaterToolStripMenuItem
            // 
            formaterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, foreColorToolStripMenuItem, bacColorToolStripMenuItem });
            formaterToolStripMenuItem.Name = "formaterToolStripMenuItem";
            formaterToolStripMenuItem.Size = new Size(83, 24);
            formaterToolStripMenuItem.Text = "Formater";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Image = (Image)resources.GetObject("fontToolStripMenuItem.Image");
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(161, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += toolStripButtonSetingText_Click;
            // 
            // foreColorToolStripMenuItem
            // 
            foreColorToolStripMenuItem.Image = (Image)resources.GetObject("foreColorToolStripMenuItem.Image");
            foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            foreColorToolStripMenuItem.Size = new Size(161, 26);
            foreColorToolStripMenuItem.Text = "Fore color";
            foreColorToolStripMenuItem.Click += toolStripButtonSetingColorText_Click;
            // 
            // bacColorToolStripMenuItem
            // 
            bacColorToolStripMenuItem.Image = (Image)resources.GetObject("bacColorToolStripMenuItem.Image");
            bacColorToolStripMenuItem.Name = "bacColorToolStripMenuItem";
            bacColorToolStripMenuItem.Size = new Size(161, 26);
            bacColorToolStripMenuItem.Text = "Back color";
            bacColorToolStripMenuItem.Click += toolStripButtonSetingColorFont_Click;
            // 
            // setingToolStripMenuItem
            // 
            setingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontAllTextToolStripMenuItem, bacColorAllTexlToolStripMenuItem, foreColorAllTextToolStripMenuItem });
            setingToolStripMenuItem.Name = "setingToolStripMenuItem";
            setingToolStripMenuItem.Size = new Size(70, 24);
            setingToolStripMenuItem.Text = "Setting";
            // 
            // fontAllTextToolStripMenuItem
            // 
            fontAllTextToolStripMenuItem.Image = (Image)resources.GetObject("fontAllTextToolStripMenuItem.Image");
            fontAllTextToolStripMenuItem.Name = "fontAllTextToolStripMenuItem";
            fontAllTextToolStripMenuItem.Size = new Size(208, 26);
            fontAllTextToolStripMenuItem.Tag = "";
            fontAllTextToolStripMenuItem.Text = "Font all text";
            fontAllTextToolStripMenuItem.Click += fontAllTextToolStripMenuItem_Click;
            // 
            // bacColorAllTexlToolStripMenuItem
            // 
            bacColorAllTexlToolStripMenuItem.Image = (Image)resources.GetObject("bacColorAllTexlToolStripMenuItem.Image");
            bacColorAllTexlToolStripMenuItem.Name = "bacColorAllTexlToolStripMenuItem";
            bacColorAllTexlToolStripMenuItem.Size = new Size(208, 26);
            bacColorAllTexlToolStripMenuItem.Tag = "";
            bacColorAllTexlToolStripMenuItem.Text = "Bac color all texl";
            bacColorAllTexlToolStripMenuItem.Click += bacColorAllTexlToolStripMenuItem_Click;
            // 
            // foreColorAllTextToolStripMenuItem
            // 
            foreColorAllTextToolStripMenuItem.Image = (Image)resources.GetObject("foreColorAllTextToolStripMenuItem.Image");
            foreColorAllTextToolStripMenuItem.Name = "foreColorAllTextToolStripMenuItem";
            foreColorAllTextToolStripMenuItem.Size = new Size(208, 26);
            foreColorAllTextToolStripMenuItem.Tag = "";
            foreColorAllTextToolStripMenuItem.Text = "Fore color all text";
            foreColorAllTextToolStripMenuItem.Click += foreColorAllTextToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(838, 600);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonLoadFile;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonNewDocument;
        private ToolStripButton toolStripButtonCopy;
        private ToolStripButton toolStripButtonCut;
        private ToolStripButton toolStripButtonPaste;
        private ToolStripButton toolStripButtonClear;
        private ToolStripButton toolStripButtonSetingColorText;
        private ToolStripButton toolStripButtonSetingColorFont;
        private ToolStripButton toolStripButtonSetingText;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripSymbolsProgressBar;
        private ToolStripStatusLabel toolStripMaxLenghtLabel;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripCountNumbersLabel;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripCountSymbolsLabel;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripCountWordsLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newDocumentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItemExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyPasteToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem catToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem formaterToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem foreColorToolStripMenuItem;
        private ToolStripMenuItem bacColorToolStripMenuItem;
        private ToolStripMenuItem setingToolStripMenuItem;
        private ToolStripMenuItem fontAllTextToolStripMenuItem;
        private ToolStripMenuItem bacColorAllTexlToolStripMenuItem;
        private ToolStripMenuItem foreColorAllTextToolStripMenuItem;
    }
}