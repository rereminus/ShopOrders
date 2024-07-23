namespace ShopOrders.Forms
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(83, 322);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(146, 322);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(83, 404);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(221, 32);
            button1.TabIndex = 3;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(83, 357);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Location = new Point(146, 357);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(130, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(56, 20);
            label3.Name = "label3";
            label3.Size = new Size(293, 34);
            label3.TabIndex = 5;
            label3.Text = "Добро пожаловать!";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(380, 21);
            label4.TabIndex = 6;
            label4.Text = "Магазин канцелярских товаров \"Дарвин\"";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.owlnew;
            pictureBox1.Location = new Point(86, 79);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.icon;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(277, 357);
            button2.Name = "button2";
            button2.Size = new Size(27, 27);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 194, 190);
            ClientSize = new Size(395, 468);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин канцелярских товаров \"Дарвин\"";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Button button2;
    }
}