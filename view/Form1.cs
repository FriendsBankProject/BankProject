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

           private void Login_btn_Click(object sender, EventArgs e)
        {
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            DatabaseResult result = databaseManager.connect("root", "1380saeed.");
            if (result.Result)
            {
                MessageBox.Show("ok");
                HomeForm home = new HomeForm();
               
                home.Show();
                this.Hide();

            }
            else MessageBox.Show(result.Error, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
