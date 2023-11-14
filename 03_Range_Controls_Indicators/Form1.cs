namespace Dz_na_20._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaxLenghtLabel.Text = $"{this.Opacity}/{TextBox.MaxLength}";
            CountWordLabel.Text = $"0";
        }
        private void MaxSymbolsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TextBox.MaxLength = (int)MaxSymbolsNumericUpDown.Value;
            MaxLenghtLabel.Text = $"{this.Opacity}/{TextBox.MaxLength}";
            SymbolsProgressBar.Maximum = (int)MaxSymbolsNumericUpDown.Value;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox.MaxLength = (int)MaxSymbolsNumericUpDown.Value;
            MaxLenghtLabel.Text = $"{TextBox.Text.Length}/{TextBox.MaxLength}";
            SymbolsProgressBar.Maximum = (int)MaxSymbolsNumericUpDown.Value;
            SymbolsProgressBar.Value = TextBox.Text.Length;
            string[] words = TextBox.Text.Split(new char[] { ' ', ',', '.', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            CountWordLabel.Text = $"{wordCount}";

        }

    }
}
