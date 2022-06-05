using BankMekllat.controller;
using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMekllat.view
{
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            InitializeComponent();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            Address address = new Address(code_posti_txt.Text,City_txt.Text,street_txt.Text,info_txt.Text);
           result = databaseManager.addAddress(address);
            if (!result.Result)
            {
                MessageBox.Show(result.Error, "error while adding address", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                CustomerDetails customer = new CustomerDetails(txt_CustomerNational.Text, code_posti_txt.Text, txt_FName.Text,
                    txt_LName.Text, birthDate.Value.ToString("yyyy-MM-dd"), txt_FatherName.Text, txt_Education.Text, txt_Job.Text, combo_gender.SelectedIndex == 0, txt_PhoneNum.Text);
                 
                result = databaseManager.addCustomer(customer);
                if (!result.Result)
                {
                    databaseManager.deleteAddress(code_posti_txt.Text);
                    MessageBox.Show(result.Error, "error while adding customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    int type;
                    if (txt_AccType.Text == "current")
                    {
                        type = 0;
                    }
                    else type = 1;
                    AccountDetails accountDetails = new AccountDetails(txt_AccountNum.Text, txt_BankerCode.Text, txt_CustomerNational.Text,
                        Convert.ToInt32(txt_BranchCode.Text), txt_CardNum.Text, txt_Sheba.Text, txt_FirstPass.Text, txt_SecondPass.Text
                        , type, DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"), Convert.ToInt32(txt_Profit.Text), long.Parse(txt_Balance.Text));
                    result = databaseManager.addAccount(accountDetails);
                    if (!result.Result)
                    {
                        databaseManager.deleteCustomer(txt_CustomerNational.Text);
                        databaseManager.deleteAddress(code_posti_txt.Text);
                        MessageBox.Show(result.Error, "error while adding customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else MessageBox.Show("all done ");
                }
            }
        }

        private void Add_Account_FormClosed(object sender, FormClosedEventArgs e)
        {

            HomeForm form = new HomeForm();
            form.Show();
        }
    }
}
