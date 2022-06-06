using System;
using System.Windows.Forms;
using BankMekllat.controller;
using BankMekllat.datamodels;

namespace BankMekllat.view
{
    public partial class Add_BranchForm : Form
    {
        public Add_BranchForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            Address address = new Address(code_posti_txt.Text, City_txt.Text, street_txt.Text, info_txt.Text);
            result = databaseManager.addAddress(address);
            if (!result.Result)
            {
                MessageBox.Show(result.Message, "error while adding address", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
              BranchDetails branchDetails = new BranchDetails(txt_branchcode.Text,code_posti_txt.Text,txt_branchname.Text);
            result = databaseManager.addBranch(branchDetails);
            if (result.Result)
            {
                MessageBox.Show("Done :)");
              
            }
            else
                {
                    databaseManager.deleteAddress(code_posti_txt.Text);
                    MessageBox.Show(result.Message, "error while adding branch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

        }

        private void Add_Branch_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
