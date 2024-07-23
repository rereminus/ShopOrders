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
    public partial class OrderForm : Form
    {
        //public Order Order = new Order();
        public Product Tovar = new Product();
        public List<Order> Orders = new List<Order>();
        public String Client;
        List<Product> _tovars = new List<Product>();

        List<String> _statuses = new List<string>()
        {
            "Собирается","Отправлен","Ожидает получения", "Получен"
        };


        public OrderForm(List<Product> tovars)
        {
            InitializeComponent();

            foreach (var status in _statuses)
            {
                comboBox2.Items.Add(status);
            }

            _tovars = tovars;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            foreach (var tovar in tovars)
            {
                comboBox1.Items.Add(tovar.Title);
            }

            comboBox2.SelectedIndex = 0;
        }

        public OrderForm(List<Product> tovars, List<Order> orders)
        {
            InitializeComponent();

            foreach (var status in _statuses)
            {
                comboBox2.Items.Add(status);
            }

            _tovars = tovars;
            

            foreach (var tovar in tovars)
            {
                comboBox1.Items.Add(tovar.Title);
            }

            foreach (var order in orders)
            {
                var tovar = _tovars.First(x => x.ID == order.TovarIds);
                dateTimePicker1.Value = DateTime.Parse(order.Date);
                listBox1.Items.Add(tovar.Title);
            }

            textBox2.Text = orders.First().Client;
            comboBox2.SelectedItem = orders.First().Status;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            var code = Guid.NewGuid().ToString().Split('-')[0];
            Client = textBox2.Text;
            foreach (var item in listBox1.Items)
            {
                Order order = new Order();
                order.Date = dateTimePicker1.Text;
                order.Code = code;
                order.Status = comboBox2.Text;
                order.Client = textBox2.Text;
                order.TovarIds = _tovars.First(x => x.Title == item.ToString()).ID;
                order.Price = _tovars.First(x => x.Title == item.ToString()).Price;
                Orders.Add(order);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.Items.Add(comboBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
