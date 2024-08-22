namespace FinanceSys_Test
{
    partial class Incomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomes));
            label7 = new Label();
            IncomeList = new DataGridView();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            label5 = new Label();
            DescTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            CatTb = new TextBox();
            label2 = new Label();
            AmountTb = new TextBox();
            NameTb = new TextBox();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            LogoutBtn = new PictureBox();
            IncomeBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            DashboardBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            DateTb = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)IncomeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SeaGreen;
            label7.Location = new Point(584, 73);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 33;
            label7.Text = "Income List";
            // 
            // IncomeList
            // 
            IncomeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncomeList.Location = new Point(313, 98);
            IncomeList.Name = "IncomeList";
            IncomeList.Size = new Size(666, 409);
            IncomeList.TabIndex = 32;
            IncomeList.CellContentClick += IncomeList_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Gold;
            DeleteBtn.FlatAppearance.BorderColor = Color.Gold;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            DeleteBtn.Location = new Point(143, 478);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 25);
            DeleteBtn.TabIndex = 31;
            DeleteBtn.Text = "Delete Income";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Gold;
            EditBtn.FlatAppearance.BorderColor = Color.Gold;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            EditBtn.Location = new Point(205, 447);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(101, 25);
            EditBtn.TabIndex = 30;
            EditBtn.Text = "Edit Income";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Gold;
            AddBtn.FlatAppearance.BorderColor = Color.Gold;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            AddBtn.Location = new Point(77, 447);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(101, 25);
            AddBtn.TabIndex = 29;
            AddBtn.Text = "Add Income";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(111, 380);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 28;
            label5.Text = "Income Description";
            // 
            // DescTb
            // 
            DescTb.BackColor = Color.FromArgb(4, 13, 18);
            DescTb.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescTb.ForeColor = SystemColors.Info;
            DescTb.Location = new Point(111, 398);
            DescTb.Name = "DescTb";
            DescTb.Size = new Size(149, 26);
            DescTb.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(111, 316);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 26;
            label4.Text = "Income Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(111, 253);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 24;
            label3.Text = "Income Category";
            // 
            // CatTb
            // 
            CatTb.BackColor = Color.FromArgb(4, 13, 18);
            CatTb.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CatTb.ForeColor = SystemColors.Info;
            CatTb.Location = new Point(111, 271);
            CatTb.Name = "CatTb";
            CatTb.Size = new Size(149, 26);
            CatTb.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(111, 187);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 21;
            label2.Text = "Income Amount";
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.FromArgb(4, 13, 18);
            AmountTb.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountTb.ForeColor = SystemColors.Info;
            AmountTb.Location = new Point(111, 205);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(149, 26);
            AmountTb.TabIndex = 20;
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.FromArgb(4, 13, 18);
            NameTb.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTb.ForeColor = SystemColors.Info;
            NameTb.Location = new Point(111, 138);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(149, 26);
            NameTb.TabIndex = 17;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(15, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 48);
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(59, 19);
            label6.Name = "label6";
            label6.Size = new Size(443, 35);
            label6.TabIndex = 15;
            label6.Text = "Finance Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 206, 20);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(64, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 70);
            panel2.TabIndex = 18;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(7, 466);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(50, 52);
            LogoutBtn.TabIndex = 4;
            LogoutBtn.TabStop = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // IncomeBtn
            // 
            IncomeBtn.Image = (Image)resources.GetObject("IncomeBtn.Image");
            IncomeBtn.Location = new Point(10, 200);
            IncomeBtn.Name = "IncomeBtn";
            IncomeBtn.Size = new Size(44, 40);
            IncomeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            IncomeBtn.TabIndex = 3;
            IncomeBtn.TabStop = false;
            IncomeBtn.Click += IncomeBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 269);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 44);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Image = (Image)resources.GetObject("DashboardBtn.Image");
            DashboardBtn.Location = new Point(10, 335);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(44, 47);
            DashboardBtn.TabIndex = 1;
            DashboardBtn.TabStop = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(111, 120);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 19;
            label1.Text = "Income Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 13, 18);
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(IncomeBtn);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(64, 533);
            panel1.TabIndex = 16;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(164, 77);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // DateTb
            // 
            DateTb.CalendarForeColor = Color.FromArgb(192, 192, 0);
            DateTb.CalendarMonthBackground = Color.FromArgb(192, 64, 0);
            DateTb.CalendarTitleBackColor = Color.Fuchsia;
            DateTb.CalendarTitleForeColor = Color.FromArgb(128, 64, 0);
            DateTb.CalendarTrailingForeColor = Color.FromArgb(0, 192, 192);
            DateTb.Format = DateTimePickerFormat.Short;
            DateTb.Location = new Point(111, 344);
            DateTb.Name = "DateTb";
            DateTb.Size = new Size(152, 23);
            DateTb.TabIndex = 34;
            // 
            // Incomes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 13, 18);
            ClientSize = new Size(993, 533);
            Controls.Add(DateTb);
            Controls.Add(pictureBox6);
            Controls.Add(label7);
            Controls.Add(IncomeList);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label5);
            Controls.Add(DescTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CatTb);
            Controls.Add(label2);
            Controls.Add(AmountTb);
            Controls.Add(NameTb);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Incomes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)IncomeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView IncomeList;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label5;
        private TextBox DescTb;
        private Label label4;
        private Label label3;
        private TextBox CatTb;
        private Label label2;
        private TextBox AmountTb;
        private TextBox NameTb;
        private PictureBox pictureBox7;
        private Label label6;
        private Panel panel2;
        private PictureBox LogoutBtn;
        private PictureBox IncomeBtn;
        private PictureBox pictureBox3;
        private PictureBox DashboardBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox6;
        private DateTimePicker DateTb;
    }
}