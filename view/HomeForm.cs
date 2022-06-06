

using BankMekllat.controller;
using BankMekllat.datamodels;
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
        List<Check> checks;
        List<Loan> loans;
        List<Transaction> transactions;
        List<Address> addresses;
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

            checks = database.GetChecks();
            foreach(Check check in checks)
            {
                check_list.Items.Add(check);
            }

            loans = database.GetLoans();
            foreach(Loan loan in loans)
            {
                loan_list.Items.Add(loan);
            }

            transactions = database.GetTransactions();
            foreach(Transaction transaction in transactions)
            {
                transaction_list.Items.Add(transaction);
            }

            addresses = database.GetAddresses();
            foreach(Address address in addresses)
            {
                address_list.Items.Add(address);
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
           if (Bankers_list.SelectedIndex != -1)
            {
                DatabaseResult databaseResult;
                Banker banker = bankers[Bankers_list.SelectedIndex];
                BankerDetails details = banker.BankerDetails;
                Address address = banker.Address;
                BranchDetails branch = banker.BranchDetails;
                string position;
                string gender;
                if (details.Position == 0)
                {
                    position = "Boss";
                }
                else position = "Employee";

                if (details.Gender)
                {
                    gender = "Maile";
                } else gender = "Femaile";

                string message = $"Banker:\nNational Code : {details.NationalCode}\n" +
                    $"First name : {details.Fname}\nLast name : {details.Lname}\n" +
                    $"Birth date : {details.Birthdate}\nPosition :{position}\nFather name : {details.Fathername}" +
                    $"\nEducation :{details.Education}\nGender :{gender}\nPhone number : {details.PhoneNumber}" +
                    $"\n\nAddress:\nCode posti: {address.Code_Posti}" +
                    $"\nStreet: {address.Street}\n{address.Info}\n\nBranch :\nBranch name :{branch.Branchname}\n" +
                    $"Branch code : {branch.Branchcode}\n";

                MessageForm form = new MessageForm(message,
                    (MessageForm.Result result) =>

                    {
                        if (result == MessageForm.Result.delete)
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure to delete this item ?", "Delete Warning"
                                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (dialog == DialogResult.OK)
                            {
                                databaseResult = database.deleteBanker(details.NationalCode);
                                if (databaseResult.Result)
                                {
                                    databaseResult = database.deleteAddress(address.Code_Posti);
                                    if (databaseResult.Result)
                                    {
                                        MessageBox.Show("Selected branch deleted successfully");
                                    }
                                    else MessageBox.Show(databaseResult.Message, "error while deleting address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show(databaseResult.Message, "error while deleting banker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (result == MessageForm.Result.edit)
                        {
                            // navagate to edit form
                        }
                    });
                form.Show();


            }

        }

        private void Accounts_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Accounts_list.SelectedIndex != -1)
            {
                DatabaseResult databaseResult;
                Account account = accounts[Accounts_list.SelectedIndex];
                AccountDetails details = account.AccountDetails;
                CustomerDetails customer = account.Customer;
                BankerDetails banker = account.Banker;
                BranchDetails branch = account.Branch;
                string accountType;
                if (account.AccountDetails.AccountType == 0)
                {
                    accountType= "current account";
                }
                else accountType= "saving account";
                string position;
                string bGender;
                string cGender;
                if (banker.Position == 0)
                {
                    position = "Boss";
                }
                else position = "Employee";

                if (banker.Gender)
                {
                    bGender = "Maile";
                }
                else bGender = "Femaile";

                if (customer.Gender)
                {
                    cGender = "Maile";
                }
                else cGender = "Femaile";

                string message = $"Account:\nAccount number :{details.AccountNumber}\nCard number : {details.Cardnumber}\n" +
                    $"Sheba account number : {details.Shebaaccountnumber}\nAccount type : {details.AccountType}\n" +
                    $"Openning date : {details.AccountOpenningDate}\nProfit percentage : {details.ProfitPercentage}\n" +
                    $"Balance : {details.ProfitPercentage}\n\nCustomer:\n National Code: { customer.NationalCode}\n" +
                   $"First name : {customer.Fname}\nLast name : {customer.Lname}\n" +
                   $"Birth date : {customer.Birthdate}\nJob :{customer.Job}\nFather name : {customer.FatherName}" +
                   $"\nEducation :{customer.Education}\nGender :{cGender}\nPhone number : {customer.PhoneNumber}\n\n" +
                    $"Banker:\nNational Code : {banker.NationalCode}\n" +
                   $"First name : {banker.Fname}\nLast name : {banker.Lname}\n" +
                   $"Birth date : {banker.Birthdate}\nPosition :{position}\nFather name : {banker.Fathername}" +
                   $"\nEducation :{banker.Education}\nGender :{bGender}\nPhone number : {banker.PhoneNumber}" +
                   $"Branch:\nname: {branch.Branchname}" +
                    $"\nBranch code: {branch.Branchcode}";

                MessageForm form = new MessageForm(message,
                    (MessageForm.Result result) =>

                    {
                        if (result == MessageForm.Result.delete)
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure to delete this item ?\nif you delete account , will deleted all transaction of this account", "Delete Warning"
                                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (dialog == DialogResult.OK)
                            {
                                databaseResult = database.deleteTransaction(details.AccountNumber);
                                if (databaseResult.Result)
                                {
                                    databaseResult = database.deleteAccount(details.AccountNumber);
                                if (databaseResult.Result)
                                {

                                    MessageBox.Show("Selected account deleted successfully");

                                }
                                else MessageBox.Show(databaseResult.Message, "error while deleting account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }else MessageBox.Show(databaseResult.Message, "error while deleting transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                            else if (result == MessageForm.Result.edit)
                            {
                                // navagate to edit form
                            }
                        }
                    });
                form.Show();


            }

        }

        private void Customers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Customers_list.SelectedIndex != -1)
            {
                Customer customer = customers[Customers_list.SelectedIndex];
                DatabaseResult databaseResult;

                CustomerDetails details = customer.CustomerDetails;
                Address address = customer.Address;
      
                
                string gender;
            
                if (details.Gender)
                {
                    gender = "Maile";
                }
                else gender = "Femaile";

                string message = $"Customer:\nNational Code : {details.NationalCode}\n" +
                    $"First name : {details.Fname}\nLast name : {details.Lname}\n" +
                    $"Birth date : {details.Birthdate}\nJob :{details.Job}\nFather name : {details.FatherName}" +
                    $"\nEducation :{details.Education}\nGender :{gender}\nPhone number : {details.PhoneNumber}" +
                    $"\n\nAddress:\nCode posti: {address.Code_Posti}" +
                    $"\nStreet: {address.Street}\n{address.Info}";

                MessageForm form = new MessageForm(message,
                    (MessageForm.Result result) =>

                    {
                        if (result == MessageForm.Result.delete)
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure to delete this item ?", "Delete Warning"
                                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (dialog == DialogResult.OK)
                            {
                                databaseResult = database.deleteCustomer(details.NationalCode);
                                if (databaseResult.Result)
                                {
                                    databaseResult = database.deleteAddress(address.Code_Posti);
                                    if (databaseResult.Result)
                                    {
                                        MessageBox.Show("Selected branch deleted successfully");
                                    }
                                    else MessageBox.Show(databaseResult.Message, "error while deleting address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show(databaseResult.Message, "error while deleting customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (result == MessageForm.Result.edit)
                        {
                            // navagate to edit form
                        }
                    });
                form.Show();

            }

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
