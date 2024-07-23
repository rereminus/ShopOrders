using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopOrders.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopOrders.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product tovar)
        {
            InitializeComponent();
            textBox1.Text = tovar.Title;
            textBox2.Text = tovar.Price.ToString();
        }

        public Product Tovar = new Product();

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double price))
            {
                Tovar.Title = textBox1.Text;
                Tovar.Price = price;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Цена указана неверно");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

