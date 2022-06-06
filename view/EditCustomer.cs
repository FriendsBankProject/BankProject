using System.Windows.Forms;
using BankMekllat.model;
using BankMekllat.datamodels;
using BankMekllat.controller;


namespace BankMekllat.view
{
    public partial class EditCustomer : Form
    {
        DatabaseResult result, result1;
        DatabaseManager databaseManager = DatabaseManager.getInstance();
        
        public EditCustomer(string nationalCode, string code_Posti, string fname, string lname, string birthdate, string fatherName
             , string education, string job, bool gender, string phoneNumber, string city, string street, string info)
        {
            InitializeComponent();
            national_txt.Text = nationalCode;
            txt_fname.Text = fname;
            txt_lname.Text = lname;
            txt_fathername.Text = fatherName;
            txt_phonenumber.Text = phoneNumber;
            date.Text = birthdate;
            txt_education.Text = education;
            txt_job.Text = job;
            if (gender)
            {
                combo_gender.SelectedIndex = 0;
            }
            else combo_gender.SelectedIndex = 1;
            txt_zipcode.Text = code_Posti;
            txt_city.Text = city;
            txt_street.Text = street;
            txt_other.Text = info;
        }

        private void EditCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseManager.getInstance().FormIsRunning = false;
            HomeForm form = new HomeForm();
            form.Show();
        }

        private void btn_submit_Click(object sender, System.EventArgs e)
        {
            bool gender;
            if (combo_gender.SelectedText == "Male")
            {
                gender = true;
            } else gender = false;

            CustomerDetails customerDetails = new CustomerDetails(national_txt.Text, txt_zipcode.Text, txt_fname.Text, txt_lname.Text,
                date.Value.ToString("yyyy-MM-dd"), txt_fathername.Text, txt_education.Text, txt_job.Text, gender, txt_phonenumber.Text);
            Address address = new Address(txt_zipcode.Text, txt_city.Text, txt_street.Text, txt_other.Text);
            result = databaseManager.updateCustomer(customerDetails);
            result1 = databaseManager.updateAddress(address);
            if (result.Result && result1.Result)
            {
      
                MessageBox.Show("The Edit Process has been successfully");
            }
            else MessageBox.Show(result.Message, "The process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
