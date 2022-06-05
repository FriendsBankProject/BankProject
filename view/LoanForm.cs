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
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            LoanDetails loan = new LoanDetails(Convert.ToInt32(LoanNumber_txt.Text), LoanGurantorCode_txt.Text
                               , BorrowerNationalCode_txt.Text, long.Parse(Amount_txt.Text), DueDate_txt.Text, BankerNationalCode_txt.Text);


            result = databaseManager.addLoan(loan);
            if (!result.Result)
            {
                MessageBox.Show(result.Message, "error while adding loan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("loan submited successfully :)");
            }
        }

        private void LoanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm form = new HomeForm();
            form.Show();
        }
    }
}
