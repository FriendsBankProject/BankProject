using System;
using System.Windows.Forms;
using BankMekllat.datamodels;
using BankMekllat.controller;
using System.Collections.Generic;
using BankMekllat.model;


namespace BankMekllat.view
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            datamodels.Transaction transaction = new datamodels.Transaction(Convert.ToInt16(txt_transnum.Text), txt_national.Text,
                txt_accountno.Text, Convert.ToInt64(txt_amount.Text), txt_destination.Text);
            result = databaseManager.addTransaction(transaction);
            if (result.Result)
            {
                List<Account> accounts;
                accounts = databaseManager.GetAccounts();
                foreach (Account account in accounts)
                {
                    if (account.AccountDetails.AccountNumber == transaction.AccountNumber)
                    {
                        foreach (Account account1 in accounts)
                        {
                            if (transaction.DestenationCardNumber == account1.AccountDetails.AccountNumber)
                            {
                                account1.AccountDetails.Balance += transaction.TransactionAmount;
                                account.AccountDetails.Balance -= transaction.TransactionAmount;
                            }
                            else account.AccountDetails.Balance -= transaction.TransactionAmount;
                            result =  databaseManager.updateAccount(account.AccountDetails);
                            if (result.Result) 
                            {
                                MessageBox.Show("The Transaction has done successfully...");
                            }
                            else MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                        
                    }
                    else MessageBox.Show("the account does'nt exist ");                 
                }
            }
            else MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
