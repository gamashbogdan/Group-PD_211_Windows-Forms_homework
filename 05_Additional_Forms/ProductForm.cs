
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace Dz_na_25._11
{
    public partial class ProductForm : Form
    {
        private Product product;

        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                textBoxName.Text = product.Name;
                numericUpDownPrice.Value = (decimal)product.Price;
                numericUpDownQuantity.Value = product.Quantity;
                comboBoxCountri.Text = product.Countri;
                numericUpDownDiscount.Value = product.Discount;
            }
        }

        public ProductForm()
        {
            InitializeComponent();

        }
        public ProductForm(Product product)
        {
            InitializeComponent();
            if (product == null)
            {
                return;
            }
            else
            {
                this.Product = product;
                textBoxName.Enabled = false;
                numericUpDownPrice.Enabled = false;
                numericUpDownQuantity.Enabled = false;
                comboBoxCountri.Enabled = false;
                numericUpDownDiscount.Enabled = false;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Enter Name Product");
                return;
            }
            if (product == null) 
            {
                product = new Product
                {
                    Name = textBoxName.Text,
                    Price = (double)numericUpDownPrice.Value,
                    Quantity = (int)numericUpDownQuantity.Value,
                    Countri = (string)comboBoxCountri.SelectedItem,
                    Discount = (int)numericUpDownDiscount.Value
                };
            }
            else
            {
                Product.Name = textBoxName.Text;
                Product.Price = (double)numericUpDownPrice.Value;
                Product.Quantity = (int)numericUpDownQuantity.Value;
                Product.Countri = (string)comboBoxCountri.SelectedItem;
                Product.Discount = (int)numericUpDownDiscount.Value;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
