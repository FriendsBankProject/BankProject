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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DatabaseManager manager = DatabaseManager.getInstance();
            manager.connect("1380saeed.");
            Account account = new Account();
            account.AccountNumber = "1234588";
            account.AccountOpenningDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            account.AccountType = 0;
            account.Balance = 10002546;
            account.BankerNationalCode = "3980395466";
            account.Branchcode = "1234";
            account.Cardnumber = "13546465";
            account.CustomerNationalCode = "3991005217";
            account.Firstpass = "1234";
            account.Secondpass = "156";
            account.Shebaaccountnumber = "465764";
           



            DatabaseResult result = manager.deleteAccount("1234588");
            button1.Text = result.Result.ToString();
            MessageBox.Show(result.Error);
        }
    }
}
