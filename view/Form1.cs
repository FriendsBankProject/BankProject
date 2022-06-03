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

namespace BankMekllat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DatabaseManager database = DatabaseManager.getInstance();
            database.connect("1380saeed.");
            Check check = new Check();
            check.CheckNumber = "144";
            check.CustomerNationalCode = "3991005217";
            check.BranchCode = "1234";
            check.AccountNumber = "1246";
            check.CheckDate = new DateTime().ToString("yyyy-MM-dd");
            check.ReciverName = "mohammad hamed";
            check.ReciverNationalNumber = "3980395456";
            check.ShebaAccountNumber = "134546465";
            check.Amount = 12345000;
           DatabaseResult dr = database.updateCheck(check);
            button1.Text = dr.Result.ToString();
            MessageBox.Show(dr.Error);
        }
    }
}
