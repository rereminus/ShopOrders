using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopOrders.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new ShopOrdersDb())
            {
                context.Database.EnsureCreated();
                var user = context.Users.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);
                if (user != null)
                {
                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.PasswordChar == '*')
            {
                this.textBox2.PasswordChar = '\0';
            }
            else
            {
                this.textBox2.PasswordChar = '*';
            }
        }
    }
}
