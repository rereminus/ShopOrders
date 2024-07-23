using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

//using Microsoft.VisualBasic.ApplicationServices;
using OfficeOpenXml;
using ShopOrders.Models;

namespace ShopOrders.Forms
{
    public partial class MainForm : Form
    {
        public ShopOrdersDb ShopOrdersDb;

        User _user = new User();

        //Разделение ролей
        public MainForm(User user)
        {
            InitializeComponent();
            ShopOrdersDb = new ShopOrdersDb();
            //ShopOrdersDb.Database.EnsureCreated();
            _user = user;

            foreach (var tovar in ShopOrdersDb.Tovars)
            {
                dataGridView1.Rows.Add(tovar.ID, tovar.Title, tovar.Price);
            }
            foreach (var order in ShopOrdersDb.Orders.ToList().GroupBy(x => x.RecordID).ToList())
            {
                dataGridView2.Rows.Add(order.First().RecordID, order.First().Code, order.First().Status, order.First().Date, order.Sum(x => x.Price), order.First().Client);
            }

            if (!user.IsAdmin)
            {
                tabControl1.TabPages.Remove(tabPage3);

                foreach (Button btn in tabPage1.Controls.OfType<Button>().ToList())
                {
                    if (btn.Text != "Выход из аккаунта")
                    {
                        Controls.Remove(btn);
                        btn.Dispose();
                    }
                }

                foreach (Button btn in tabPage2.Controls.OfType<Button>().ToList())
                {
                    if (btn.Text == "Добавить заказ" || btn.Text == "Удалить заказ" || btn.Text == "Редактировать заказ" || btn.Text == "Сформировать чек")
                    {
                        Controls.Remove(btn);
                        btn.Dispose();
                    }
                }
            }
            foreach (var usr in ShopOrdersDb.Users)
            {
                comboBox1.Items.Add(usr.Login);
            }
            comboBox2.Items.AddRange(new String[] { "Собирается", "Отправлен", "Ожидает получения", "Получен" });
        }

        //Добавление товара
        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm ProductForm = new ProductForm();
            if (ProductForm.ShowDialog() == DialogResult.OK)
            {
                var tovar = ProductForm.Tovar;
                ShopOrdersDb.Tovars.Add(tovar);
                ShopOrdersDb.SaveChanges();
                dataGridView1.Rows.Add(tovar.ID, tovar.Title, tovar.Price);
            }
        }
        //Редактирование товара
        private void button2_Click(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value);
            var tovar = ShopOrdersDb.Tovars.First(x => x.ID == index);
            ProductForm ProductForm = new ProductForm(tovar);
            if (ProductForm.ShowDialog() == DialogResult.OK)
            {
                tovar.Title = ProductForm.Tovar.Title;
                tovar.Price = ProductForm.Tovar.Price;

                dataGridView1.CurrentRow.Cells["Column2"].Value = tovar.Title;
                dataGridView1.CurrentRow.Cells["Column3"].Value = tovar.Price;

                ShopOrdersDb.Entry(tovar).State = EntityState.Modified;
                ShopOrdersDb.SaveChanges();
            }

        }
        //Удаление товара
        private void button3_Click(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value);
            var tovar = ShopOrdersDb.Tovars.First(x => x.ID == index);
            if (ShopOrdersDb.Orders.Select(t => t.TovarIds).ToList().Contains(tovar.ID))
            {
                MessageBox.Show("Ошибка\nТовар содержится в заказе");
            }
            else
            {
                var messagebox = MessageBox.Show("Вы действительно хотите удалить товар?",
                "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messagebox == DialogResult.Yes)
                {
                    ShopOrdersDb.Entry(tovar).State = EntityState.Deleted;
                    ShopOrdersDb.Tovars.Remove(tovar);
                    ShopOrdersDb.SaveChanges();
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var messagebox = MessageBox.Show("Вы действительно хотите закрыть приложение?",
           "Закрытие приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messagebox == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(Environment.ExitCode);
            }
            else
            {
                e.Cancel = true;
            }
        }
        //Добавление заказа
        private void button4_Click(object sender, EventArgs e)
        {
            OrderForm OrderForm = new OrderForm(ShopOrdersDb.Tovars.ToList());
            if (OrderForm.ShowDialog() == DialogResult.OK)
            {
                var orders = OrderForm.Orders;
                var recordid = 1;
                double price = 0;
                if (ShopOrdersDb.Orders.Count() > 0)
                {
                    var last = ShopOrdersDb.Orders.ToList().Max(x => x.RecordID);
                    recordid = recordid + (last++);
                }


                foreach (var order in orders)
                {
                    order.Client = OrderForm.Client;
                    order.RecordID = recordid;
                    ShopOrdersDb.Orders.Add(order);
                    ShopOrdersDb.SaveChanges();
                    price += order.Price;
                }
                var recordToDG = ShopOrdersDb.Orders.Where(x => x.RecordID == recordid).GroupBy(x => x.RecordID).ToList();
                dataGridView2.Rows.Add(recordid, recordToDG[0].First().Code, recordToDG[0].First().Status, recordToDG[0].First().Date, price, recordToDG[0].First().Client);

                MessageBox.Show("Заказ добавлен. Код заказа - " + recordToDG[0].First().Code, "Добавлено");
            }
        }
        //Удаление заказа
        private void button6_Click(object sender, EventArgs e)
        {
            var messagebox = MessageBox.Show("Вы действительно хотите удалить заказ?",
                "Удаление заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messagebox == DialogResult.Yes) 
            {
                var index = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Column4"].Value);
                var orders = ShopOrdersDb.Orders.Where(x => x.RecordID == index).ToList();

                foreach (var order in orders)
                {
                    ShopOrdersDb.Entry(order).State = EntityState.Deleted;
                    ShopOrdersDb.Orders.Remove(order);
                    ShopOrdersDb.SaveChanges();
                }
                dataGridView3.Visible = false;
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var index = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                if (index == 0) return;
                dataGridView3.Visible = true;
                dataGridView3.Rows.Clear();
                var orders = ShopOrdersDb.Orders.Where(x => x.RecordID == index).ToList();

                var groups = orders.GroupBy(x => x.TovarIds).ToList();

                double sumGroup = 0;
                foreach (var group in groups)
                {
                    var tovar = ShopOrdersDb.Tovars.First(x => x.ID == group.Key);
                    sumGroup = tovar.Price * group.Count();
                    dataGridView3.Rows.Add(group.First().ID,
                                            tovar.Title,
                                            group.Count(),
                                            sumGroup);
                }
            }
        }
        //Редактирование заказа
        private void button5_Click(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Column4"].Value);
            var orders = ShopOrdersDb.Orders.Where(x => x.RecordID == index).ToList();
            OrderForm OrderForm = new OrderForm(ShopOrdersDb.Tovars.ToList(), orders);
            if (OrderForm.ShowDialog() == DialogResult.OK)
            {
                var ordersEdit = OrderForm.Orders;
                int recordid = orders.First().RecordID;

                foreach (var order in orders)
                {
                    ShopOrdersDb.Entry(order).State = EntityState.Deleted;
                    ShopOrdersDb.Orders.Remove(order);
                }

                double price = 0;
                foreach (var order in ordersEdit)
                {
                    order.RecordID = recordid;
                    order.Client = OrderForm.Client;
                    price += order.Price;
                    ShopOrdersDb.Orders.Add(order);
                }

                ShopOrdersDb.SaveChanges();

                var recordToDG = ShopOrdersDb.Orders.Where(x => x.RecordID == recordid).GroupBy(x => x.RecordID).ToList();
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                dataGridView2.Rows.Add(recordid, recordToDG[0].First().Code, recordToDG[0].First().Status, recordToDG[0].First().Date, price, recordToDG[0].First().Client);
                dataGridView3.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    User user = new User();
                    user.Login = textBox1.Text;
                    user.Password = textBox2.Text;
                    user.IsAdmin = radioButton1.Checked ? true : false;

                    ShopOrdersDb.Users.Add(user);
                    ShopOrdersDb.SaveChanges();
                    comboBox1.Items.Add(user.Login);
                    success = true;
                }
            }
            if (!success)
            {
                MessageBox.Show("Проверьте данные", "Ошибка");
            }
            else
            {
                MessageBox.Show("Пользователь добавлен", "Успешно");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }
        //Применение фильтра
        private void button8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                dataGridView2.Rows.Clear();
                var ordersFilter = ShopOrdersDb.Orders.Where(x => x.Code == textBox3.Text || x.Client == textBox3.Text).ToList().GroupBy(x => x.RecordID).ToList();
                foreach (var order in ordersFilter)
                {
                    dataGridView2.Rows.Add(order.First().RecordID, order.First().Code, order.First().Status, order.First().Date, order.Sum(x => x.Price), order.First().Client);
                }
            }
            else
            {
                MessageBox.Show("Фильтр пуст");
            }
        }
        //Сброс фильтра
        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (var order in ShopOrdersDb.Orders.ToList().GroupBy(x => x.RecordID).ToList())
            {
                dataGridView2.Rows.Add(order.First().RecordID, order.First().Code, order.First().Status, order.First().Date, order.Sum(x => x.Price), order.First().Client);
            }
            textBox3.Text = "";
        }
        //Формирование чека
        private void button10_Click(object sender, EventArgs e)
        {

            var index = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Column4"].Value);
            var orders = ShopOrdersDb.Orders.Where(x => x.RecordID == index).ToList();

            var path = Path.GetFullPath($"Чек_{orders.First().Client}.xlsx");
            var tempfile = new FileInfo(path);
            if (tempfile.Exists)
            {
                tempfile.Delete();
            }

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage($"Чек_{orders.First().Client}.xlsx"))
            {
                var sheet = excel.Workbook.Worksheets.Add("Лист1");
                sheet.Cells[1, 1].Value = "ФИО клиента";
                sheet.Cells[1, 2].Value = orders.First().Client;

                sheet.Cells[2, 1].Value = "Дата заказа";
                sheet.Cells[2, 2].Value = orders.First().Date;

                sheet.Cells[3, 1].Value = "Товары";
                int row = 3;
                double sum = 0;
                foreach (var order in orders)
                {
                    var tovar = ShopOrdersDb.Tovars.First(x => x.ID == order.TovarIds);
                    sheet.Cells[row, 2].Value = tovar.Title;
                    sheet.Cells[row, 3].Value = $"{tovar.Price} руб.";
                    sum += tovar.Price;
                    row++;
                }
                sheet.Cells[row, 1].Value = "Общая сумма";
                sheet.Cells[row, 3].Value = $"{sum} руб.";


                sheet.Cells[1, 1, row, 3].AutoFitColumns();
                sheet.Cells[1, 1, row, 1].Style.Font.Bold = true;
                excel.Save();

                MessageBox.Show("Чек сформирован", "Успешно");

                var p = new Process();
                p.StartInfo = new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var messagebox = MessageBox.Show("Вы действительно хотите удалить пользователя?",
           "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messagebox == DialogResult.Yes)
            {
                var usr = ShopOrdersDb.Users.FirstOrDefault(x => x.Login == comboBox1.Text);

                comboBox1.Items.Remove(usr.Login);
                ShopOrdersDb.Users.Remove(usr);
                ShopOrdersDb.SaveChanges();
                MessageBox.Show($"Пользователь {usr.Login} был успешно удален!");


            }

        }
        //Экспорт заказов
        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                var tovarFilter = ShopOrdersDb.Orders.Where(x => x.Status == comboBox2.Text).GroupBy(x => x.RecordID).ToList();
                if (tovarFilter != null)
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (var excel = new ExcelPackage($"ExportByStatus_{comboBox2.Text}.xlsx"))
                    {
                        var sheet = excel.Workbook.Worksheets.Add("Лист1");
                        sheet.Cells[1, 1].Value = "Код заказа";
                        sheet.Cells[1, 2].Value = "Статус";
                        sheet.Cells[1, 3].Value = "Дата";
                        sheet.Cells[1, 4].Value = "Стоимость";
                        sheet.Cells[1, 5].Value = "ФИО клиента";

                        int row = 2;
                        foreach (var order in tovarFilter)
                        {
                            sheet.Cells[row, 1].Value = order.First().Code;
                            sheet.Cells[row, 2].Value = order.First().Status;
                            sheet.Cells[row, 3].Value = order.First().Date;
                            sheet.Cells[row, 4].Value = order.Sum(x => x.Price);
                            sheet.Cells[row, 5].Value = order.First().Client;
                            row++;
                        }
                        sheet.Cells[1, 1, row, 5].AutoFitColumns();
                        sheet.Cells[1, 1, 1, 5].Style.Font.Bold = true;

                        excel.Save();
                        MessageBox.Show("Экспорт выполнен", "Успешно");
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var messagebox = MessageBox.Show("Вы действительно хотите выйти из аккаунта?",
           "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messagebox == DialogResult.Yes)
            {
                AuthForm authF = new AuthForm();
                authF.Show();
                this.Hide();
            }
        }
    }
}
