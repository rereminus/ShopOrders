namespace ShopOrders.Forms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 14);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "Дата заказа";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(248, 241, 239);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(556, 43);
            button1.Margin = new Padding(7, 5, 7, 5);
            button1.Name = "button1";
            button1.Size = new Size(127, 37);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(20, 189);
            listBox1.Margin = new Padding(7, 5, 7, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(425, 151);
            listBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 163);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 21);
            label2.TabIndex = 5;
            label2.Text = "Добавленные товары";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(335, 43);
            comboBox1.Margin = new Padding(7, 5, 7, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 29);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 17);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 7;
            label3.Text = "Товар";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(248, 241, 239);
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(486, 285);
            button2.Margin = new Padding(7, 5, 7, 5);
            button2.Name = "button2";
            button2.Size = new Size(197, 37);
            button2.TabIndex = 8;
            button2.Text = "Удалить товар";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(248, 241, 239);
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(20, 352);
            button3.Margin = new Padding(7, 5, 7, 5);
            button3.Name = "button3";
            button3.Size = new Size(497, 37);
            button3.TabIndex = 9;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 88);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 10;
            label4.Text = "Статус";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(335, 114);
            comboBox2.Margin = new Padding(7, 5, 7, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(197, 29);
            comboBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 89);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 12;
            label5.Text = "ФИО клиента";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 114);
            textBox2.Margin = new Padding(7, 5, 7, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 28);
            textBox2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 14;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 225, 222);
            ClientSize = new Size(703, 409);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 5, 7, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин канцелярских товаров \"Дарвин\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private DateTimePicker dateTimePicker1;
    }
}