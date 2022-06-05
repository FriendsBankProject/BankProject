using System;
using System.Windows.Forms;
using BankMekllat.controller;
using BankMekllat.datamodels;

namespace BankMekllat.view
{
    public partial class Add_Branch : Form
    {
        public Add_Branch()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            BranchDetails branchDetails = new BranchDetails(txt_branchcode.Text,txt_branchzip.Text,txt_branchname.Text);
            result = databaseManager.addBranch(branchDetails);
            if (result.Result)
            {
                MessageBox.Show("Done :)");
            }
            else MessageBox.Show(result.Error, "error while adding branch", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
