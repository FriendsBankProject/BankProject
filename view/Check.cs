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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            CheckDetails check = new CheckDetails(CheckNumber_txt.Text, BranchCode_txt.Text, AccountNumber_txt.Text
                , CustomerNationalNumber_txt.Text, CheckDate.Value.ToString("yyyy-MM-dd"), long.Parse(Amount_txt.Text),
                ReciverName_txt.Text, ReciverNationalNumber_txt.Text);

            result = databaseManager.addCheck(check);
            if (!result.Result)
            {
                MessageBox.Show(result.Error, "error while adding check", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               MessageBox.Show("check submited successfully :)");
            }

        }

        private void Check_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm form = new HomeForm();
            form.Show();
        }
    }
}
