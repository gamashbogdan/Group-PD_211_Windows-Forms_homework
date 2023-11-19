using Dz_na_25._11;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Dz_na_25._11
{
    public partial class MainForm : Form
    {
        List<Product> products;
        public MainForm()
        {
            InitializeComponent();
            products = new List<Product>();
        }
        public void Update()
        {
            ListBox.DataSource = null;
            ListBox.DataSource = products;

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product;
            ProductForm productForm = new ProductForm();
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                product = productForm.Product;
                products.Add(new Product(product.Name, product.Price, product.Quantity, product.Countri, product.Discount));
                Update();
            }

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Product product = (ListBox.SelectedItem as Product)!;
            ProductForm productForm = new ProductForm(product);
            productForm.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            products.Remove((ListBox.SelectedItem as Product)!);
            Update();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Product = (ListBox.SelectedItem as Product)!;
            productForm.ShowDialog();
            products.Add(productForm.Product);
            Update();
        }
    }
}