using BankMekllat.controller;
using BankMekllat.datamodels;
using BankMekllat.model;
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
    public partial class EditBanker : Form
    {
        
        public EditBanker(Banker banker)
        {
            InitializeComponent();
            txt_national.Text = banker.BankerDetails.NationalCode;
            txt_fname.Text = banker.BankerDetails.Fname;
            txt_lname.Text = banker.BankerDetails.Lname;
            txt_fathername.Text = banker.BankerDetails.Fathername;
            txt_phonenumber.Text = banker.BankerDetails.PhoneNumber;
            if (banker.BankerDetails.Gender)
            {
                combo_gender.SelectedIndex = 0;
            }
            else combo_gender.SelectedIndex = 1;
            date.Text = banker.BankerDetails.Birthdate;
            txt_education.Text = banker.BankerDetails.Education;
            txt_branchcode.Text = banker.BankerDetails.Branchcode.ToString();

            combo_position.SelectedIndex = banker.BankerDetails.Position;

            txt_zipcode.Text = banker.Address.Code_Posti;
            txt_street.Text = banker.Address.Street;
            txt_city.Text = banker.Address.City;
            txt_other.Text = banker.Address.Info;

        }

        private void EditBanker_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm form = new HomeForm();
            form.Show();
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            BankerDetails banker = new BankerDetails(txt_national.Text, Convert.ToInt32(txt_branchcode.Text), txt_zipcode.Text,
                combo_position.SelectedIndex, txt_fname.Text, date.Value.ToString("yyyy-MM-dd"), txt_lname.Text, txt_fathername.Text,
                txt_education.Text, combo_gender.SelectedIndex == 0, txt_phonenumber.Text);
            Address address = new Address(txt_zipcode.Text, txt_city.Text, txt_street.Text, txt_other.Text);
            DatabaseResult result = DatabaseManager.getInstance().updateBanker(banker);
            if (result.Result)
            {
                result = DatabaseManager.getInstance().updateAddress(address);
                if (result.Result)
                {
                    MessageBox.Show("The Edit Process has been successfully");
                }else MessageBox.Show(result.Message, "The process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show(result.Message, "The process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
