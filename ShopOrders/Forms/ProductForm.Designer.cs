namespace ShopOrders.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(248, 241, 239);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(703, 35);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(60, 35);
            button1.TabIndex = 0;
            button1.Text = "Ок";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(170, 14);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Наименование";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(24, 39);
            textBox1.Margin = new Padding(6, 5, 6, 5);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 26);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(529, 14);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Цена (руб.)";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(500, 39);
            textBox2.Margin = new Padding(6, 5, 6, 5);
            textBox2.MaxLength = 9;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 26);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 225, 222);
            ClientSize = new Size(778, 99);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин канцелярских товаров \"Дарвин\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}