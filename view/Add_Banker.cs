using System;
using System.Windows.Forms;
using BankMekllat.controller;
using BankMekllat.datamodels;

namespace BankMekllat.view
{
    public partial class Add_Banker : Form
    {
        public Add_Banker()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DatabaseResult result;
            DatabaseManager databaseManager = DatabaseManager.getInstance();
            int position;
            if (combo_Position.SelectedText == "Boss")
            {
                position = 0;
            }
            else position = 1;
            BankerDetails bankerDetails = new BankerDetails(txt_National.Text,Convert.ToInt16(txt_Branch.Text),txt_Codeposti.Text,
                position,txt_Fname.Text,txt_Birth.Text,txt_Lname.Text,txt_Father.Text,
                txt_Education.Text,combo_Gender.SelectedText == "Male",txt_Phone.Text);

            result = databaseManager.addBanker(bankerDetails);
            if (result.Result)
            {
                MessageBox.Show("Banker Added Successfully  ");

            }
            else
            {
                MessageBox.Show(result.Error, "error while adding banker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
