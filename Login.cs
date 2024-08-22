namespace FinanceSys_Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (UnameTb.Text == "Admin" || PasswordTb.Text == "Admin")
            {
                Incomes obj = new Incomes();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password !!!");
            }
        }
    }
}
