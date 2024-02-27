namespace OnlineStore
{
    partial class Form1
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1 = new Panel();
            label1 = new Label();
            customerInsertButton = new Button();
            customerUpdateButton = new Button();
            customerDeleteButton = new Button();
            dataGridView1 = new DataGridView();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            CustomersPage = new TabPage();
            BDateTextBox = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            SpecialityTextBox = new TextBox();
            ProductsPage = new TabPage();
            StartTextBox = new DateTimePicker();
            label6 = new Label();
            EndTextBox = new DateTimePicker();
            label5 = new Label();
            productInsertButton = new Button();
            productUpdateButton = new Button();
            productDeleteButton = new Button();
            OrdersPage = new TabPage();
            label18 = new Label();
            OrdersProductsPage = new TabPage();
            label16 = new Label();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            CustomersPage.SuspendLayout();
            ProductsPage.SuspendLayout();
            OrdersPage.SuspendLayout();
            OrdersProductsPage.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 1130);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1228, 32);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = SystemColors.Highlight;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(156, 25);
            toolStripStatusLabel1.Text = "Number of row(s):";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 156);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Wide Latin", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(547, 54);
            label1.TabIndex = 0;
            label1.Text = "Rich (BAP_3)";
            // 
            // customerInsertButton
            // 
            customerInsertButton.BackColor = Color.FromArgb(192, 255, 192);
            customerInsertButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerInsertButton.Location = new Point(82, 286);
            customerInsertButton.Margin = new Padding(4, 5, 4, 5);
            customerInsertButton.Name = "customerInsertButton";
            customerInsertButton.Size = new Size(159, 56);
            customerInsertButton.TabIndex = 2;
            customerInsertButton.Text = "Insert";
            customerInsertButton.UseVisualStyleBackColor = false;
            customerInsertButton.Click += customerInsertButton_Click;
            // 
            // customerUpdateButton
            // 
            customerUpdateButton.BackColor = Color.FromArgb(192, 255, 255);
            customerUpdateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerUpdateButton.Location = new Point(477, 286);
            customerUpdateButton.Margin = new Padding(4, 5, 4, 5);
            customerUpdateButton.Name = "customerUpdateButton";
            customerUpdateButton.Size = new Size(159, 56);
            customerUpdateButton.TabIndex = 3;
            customerUpdateButton.Text = "Update ()";
            customerUpdateButton.UseVisualStyleBackColor = false;
            customerUpdateButton.Click += customerUpdateButton_Click;
            // 
            // customerDeleteButton
            // 
            customerDeleteButton.BackColor = Color.FromArgb(255, 192, 192);
            customerDeleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerDeleteButton.Location = new Point(901, 286);
            customerDeleteButton.Margin = new Padding(4, 5, 4, 5);
            customerDeleteButton.Name = "customerDeleteButton";
            customerDeleteButton.Size = new Size(159, 56);
            customerDeleteButton.TabIndex = 4;
            customerDeleteButton.Text = "Delete ()";
            customerDeleteButton.UseVisualStyleBackColor = false;
            customerDeleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 655);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1131, 349);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(200, 48);
            lastNameTextBox.Margin = new Padding(4, 5, 4, 5);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(290, 31);
            lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(200, 118);
            firstNameTextBox.Margin = new Padding(4, 5, 4, 5);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(290, 31);
            firstNameTextBox.TabIndex = 7;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameTextBox.Location = new Point(200, 190);
            middleNameTextBox.Margin = new Padding(4, 5, 4, 5);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(290, 31);
            middleNameTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 9;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 10;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 11;
            label4.Text = "Middle Name:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CustomersPage);
            tabControl1.Controls.Add(ProductsPage);
            tabControl1.Controls.Add(OrdersPage);
            tabControl1.Controls.Add(OrdersProductsPage);
            tabControl1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ItemSize = new Size(131, 25);
            tabControl1.Location = new Point(48, 205);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1136, 418);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 12;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(BDateTextBox);
            CustomersPage.Controls.Add(label8);
            CustomersPage.Controls.Add(label9);
            CustomersPage.Controls.Add(SpecialityTextBox);
            CustomersPage.Controls.Add(customerInsertButton);
            CustomersPage.Controls.Add(label4);
            CustomersPage.Controls.Add(customerUpdateButton);
            CustomersPage.Controls.Add(label3);
            CustomersPage.Controls.Add(customerDeleteButton);
            CustomersPage.Controls.Add(label2);
            CustomersPage.Controls.Add(lastNameTextBox);
            CustomersPage.Controls.Add(middleNameTextBox);
            CustomersPage.Controls.Add(firstNameTextBox);
            CustomersPage.Location = new Point(4, 29);
            CustomersPage.Margin = new Padding(4, 5, 4, 5);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(4, 5, 4, 5);
            CustomersPage.Size = new Size(1128, 385);
            CustomersPage.TabIndex = 0;
            CustomersPage.Text = "worker";
            CustomersPage.UseVisualStyleBackColor = true;
            // 
            // BDateTextBox
            // 
            BDateTextBox.Location = new Point(737, 118);
            BDateTextBox.Name = "BDateTextBox";
            BDateTextBox.Size = new Size(300, 26);
            BDateTextBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(594, 122);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 15;
            label8.Text = "Birthday:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(585, 51);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 14;
            label9.Text = "Speciality:";
            // 
            // SpecialityTextBox
            // 
            SpecialityTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialityTextBox.Location = new Point(725, 45);
            SpecialityTextBox.Margin = new Padding(4, 5, 4, 5);
            SpecialityTextBox.Name = "SpecialityTextBox";
            SpecialityTextBox.Size = new Size(312, 31);
            SpecialityTextBox.TabIndex = 12;
            // 
            // ProductsPage
            // 
            ProductsPage.Controls.Add(StartTextBox);
            ProductsPage.Controls.Add(label6);
            ProductsPage.Controls.Add(EndTextBox);
            ProductsPage.Controls.Add(label5);
            ProductsPage.Controls.Add(productInsertButton);
            ProductsPage.Controls.Add(productUpdateButton);
            ProductsPage.Controls.Add(productDeleteButton);
            ProductsPage.Location = new Point(4, 29);
            ProductsPage.Margin = new Padding(4, 5, 4, 5);
            ProductsPage.Name = "ProductsPage";
            ProductsPage.Padding = new Padding(4, 5, 4, 5);
            ProductsPage.Size = new Size(1128, 385);
            ProductsPage.TabIndex = 1;
            ProductsPage.Text = "period";
            ProductsPage.UseVisualStyleBackColor = true;
            // 
            // StartTextBox
            // 
            StartTextBox.Location = new Point(194, 58);
            StartTextBox.Name = "StartTextBox";
            StartTextBox.Size = new Size(300, 26);
            StartTextBox.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 59);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 26;
            label6.Text = "Начало периода:";
            // 
            // EndTextBox
            // 
            EndTextBox.Location = new Point(194, 130);
            EndTextBox.Name = "EndTextBox";
            EndTextBox.Size = new Size(300, 26);
            EndTextBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 130);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 24;
            label5.Text = "Конец периода:";
            // 
            // productInsertButton
            // 
            productInsertButton.BackColor = Color.FromArgb(192, 255, 192);
            productInsertButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productInsertButton.Location = new Point(346, 286);
            productInsertButton.Margin = new Padding(4, 5, 4, 5);
            productInsertButton.Name = "productInsertButton";
            productInsertButton.Size = new Size(159, 56);
            productInsertButton.TabIndex = 21;
            productInsertButton.Text = "Insert";
            productInsertButton.UseVisualStyleBackColor = false;
            productInsertButton.Click += productInsertButton_Click;
            // 
            // productUpdateButton
            // 
            productUpdateButton.BackColor = Color.FromArgb(192, 255, 255);
            productUpdateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productUpdateButton.Location = new Point(512, 286);
            productUpdateButton.Margin = new Padding(4, 5, 4, 5);
            productUpdateButton.Name = "productUpdateButton";
            productUpdateButton.Size = new Size(159, 56);
            productUpdateButton.TabIndex = 22;
            productUpdateButton.Text = "Update ()";
            productUpdateButton.UseVisualStyleBackColor = false;
            productUpdateButton.Click += productUpdateButton_Click;
            // 
            // productDeleteButton
            // 
            productDeleteButton.BackColor = Color.FromArgb(255, 192, 192);
            productDeleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productDeleteButton.Location = new Point(679, 286);
            productDeleteButton.Margin = new Padding(4, 5, 4, 5);
            productDeleteButton.Name = "productDeleteButton";
            productDeleteButton.Size = new Size(159, 56);
            productDeleteButton.TabIndex = 23;
            productDeleteButton.Text = "Delete ()";
            productDeleteButton.UseVisualStyleBackColor = false;
            productDeleteButton.Click += deleteButton_Click;
            // 
            // OrdersPage
            // 
            OrdersPage.Controls.Add(label18);
            OrdersPage.Location = new Point(4, 29);
            OrdersPage.Margin = new Padding(4, 5, 4, 5);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Size = new Size(1128, 385);
            OrdersPage.TabIndex = 2;
            OrdersPage.Text = "otchet";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(31, 42);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(299, 150);
            label18.TabIndex = 20;
            label18.Text = "    Таблица имеет следующие поля:\r\n- id_otchet\r\n- id_avans_otchet\r\n- status\r\n- ost_summa\t\r\n- potr_summa\t\r\n";
            // 
            // OrdersProductsPage
            // 
            OrdersProductsPage.Controls.Add(label16);
            OrdersProductsPage.Location = new Point(4, 29);
            OrdersProductsPage.Margin = new Padding(4, 5, 4, 5);
            OrdersProductsPage.Name = "OrdersProductsPage";
            OrdersProductsPage.Size = new Size(1128, 385);
            OrdersProductsPage.TabIndex = 3;
            OrdersProductsPage.Text = "avans_otchet";
            OrdersProductsPage.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(31, 42);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(200, 150);
            label16.TabIndex = 20;
            label16.Text = "    Таблица имеет поля:\r\n- id_avans_otchet\r\n- id_worker\t\r\n- article_zatrat\r\n- summa\r\n- kol\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1228, 1162);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Online-store";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            CustomersPage.PerformLayout();
            ProductsPage.ResumeLayout(false);
            ProductsPage.PerformLayout();
            OrdersPage.ResumeLayout(false);
            OrdersPage.PerformLayout();
            OrdersProductsPage.ResumeLayout(false);
            OrdersProductsPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerInsertButton;
        private System.Windows.Forms.Button customerUpdateButton;
        private System.Windows.Forms.Button customerDeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomersPage;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage OrdersProductsPage;
        private System.Windows.Forms.Button productInsertButton;
        private System.Windows.Forms.Button productUpdateButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox SpecialityTextBox;
        private DateTimePicker BDateTextBox;
        private DateTimePicker StartTextBox;
        private Label label6;
        private DateTimePicker EndTextBox;
        private Label label5;
    }
}

