namespace FinanceSys_Test
{
    public partial class Incomes : Form
    {
        Functions Con;
        public Incomes()
        {
            Con = new Functions();
            InitializeComponent();
            ShowIncome();
        }
        private void ShowIncome()
        {
            string Query = "select * from IncomeTbl";
            IncomeList.DataSource = Con.GetData(Query);
        }
        private void IncomeBtn_Click(object sender, EventArgs e)
        {
            Incomes obj = new Incomes();
            obj.Show();
            this.Hide();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }


        // this query is vulnerable to sql injection attacks but if its local is it good
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "insert into IncomeTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, IName, Amt, Category, DateTb.Value.Date.ToString("yyyy-MM-dd"), Description);
                    Con.SetData(Query);
                    MessageBox.Show("Income Added!!!");
                    ShowIncome();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }

        }

        int key = 0;
        //private void IncomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    NameTb.Text = IncomeList.SelectedRows[0].Cells[1].Value.ToString();
        //    AmountTb.Text = IncomeList.SelectedRows[0].Cells[2].Value.ToString();
        //    CatTb.Text = IncomeList.SelectedRows[0].Cells[3].Value.ToString();
        //    //NameTb.Text = IncomeList.SelectedRows[0].Cells[1].Value.ToString();
        //    DescTb.Text = IncomeList.SelectedRows[0].Cells[5].Value.ToString();

        //    if (NameTb.Text == "")
        //    {
        //        key = 0;
        //    }
        //    else
        //    {
        //        key = Convert.ToInt32(IncomeList.SelectedRows[0].Cells[0].ToString());
        //    }

        //}

        private void IncomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IncomeList.SelectedRows.Count > 0)
            {
                NameTb.Text = IncomeList.SelectedRows[0].Cells[1].Value.ToString();
                AmountTb.Text = IncomeList.SelectedRows[0].Cells[2].Value.ToString();
                CatTb.Text = IncomeList.SelectedRows[0].Cells[3].Value.ToString();
                DescTb.Text = IncomeList.SelectedRows[0].Cells[5].Value.ToString();

                key = Convert.ToInt32(IncomeList.SelectedRows[0].Cells[0].Value); // Update key variable
            }
            else
            {
                key = 0;
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "update IncomeTbl set IncName = '{0}',IncAmt ='{1}',IncCat = '{2}',IncDate = '{3}',IncDesc = '{4}' where IncId = '{5}'";
                    Query = string.Format(Query, IName, Amt, Category, DateTb.Value.Date.ToString("yyyy-MM-dd"), Description);
                    Con.SetData(Query);
                    MessageBox.Show("Income updated!!!");
                    ShowIncome();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Data!!!");
            }
            else
            {
                try
                {
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "delete from IncomeTbl where IncId = {0} ";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    MessageBox.Show("Income Deleted!!!");
                    ShowIncome();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
