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
            Customer customer = new Customer();
            customer.Fname = "mahammgsad";
            customer.Lname = "mahammagssgdi";
            customer.FatherName = "asghargs";
            customer.Address_Id = 2;
            customer.Birthdate = new DateTime(2022, 2, 3).ToString("yyyy-MM-dd");
            customer.Education = "diploma";
            customer.Gender = true;
            customer.NationalCode = "3980395466";
            customer.PhoneNumber = "09189279189";
            customer.Job = "mechanic";
            customer.NationalCode = "3991005217";
           DatabaseResult dr = database.addCustomer(customer);
            button1.Text = dr.Result.ToString();
            MessageBox.Show(dr.Error);
        }
    }
}
