using System.Xml.Serialization;
namespace Dz_na_23._11
{

    public partial class Form1 : Form
    {
        List<Cars> cars;
        public Form1()
        {
            InitializeComponent();
            cars = new List<Cars>();
            listBoxCars.DataSource = cars;
        }
        private void Update()
        {
            listBoxCars.DataSource = null;
            listBoxCars.DataSource = cars;
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
                cars.Add(new Cars(textBoxModel.Text, (int)numericUpDownYear.Value, (string)comboBoxColors.SelectedItem, (int)numericUpDownProbig.Value, (int)numericUpDownValue.Value));
                Update();
                foreach (var item in this.Controls.OfType<TextBox>())
                {
                    item.Text = "";
                }
                foreach (var item in this.Controls.OfType<NumericUpDown>())
                {
                    var type = item.GetType;
                    if (type == numericUpDownYear.GetType)
                    {
                        numericUpDownYear.Value = 1990;
                    }
                    if (type == numericUpDownProbig.GetType)
                    {
                        numericUpDownProbig.Value = 0;
                    }
                    if (type == numericUpDownValue.GetType)
                    {
                        numericUpDownValue.Value = (decimal)1.0;
                    }
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
            cars.Remove((listBoxCars.SelectedItem as Cars)!);
            Update();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(List<Cars>));
            try
            {
                using (Stream fs = File.Create("ListCars.xml"))
                {
                    formatter.Serialize(fs, cars);
                }
                MessageBox.Show("Save Dasus gyd :D");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Cars>));
            using (Stream fs = File.OpenRead("ListCars.xml"))
            {
                if (fs.Length > 0)
                {
                    cars = (List<Cars>)formatter.Deserialize(fs)!;
                }
            }
            listBoxCars.DataSource = cars;
        }
    }
}