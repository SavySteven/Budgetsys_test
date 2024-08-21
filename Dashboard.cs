namespace FinanceSys_Test
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            Expenses obj = new Expenses();
            obj.Show();
            this.Hide();
        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }
    }
}
