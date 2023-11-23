using System.Text.RegularExpressions;
namespace Dz_na_27._11
{
    public partial class Form1 : Form
    {
        private string desctopRuty = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
            toolStripSymbolsProgressBar.Maximum = richTextBox1.MaxLength;
            richTextBox1.LoadFile(desctopRuty + @"\Text.rtf", RichTextBoxStreamType.RichText);
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripMaxLenghtLabel.Text = $"{richTextBox1.Text.Length}/{richTextBox1.MaxLength}";
            toolStripSymbolsProgressBar.Value = richTextBox1.Text.Length;
            string[] words = richTextBox1.Text.Split(new char[] { ' ', ',', '.', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            string pattern = @"\d+";
            MatchCollection res = Regex.Matches(richTextBox1.Text, pattern);
            toolStripCountNumbersLabel.Text = $"{res.Count}              ";
            int countSymbols = 0;
            foreach (char symbols in richTextBox1.Text)
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
                richTextBox1.LoadFile(openFileDialog.FileName);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(desctopRuty + @"\Text.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("Save good");
        }

        private void toolStripButtonNewDocument_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this file?", "Warnning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Save good");
                richTextBox1.SaveFile(desctopRuty + @"\Text.rtf", RichTextBoxStreamType.RichText);
                richTextBox1.Clear();
            }
            else
            {
                richTextBox1.Clear();
            }
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripButtonSetingColorText_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void toolStripButtonSetingColorFont_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog.Color;
            }
        }

        private void toolStripButtonSetingText_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
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
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void bacColorAllTexlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void foreColorAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(richTextBox1.Text.Length!=0)
            {
                DialogResult result = MessageBox.Show("Save Text?", "Save menu", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Save good");
                    richTextBox1.SaveFile(desctopRuty + @"\Text.rtf", RichTextBoxStreamType.RichText);
                    richTextBox1.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }
    }
}
