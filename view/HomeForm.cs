

using BankMekllat.controller;
using BankMekllat.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankMekllat.view
{
    public partial class HomeForm : Form
    {
        DatabaseManager database;
        List<Branch> branches;
        List<Banker> bankers;
        List<Account> accounts;
        List<Customer> customers;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
             database = DatabaseManager.getInstance();
            branches = database.GetBranches();
             foreach(Branch branch in branches){
                branches_list.Items.Add(branch.ToString());
            }
            bankers = database.GetBankers();
            foreach (Banker banker in bankers)
            {
                Bankers_list.Items.Add(banker.ToString());
            }

             accounts = database.GetAccounts();
            foreach (Account account in accounts)
            {
                Accounts_list.Items.Add(account.ToString());
            }

             customers = database.GetCustomers();
            foreach (Customer customer in customers)
            {
                Customers_list.Items.Add(customer.ToString());
            }
        }

        private void Branches_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (branches_list.SelectedIndex != -1)
            {
                DatabaseResult databaseResult;
                Branch branch = branches[branches_list.SelectedIndex];
                string message = $"Branch:\nname: {branch.BranchDetails.Branchname}" +
                    $"\nBranch code: {branch.BranchDetails.Branchcode}\n\nAddress:\nCode posti: {branch.Address.Code_Posti}" +
                    $"\nStreet: {branch.Address.Street}\n{branch.Address.Info}";
                MessageForm form = new MessageForm(message,
                    (MessageForm.Result result) =>

                        { 
                        if (result == MessageForm.Result.delete)
                        {
                                DialogResult dialog = MessageBox.Show("Are you sure to delete this item ?", "Delete Warning"
                                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                if (dialog == DialogResult.OK)
                                {
                                    databaseResult = database.deleteBranch(branch.BranchDetails.Branchcode);
                                    if (databaseResult.Result)
                                    {
                                        databaseResult = database.deleteAddress(branch.Address.Code_Posti);
                                        if (databaseResult.Result)
                                        {
                                            MessageBox.Show("Selected branch deleted successfully");
                                        }
                                        else MessageBox.Show(databaseResult.Message, "error while deleting address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }else MessageBox.Show(databaseResult.Message, "error while deleting branch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                              
                        }
                    });
                form.Show();
                    
            }
           
               
         
        }

        private void Bankers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Bankers_list.SelectedIndex == -1)
            //{
            //    info_lbl.Text = "";
            //}
            //else
            //{
            //    Banker banker = bankers[Bankers_list.SelectedIndex];
            //info_lbl.Text = banker.BankerDetails.ToString();
            
            //info_lbl.Text += "\n\n" + banker.Address.ToString();

            //}
            

        }

        private void Accounts_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Accounts_list.SelectedIndex == -1)
            //{
            //    info_lbl.Text = "";
            //}
            //else
            //{
            //    Account account = accounts[Accounts_list.SelectedIndex];
            //    info_lbl.Text = "Account:\n" + account.AccountDetails.AccountNumber + "\n" + account.AccountDetails.AccountOpenningDate +
            //        "\n";
            //    if (account.AccountDetails.AccountType == 0)
            //    {
            //        info_lbl.Text += "current account\n\n";
            //    }
            //    else info_lbl.Text += "saving account\n\n";

            //    info_lbl.Text += account.Banker.ToString();
            //    info_lbl.Text += "\n\n" + account.Customer.ToString();
            //}
           
        }

        private void Customers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Customers_list.SelectedIndex == -1)
            //{
            //    info_lbl.Text = "";
            //}
            //else
            //{
            // Customer customer = customers[Customers_list.SelectedIndex];
            //info_lbl.Text = customer.CustomerDetails.ToString();
            //info_lbl.Text += "\n\n" + customer.Address.ToString();
            //}
           
        }

        private void Account_btn_Click(object sender, EventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = true;
            Add_AccountForm add_Account = new Add_AccountForm();
            Close();
            add_Account.Show();
        }

  

        private void branch_btn_Click(object sender, EventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = true;
            Add_BranchForm add_Branch = new Add_BranchForm();
            add_Branch.Show();
            Close();
        }

        private void banker_btn_Click(object sender, EventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = true;
            Add_BankerForm add_Banker = new Add_BankerForm();
            add_Banker.Show();
            Close();
        }

       
        
        private void Check_btn_Click(object sender, EventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = true;
            CheckForm check = new CheckForm();
            check.Show();
            Close();
        }

        private void Loan_btn_Click(object sender, EventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = true;
            LoanForm form = new LoanForm();
            form.Show();
            Close();
        }

        private void Transaction_txt_Click(object sender, EventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = true;
            TransactionForm form = new TransactionForm();
            form.Show();
            Close();
        }
        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DatabaseManager.getInstance().FormIsRunning == false)
            {
            MessageBox.Show("Good life :)");
            DatabaseManager.getInstance().closeProgram();
            }
           
        }

       
    }
}
