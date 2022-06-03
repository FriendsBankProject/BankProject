using System;

using System.Windows.Forms;
using BankMekllat.datamodels;
using BankMekllat.model;
using BankMekllat.controller;

namespace BankMekllat.view
{
    public partial class Add_Account : Form
    {
        DatabaseManager database = DatabaseManager.getInstance();
        public Add_Account()
        {
            InitializeComponent();
        }

        Add_Account(Account account,Customer customer,Address address)
        {
            InitializeComponent();
            txt_FName.Text = account.Customer.Fname.ToString();
            txt_LName.Text = account.Customer.Lname.ToString();
            txt_FatherName.Text = account.Customer.FatherName.ToString();
            txt_city.Text = customer.Address.ToString();
            txt_BirthDate.Text = customer.CustomerDetails.Birthdate.ToString();
            txt_CustomerNational.Text = customer.CustomerDetails.NationalCode.ToString();
            txt_Education.Text = customer.CustomerDetails.Education.ToString();
            txt_Job.Text = customer.CustomerDetails.Job.ToString();
            txt_PhoneNum.Text = customer.CustomerDetails.PhoneNumber.ToString();
            if (customer.CustomerDetails.Gender)
            {
                combo_gender.SelectedItem = "male";
            }
            else combo_gender.SelectedItem = "female";
            txt_city.Text = address.City.ToString();
            txt_street.Text = address.Street.ToString();
            txt_info.Text = address.Info.ToString();
            txt_zip.Text = address.Code_Posti.ToString();
             
            //for account information 

            txt_AccountNum.Text = account.AccountDetails.AccountNumber.ToString();
            txt_BankerCode.Text = account.AccountDetails.BankerNationalCode.ToString();
            txt_BranchCode.Text = account.AccountDetails.Branchcode.ToString();
            txt_CardNum.Text = account.AccountDetails.Cardnumber.ToString();
            txt_Sheba.Text = account.AccountDetails.Shebaaccountnumber.ToString();
            txt_FirstPass.Text = account.AccountDetails.Firstpass.ToString();
            txt_SecondPass.Text = account.AccountDetails.Secondpass.ToString();
            if (account.AccountDetails.AccountType == 1 )
            {
                combo_acctype.SelectedItem = "saving";
            }else combo_acctype.SelectedItem = "current";
            txt_OpeningDate.Text = account.AccountDetails.AccountOpenningDate.ToString();
            txt_Profit.Text = account.AccountDetails.ProfitPercentage.ToString();
            txt_Balance.Text = account.AccountDetails.Balance.ToString();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            //address****************
            Address address = new Address();
            address.City = txt_city.Text;
            address.Street = txt_street.Text;
            address.Info = txt_info.Text;
            address.Code_Posti = txt_zip.Text;
            database.addAddress(address);
            //**************************************

            //customer**********************************
            CustomerDetails customer = new CustomerDetails();
            customer.Fname = txt_FName.Text;
            customer.Lname = txt_LName.Text;
            customer.FatherName = txt_FatherName.Text;
            customer.Birthdate = txt_BirthDate.Text;
            customer.NationalCode = txt_CustomerNational.Text;
            customer.PhoneNumber = txt_PhoneNum.Text;
            customer.Address_Id = address.Id;
            customer.Education = txt_Education.Text;
            customer.Job = txt_Job.Text;
            if (combo_gender.SelectedText == "male")
            {
                customer.Gender = true;
            }
            else customer.Gender = false;
            database.addCustomer(customer);
            //****************************************

            //acount*************************************************
            AccountDetails details = new AccountDetails();
            BankerDetails banker = new BankerDetails();
            BranchDetails branch = new BranchDetails();
            Account account = new Account(details,customer,banker,branch);
            DatabaseResult data = database.addAccount(details);
            if (data.Result)
            {
                MessageBox.Show("Account Opened Successfully :)");
                this.Close();
            }
            else MessageBox.Show(data.Error, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
