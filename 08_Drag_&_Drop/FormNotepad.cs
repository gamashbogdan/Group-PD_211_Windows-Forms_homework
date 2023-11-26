using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dz_na_04._12
{
    public partial class FormNotepad : Form
    {
        private string desctopRuty = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public FormNotepad()
        {
            InitializeComponent();
            toolStripSymbolsProgressBar.Maximum = richTextBox.MaxLength;
            toolStripMaxLenghtLabel.Text = $"{richTextBox.Text.Length}/{richTextBox.MaxLength}";
            richTextBox.AllowDrop = true;

        }
        public RichTextBox SelectedNameTb
        {
            get
            {
                foreach (var item in tabControl.SelectedTab.Controls.OfType<RichTextBox>())
                {
                    if (item.Name == "richTextBox")
                    {
                        return item;
                    }
                }
                return null;
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripMaxLenghtLabel.Text = $"{richTextBox.Text.Length}/{richTextBox.MaxLength}";
            toolStripSymbolsProgressBar.Value = richTextBox.Text.Length;
            string[] words = richTextBox.Text.Split(new char[] { ' ', ',', '.', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            string pattern = @"\d+";
            MatchCollection res = Regex.Matches(richTextBox.Text, pattern);
            toolStripCountNumbersLabel.Text = $"{res.Count}              ";
            int countSymbols = 0;
            foreach (char symbols in richTextBox.Text)
            {
                if (Char.IsLetter(symbols))
                    countSymbols++;
            }
            toolStripCountSymbolsLabel.Text = $"{countSymbols}              ";
            toolStripCountWordsLabel.Text = $"{wordCount}              ";
        }
        private void toolStripButtonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedNameTb.LoadFile(openFileDialog.FileName);
            }
        }
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            SelectedNameTb.SaveFile(desctopRuty + @$"\{openFileDialog.FileName}.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("Save good");
        }
        private void toolStripButtonNewDocument_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this file?", "Warnning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Save good");
                SelectedNameTb.SaveFile(desctopRuty + @"\Text.rtf", RichTextBoxStreamType.RichText);
                SelectedNameTb.Clear();
            }
            else
            {
                SelectedNameTb.Clear();
            }
        }
        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            SelectedNameTb.Copy();
        }
        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            SelectedNameTb.Cut();
        }
        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            SelectedNameTb.Paste();
        }
        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            SelectedNameTb.Clear();
        }
        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            SelectedNameTb.Undo();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            SelectedNameTb.Redo();
        }
        private void toolStripButtonSetingColorText_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedNameTb.SelectionColor = colorDialog.Color;
            }
        }
        private void toolStripButtonSetingColorFont_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedNameTb.SelectionBackColor = colorDialog.Color;
            }
        }
        private void toolStripButtonSetingText_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedNameTb.SelectionFont = fontDialog.Font;
            }
        }
        private void exitToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fontAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedNameTb.Font = fontDialog.Font;
            }
        }
        private void bacColorAllTexlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedNameTb.BackColor = colorDialog.Color;
            }
        }
        private void foreColorAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedNameTb.ForeColor = colorDialog.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (SelectedNameTb.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Save Text?", "Save menu", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Save good");
                    SelectedNameTb.SaveFile(desctopRuty + @"\Text.rtf", RichTextBoxStreamType.RichText);
                    SelectedNameTb.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void toolStripButtonAddTab_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage($"New Page {tabControl.TabPages.Count + 1}");
            RichTextBox mainrichTextBox = new RichTextBox();
            page.UseVisualStyleBackColor = true;
            mainrichTextBox.AllowDrop = true;
            mainrichTextBox.Location = new Point(-4, 0);
            mainrichTextBox.Margin = new Padding(3, 4, 3, 4);
            mainrichTextBox.MaxLength = 10000;
            mainrichTextBox.Name = "richTextBox";
            mainrichTextBox.Size = new Size(richTextBox.Width, richTextBox.Height);
            mainrichTextBox.TabIndex = 29;
            mainrichTextBox.Text = "";
            mainrichTextBox.Click += (sender, e) =>
            {
                toolStripMaxLenghtLabel.Text = $"{mainrichTextBox.Text.Length}/{mainrichTextBox.MaxLength}";
                toolStripSymbolsProgressBar.Value = mainrichTextBox.Text.Length;
                string[] words = mainrichTextBox.Text.Split(new char[] { ' ', ',', '.', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                string pattern = @"\d+";
                MatchCollection res = Regex.Matches(mainrichTextBox.Text, pattern);
                toolStripCountNumbersLabel.Text = $"{res.Count}              ";
                int countSymbols = 0;
                foreach (char symbols in mainrichTextBox.Text)
                {
                    if (Char.IsLetter(symbols))
                        countSymbols++;
                }
                toolStripCountSymbolsLabel.Text = $"{countSymbols}              ";
                toolStripCountWordsLabel.Text = $"{wordCount}              ";
            };

            toolStripMaxLenghtLabel.Text = $"{0}/{mainrichTextBox.MaxLength}";
            toolStripSymbolsProgressBar.Value = 0;
            toolStripCountNumbersLabel.Text = $"{0}";
            toolStripCountSymbolsLabel.Text = $"{0}";
            toolStripCountWordsLabel.Text = $"{0}";
            mainrichTextBox.TextChanged += (sender, e) =>
            {
                toolStripMaxLenghtLabel.Text = $"{mainrichTextBox.Text.Length}/{mainrichTextBox.MaxLength}";
                toolStripSymbolsProgressBar.Value = mainrichTextBox.Text.Length;
                string[] words = mainrichTextBox.Text.Split(new char[] { ' ', ',', '.', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                string pattern = @"\d+";
                MatchCollection res = Regex.Matches(mainrichTextBox.Text, pattern);
                toolStripCountNumbersLabel.Text = $"{res.Count}              ";
                int countSymbols = 0;
                foreach (char symbols in mainrichTextBox.Text)
                {
                    if (Char.IsLetter(symbols))
                        countSymbols++;
                }
                toolStripCountSymbolsLabel.Text = $"{countSymbols}              ";
                toolStripCountWordsLabel.Text = $"{wordCount}              ";
            };
            page.Controls.Add(mainrichTextBox);

            tabControl.TabPages.Add(page);
        }
        private void toolStripButtonRemoveTab_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }
    }
}
