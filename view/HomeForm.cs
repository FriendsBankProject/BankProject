

using BankMekllat.controller;
using BankMekllat.datamodels;
using BankMekllat.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankMekllat.view
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            DatabaseManager database = DatabaseManager.getInstance();
            List<Branch> branches = database.GetBranches();
             foreach(Branch branch in branches){
                branches_list.Items.Add(branch.ToString());
            }
        }
    }
}
