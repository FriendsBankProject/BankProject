using System;
using System.Windows.Forms;
using BankMekllat.datamodels;
using BankMekllat.controller;


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
            Transaction transaction = new Transaction();
        }
    }
}
