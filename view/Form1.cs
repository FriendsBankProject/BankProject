using BankMekllat.controller;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            DatabaseManager manager = DatabaseManager.getInstance();
            manager.connect("1380saeed.");
           DatabaseResult result = manager.deleteCheck("144");
            button1.Text = result.Result.ToString();
            MessageBox.Show(result.Error);
        }
    }
}
