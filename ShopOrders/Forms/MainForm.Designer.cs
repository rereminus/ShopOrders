namespace ShopOrders.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button13 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            comboBox2 = new ComboBox();
            button12 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            dataGridView3 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            button11 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            button7 = new Button();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(14, 14);
            tabControl1.Margin = new Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1267, 763);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(235, 225, 222);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 36);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(1259, 723);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Товары";
            tabPage1.Controls.Add(button13);
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button13.BackColor = Color.White;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button13.Location = new Point(1064, 371);
            button13.Name = "button13";
            button13.Size = new Size(187, 40);
            button13.TabIndex = 14;
            button13.Text = "Выход из аккаунта";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.owlnew;
            pictureBox2.Location = new Point(1064, 419);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 291);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(248, 241, 239);
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(505, 100);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(227, 35);
            button3.TabIndex = 3;
            button3.Text = "Удалить товар";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(248, 241, 239);
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(505, 54);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(227, 35);
            button2.TabIndex = 2;
            button2.Text = "Редактировать товар";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(248, 241, 239);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(505, 10);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(227, 35);
            button1.TabIndex = 1;
            button1.Text = "Добавить товар";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 241, 239);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(8, 9);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(487, 704);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Название";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Цена (руб.)";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(235, 225, 222);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(button12);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 36);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(1259, 723);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказы";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.owlnew;
            pictureBox1.Location = new Point(1062, 423);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(779, 543);
            comboBox2.Margin = new Padding(5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(275, 35);
            comboBox2.TabIndex = 11;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button12.BackColor = Color.FromArgb(248, 241, 239);
            button12.Cursor = Cursors.Hand;
            button12.Location = new Point(593, 497);
            button12.Margin = new Padding(5);
            button12.Name = "button12";
            button12.Size = new Size(176, 125);
            button12.TabIndex = 10;
            button12.Text = "Экспорт заказов по статусу";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.BackColor = Color.FromArgb(248, 241, 239);
            button10.Cursor = Cursors.Hand;
            button10.Location = new Point(593, 392);
            button10.Margin = new Padding(5);
            button10.Name = "button10";
            button10.Size = new Size(292, 35);
            button10.TabIndex = 9;
            button10.Text = "Сформировать чек";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button9.BackColor = Color.FromArgb(248, 241, 239);
            button9.Cursor = Cursors.Hand;
            button9.Location = new Point(895, 135);
            button9.Margin = new Padding(5);
            button9.Name = "button9";
            button9.Size = new Size(352, 35);
            button9.TabIndex = 8;
            button9.Text = "Сбросить";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(248, 241, 239);
            button8.Cursor = Cursors.Hand;
            button8.Location = new Point(895, 90);
            button8.Margin = new Padding(5);
            button8.Name = "button8";
            button8.Size = new Size(352, 35);
            button8.TabIndex = 7;
            button8.Text = "Применить";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Location = new Point(895, 44);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ф.И.О. или код заказа";
            textBox3.Size = new Size(352, 36);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1024, 12);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 27);
            label3.TabIndex = 5;
            label3.Text = "Фильтр";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(248, 241, 239);
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(895, 311);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(352, 35);
            button6.TabIndex = 4;
            button6.Text = "Удалить заказ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(248, 241, 239);
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(895, 267);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(352, 35);
            button5.TabIndex = 3;
            button5.Text = "Редактировать заказ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(248, 241, 239);
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(895, 221);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(352, 35);
            button4.TabIndex = 2;
            button4.Text = "Добавить заказ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.FromArgb(248, 241, 239);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            dataGridView3.Location = new Point(8, 392);
            dataGridView3.Margin = new Padding(5);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(575, 308);
            dataGridView3.TabIndex = 1;
            dataGridView3.Visible = false;
            // 
            // Column7
            // 
            Column7.HeaderText = "ID";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // Column8
            // 
            Column8.FillWeight = 59.3582878F;
            Column8.HeaderText = "Товар";
            Column8.MinimumWidth = 90;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 209.380081F;
            Column9.HeaderText = "Количество";
            Column9.MinimumWidth = 144;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 31.2616119F;
            Column10.HeaderText = "Сумма (руб.)";
            Column10.MinimumWidth = 100;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(248, 241, 239);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column12, Column13, Column5, Column6, Column11 });
            dataGridView2.Location = new Point(8, 9);
            dataGridView2.Margin = new Padding(5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(877, 369);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellMouseClick += dataGridView2_CellMouseClick;
            // 
            // Column4
            // 
            Column4.HeaderText = "ID";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column12
            // 
            Column12.HeaderText = "Код заказа";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Статус";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Дата";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Общая стоимость (руб.)";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "ФИО клиента";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(248, 241, 239);
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 36);
            tabPage3.Margin = new Padding(5);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1259, 723);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Админ панель";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.owlnew;
            pictureBox3.Location = new Point(1069, 428);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(187, 291);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(464, 5);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(416, 183);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Удаление пользователя";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 58);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 35);
            comboBox1.TabIndex = 4;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(248, 241, 239);
            button11.Cursor = Cursors.Hand;
            button11.Location = new Point(23, 128);
            button11.Margin = new Padding(5);
            button11.Name = "button11";
            button11.Size = new Size(241, 35);
            button11.TabIndex = 3;
            button11.Text = "Удалить пользователя";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 58);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 27);
            label5.TabIndex = 0;
            label5.Text = "Логин";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(449, 290);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление пользователя";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(24, 193);
            radioButton2.Margin = new Padding(5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(188, 31);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Пользователь";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(248, 241, 239);
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(21, 245);
            button7.Margin = new Padding(5);
            button7.Name = "button7";
            button7.Size = new Size(241, 35);
            button7.TabIndex = 3;
            button7.Text = "Добавить пользователя";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 152);
            radioButton1.Margin = new Padding(5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(222, 31);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Администратор";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 95);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 36);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 98);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 27);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 58);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 55);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 36);
            textBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 191, 186);
            ClientSize = new Size(1287, 783);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MinimumSize = new Size(1120, 830);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин канцелярских товаров \"Дарвин\"";
            FormClosing += MainForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button button13;
    }
}