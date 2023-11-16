using System.Text.RegularExpressions;
using System.Xml.Serialization;
namespace Dz_na_20._11
{
    public partial class Form1 : Form
    {
        static string saveWords = null;
        public Form1()
        {
            InitializeComponent();
            string loadeWords = LoadFromFile();
            if (loadeWords.Length != 0)
            {
                if (MessageBox.Show("Load from file?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MaxSymbolsNumericUpDown.Value = loadeWords.Length;

                    toolStripSymbolsProgressBar.Maximum = (int)MaxSymbolsNumericUpDown.Value;
                    toolStripMaxLenghtLabel.Text = $"{loadeWords.Length}/{TextBox.MaxLength}";
                    string[] words = TextBox.Text.Split(new char[] { ' ', ',', '.', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    int wordCount = words.Length;
                    string pattern = @"\d+";
                    MatchCollection res = Regex.Matches(TextBox.Text, pattern);
                    toolStripCountNumbersLabel.Text = $"{res.Count}              ";
                    int countSymbols = 0;
                    foreach (char symbols in TextBox.Text)
                    {
                        if (Char.IsLetter(symbols))
                            countSymbols++;
                    }
                    toolStripCountSymbolsLabel.Text = $"{countSymbols}              ";
                    toolStripCountWordsLabel.Text = $"{wordCount}              ";
                    TextBox.Text = loadeWords;
                }

            }
        }
        static void SaveToFile()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(string));
            try
            {
                using (Stream fs = File.Create("Words.xml"))
                {
                    formatter.Serialize(fs, saveWords);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static string LoadFromFile()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(string));
            string loadeWords = null;
            using (Stream fs = File.OpenRead("Words.xml"))
            {
                if (fs.Length > 0)
                {
                    loadeWords = (string)formatter.Deserialize(fs);
                }
            }
            return loadeWords;
        }
        private void MaxSymbolsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TextBox.MaxLength = (int)MaxSymbolsNumericUpDown.Value;
            toolStripMaxLenghtLabel.Text = $"{this.Opacity}/{TextBox.MaxLength}";
            toolStripSymbolsProgressBar.Maximum = (int)MaxSymbolsNumericUpDown.Value;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox.MaxLength = (int)MaxSymbolsNumericUpDown.Value;
            toolStripMaxLenghtLabel.Text = $"{TextBox.Text.Length}/{TextBox.MaxLength}";
            toolStripSymbolsProgressBar.Maximum = (int)MaxSymbolsNumericUpDown.Value;
            toolStripSymbolsProgressBar.Value = TextBox.Text.Length;
            string[] words = TextBox.Text.Split(new char[] { ' ', ',', '.', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            string pattern = @"\d+";
            MatchCollection res = Regex.Matches(TextBox.Text, pattern);
            toolStripCountNumbersLabel.Text = $"{res.Count}              ";
            int countSymbols = 0;
            foreach (char symbols in TextBox.Text)
            {
                if (Char.IsLetter(symbols))
                    countSymbols++;
            }
            toolStripCountSymbolsLabel.Text = $"{countSymbols}              ";
            toolStripCountWordsLabel.Text = $"{wordCount}              ";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveWords = TextBox.Text;
            if (saveWords.Length != 0)
            {
                DialogResult result = MessageBox.Show("Save Text?", "", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveToFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Запобігає закриттю форми
                }
            }
        }
        private void toolStripSetingBatton_ButtonClick(object sender, EventArgs e)
        {
        }
    }
}
