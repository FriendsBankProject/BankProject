using BankMekllat.controller;
using BankMekllat.datamodels;
using System;
using System.Windows.Forms;

namespace BankMekllat.view
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }
        private void Btn_submit_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            CustomerDetails customer = databaseManager.GetCustomerByCardNumber(destination_txt.Text);
            Transaction transaction = new Transaction(0, accountno_txt.Text,
                    long.Parse(amount_txt.Text), DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"), destination_txt.Text);
            if (customer == null)
            {
              DialogResult dialog =  MessageBox.Show("We cant find a customer with entered card number in this bank customers list.\n" +
                    "Do you want to continue?", "no customer in Mellat bank", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog==DialogResult.Yes)
                {
                    result = databaseManager.DecreaseBlance(accountno_txt.Text, long.Parse(amount_txt.Text));
                    if (result.Result)
                    { 
                    

                    result = databaseManager.addTransaction(transaction);
                    if (!result.Result)
                    {
                        MessageBox.Show(result.Message, "error while adding transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                       
                        MessageBox.Show("transaction submited successfully :)\n"+result.Message);
                    }
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "error while adding transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    }

                    
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(customer.Fname +"\t"+ customer.Lname + "\n Are you sure to continiue?",
                    "Customer name", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    result = databaseManager.DecreaseBlance(accountno_txt.Text, long.Parse(amount_txt.Text));
                    if (result.Result)
                    {
                        result = databaseManager.IncreaseBlance(destination_txt.Text, long.Parse(amount_txt.Text));
                        if (result.Result)
                        {
                            result = databaseManager.addTransaction(transaction);
                            if (result.Result)
                            {
                                 MessageBox.Show("Transaction submited successfully :)+\n\n"+result.Message);
                            }
                            else MessageBox.Show(result.Message, "error while adding transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else MessageBox.Show(result.Message, "error while adding transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else MessageBox.Show(result.Message, "error while adding transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm form = new HomeForm();
            form.Show();
        }

        
    }
}
