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

            Address address = new Address(code_posti_txt.Text, City_txt.Text, street_txt.Text, info_txt.Text);
            result = databaseManager.addAddress(address);
            if (!result.Result)
            {
                MessageBox.Show(result.Error, "error while adding address", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int position;
                if (combo_Position.SelectedText == "Boss")
                {
                    position = 0;
                }
                else position = 1;
                BankerDetails bankerDetails = new BankerDetails(txt_National.Text, Convert.ToInt16(txt_Branch.Text), code_posti_txt.Text,
                    position, txt_Fname.Text, birthDate.Value.ToString("yyyy-MM-dd"), txt_Lname.Text, txt_Father.Text,
                    txt_Education.Text, combo_Gender.SelectedText == "Male", txt_Phone.Text);

                result = databaseManager.addBanker(bankerDetails);
                if (result.Result)
                {
                    MessageBox.Show("Banker Added Successfully  ");
                   
                }
                else
                {
                    databaseManager.deleteAddress(code_posti_txt.Text);
                    MessageBox.Show(result.Error, "error while adding banker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Add_Banker_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm form = new HomeForm();
            form.Show();
        }
    }
}
