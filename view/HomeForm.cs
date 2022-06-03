

using BankMekllat.controller;
using BankMekllat.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankMekllat.view
{
    public partial class HomeForm : Form
    {
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
            DatabaseManager database = DatabaseManager.getInstance();
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
            
                Branch branch = branches[branches_list.SelectedIndex];
                info_lbl.Text = "Branch:\n" + branch.BranchDetails.Branchname + "\n" + branch.BranchDetails.Branchcode +
                    "\n\n" + branch.Address.ToString();
           
           
            
         
        }

        private void Bankers_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            Banker banker = bankers[Bankers_list.SelectedIndex];
            info_lbl.Text = banker.BankerDetails.ToString();
            
            info_lbl.Text += "\n\n" + banker.Address.ToString();

        }

        private void Accounts_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account account = accounts[Accounts_list.SelectedIndex];
            info_lbl.Text = "Account:\n" + account.AccountDetails.AccountNumber + "\n" + account.AccountDetails.AccountOpenningDate +
                "\n";
            if (account.AccountDetails.AccountType == 0)
            {
                info_lbl.Text += "current account\n\n";
            }else info_lbl.Text += "saving account\n\n";

            info_lbl.Text += account.Banker.ToString();
            info_lbl.Text += "\n\n" + account.Customer.ToString();
        }

        private void Customers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = customers[Customers_list.SelectedIndex];
            info_lbl.Text = customer.CustomerDetails.ToString();
            info_lbl.Text += "\n\n" + customer.Address.ToString();
        }

        private void btn_AddAcc_Click(object sender, EventArgs e)
        {
            Add_Account add_Account = new Add_Account();
            add_Account.Show();
        }
    }
}
