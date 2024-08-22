namespace FinanceSys_Test
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            IncomeBtn = new PictureBox();
            label14 = new Label();
            label1 = new Label();
            LoginBtn = new Button();
            CloseBtn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 327);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(46, 158);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 40;
            label4.Text = "Expenses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(29, 135);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 39;
            label3.Text = "Income Module";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(7, 99);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 38;
            label2.Text = "Finance Management";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(211, 162);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(177, 27);
            UnameTb.TabIndex = 1;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(211, 227);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(177, 27);
            PasswordTb.TabIndex = 2;
            // 
            // IncomeBtn
            // 
            IncomeBtn.Image = (Image)resources.GetObject("IncomeBtn.Image");
            IncomeBtn.Location = new Point(233, 21);
            IncomeBtn.Name = "IncomeBtn";
            IncomeBtn.Size = new Size(128, 95);
            IncomeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            IncomeBtn.TabIndex = 4;
            IncomeBtn.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.SeaGreen;
            label14.Location = new Point(207, 138);
            label14.Name = "label14";
            label14.Size = new Size(83, 21);
            label14.TabIndex = 35;
            label14.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(211, 203);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 36;
            label1.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(98, 148, 255);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Location = new Point(230, 267);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(143, 41);
            LoginBtn.TabIndex = 37;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.BackColor = Color.WhiteSmoke;
            CloseBtn.ForeColor = Color.Crimson;
            CloseBtn.Location = new Point(422, 9);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(18, 19);
            CloseBtn.TabIndex = 38;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 327);
            Controls.Add(CloseBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(IncomeBtn);
            Controls.Add(PasswordTb);
            Controls.Add(UnameTb);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox UnameTb;
        private TextBox PasswordTb;
        private PictureBox IncomeBtn;
        private Label label14;
        private Label label1;
        private Button LoginBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label CloseBtn;
    }
}