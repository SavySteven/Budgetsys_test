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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            IncomeBtn = new PictureBox();
            label14 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(211, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 27);
            textBox2.TabIndex = 2;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(98, 148, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(230, 267);
            button1.Name = "button1";
            button1.Size = new Size(143, 41);
            button1.TabIndex = 37;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 327);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(IncomeBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox IncomeBtn;
        private Label label14;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}