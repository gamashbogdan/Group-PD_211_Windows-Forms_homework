using System.Reflection;
using System.Xml.Serialization;

namespace _04_Controls_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            int countSymbols = 0;
            foreach (char symbols in textBoxModel.Text)
            {
                if (Char.IsLetterOrDigit(symbols))
                    countSymbols++;
            }
            if (countSymbols != 0)
            {
                listBoxCars.Items.Add(new Cars(textBoxModel.Text, (int)numericUpDownYear.Value, (string)comboBoxColors.SelectedItem, (int)numericUpDownProbig.Value, (int)numericUpDownValue.Value));
                foreach (var item in this.Controls.OfType<TextBox>())
                {
                    item.Text = "";
                }
                foreach (var item in this.Controls.OfType<NumericUpDown>())
                {
                    item.Value = 0;
                }
                foreach (var item in this.Controls.OfType<ComboBox>())
                {
                    item.Text = "";
                }
            }
            else
            {
                MessageBox.Show("You need to enter the car model");
            }

        }
       
        private void buttonShowCar_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars = (Cars)listBoxCars.SelectedItem;
            if (listBoxCars.SelectedIndex == -1)
            {
                MessageBox.Show("Select order in List Cars");
                return;
            }
            textBoxModel.Text = cars.Model;
            numericUpDownYear.Value = cars.Year;
            comboBoxColors.Text = cars.Color;
            numericUpDownProbig.Value = cars.Probig;
            numericUpDownValue.Value = cars.Value;
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            listBoxCars.Items.Remove(listBoxCars.SelectedItem);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Cars));
            try
            {
                using (Stream fs = File.Create("ListCars.xml"))
                {
                    formatter.Serialize(fs,);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(string));
            string loadeWords = null;
            using (Stream fs = File.OpenRead("ListCars.xml"))
            {
                if (fs.Length > 0)
                {
                    loadeWords = (string)formatter.Deserialize(fs);
                }
            }
        }
    }
}