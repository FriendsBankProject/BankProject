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
            Banker banker = new Banker();
            banker.Fname = "mahammgsad";
            banker.Lname = "mahammagssgdi";
            banker.Fathername = "asghargs";
            banker.Branchcode = "1234";
            banker.Address_Id = 2;
            banker.Birthdate = new DateTime(2022, 2, 3).ToString("yyyy-MM-dd");
            banker.Education = "diploma";
            banker.Gender = true;
            banker.NationalCode = "3980395466";
            banker.PhoneNumber = "09189279189";
            banker.Position = 0;
           DatabaseResult dr = database.deleteBanker("3980395468");
            button1.Text = dr.Result.ToString();
            MessageBox.Show(dr.Error);
        }
    }
}
