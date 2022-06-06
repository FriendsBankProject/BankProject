using BankMekllat.controller;
using BankMekllat.datamodels;
using BankMekllat.model;
using System;
using System.Windows.Forms;

namespace BankMekllat.view
{
    public partial class EditAccount : Form
    {
        
        public EditAccount(Account account)
        {
            InitializeComponent();

            txt_national.Text = account.Customer.NationalCode;
            txt_fname.Text = account.Customer.Fname;
            txt_lname.Text = account.Customer.Lname;
            txt_fathername.Text = account.Customer.FatherName;
            txt_phonenumber.Text = account.Customer.PhoneNumber;
            if (account.Customer.Gender)
            {
                combo_gender.SelectedIndex = 0;
            }
            else combo_gender.SelectedIndex = 1;
            date.Text = account.Customer.Birthdate;
            txt_education.Text = account.Customer.Education;
            txt_job.Text = account.Customer.Job;
            code_posti_txt.Text = account.Customer.Code_Posti;

            txt_AccountNum.Text = account.AccountDetails.AccountNumber;
            txt_BankerCode.Text = account.AccountDetails.BankerNationalCode;
            txt_BranchCode.Text = account.AccountDetails.Branchcode.ToString();
            txt_CardNum.Text = account.AccountDetails.Cardnumber;
            txt_Sheba.Text = account.AccountDetails.Shebaaccountnumber;
            txt_FirstPass.Text = account.AccountDetails.Firstpass;
            txt_SecondPass.Text = account.AccountDetails.Secondpass;
            txt_AccType.Text = account.AccountDetails.AccountType.ToString();
            txt_Balance.Text = account.AccountDetails.Balance.ToString();
            txt_Profit.Text = account.AccountDetails.ProfitPercentage.ToString();
            openingdate_txt.Text = account.AccountDetails.AccountOpenningDate;
            }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            AccountDetails account = new AccountDetails(txt_AccountNum.Text, txt_BankerCode.Text, txt_national.Text,
                Convert.ToInt32(txt_BranchCode.Text), txt_CardNum.Text, txt_Sheba.Text, txt_FirstPass.Text, txt_SecondPass.Text,
                Convert.ToInt32(txt_AccType.Text), null, Convert.ToInt32(txt_Profit.Text), 0);

            CustomerDetails customer = new CustomerDetails(txt_national.Text, code_posti_txt.Text,
                txt_fname.Text,txt_lname.Text, date.Value.ToString("yyyy-MM-dd"), txt_fathername.Text,
                txt_education.Text, txt_job.Text, combo_gender.SelectedIndex == 0, txt_phonenumber.Text);

            DatabaseResult result = DatabaseManager.getInstance().updateCustomer(customer);
            if (result.Result)
            {
                result = DatabaseManager.getInstance().updateAccount(account);
                if (result.Result)
                {
                    MessageBox.Show("The Edit Process has been successfully");
                }
                else MessageBox.Show(result.Message, "The process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(result.Message, "The process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm form = new HomeForm();
            form.Show();
        }

       
    }
}
