
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using BankMekllat.datamodels;
using BankMekllat.model;

namespace BankMekllat.controller
{
    class DatabaseManager
    {
        private MySqlConnection conn;
        private string database = "Bank_Mellat";
        private string host = "localhost";
        private int port = 3306;
        private static DatabaseManager databaseManager;
        private DatabaseManager() { }

        public static DatabaseManager getInstance()
        {
            if (databaseManager == null)
            {
                databaseManager = new DatabaseManager();
            }
            return databaseManager;
        }

        public DatabaseResult connect(string user,string pass)
        {
            string connString = "Server=" + host + ";database="
                + database + ";port=" + port + ";User Id=" + user
                + ";password=" + pass;
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        //address *************************************

        public DatabaseResult addAddress(Address address)
        {
            string sql = "insert into address(city,street,info,code_posti) values('" + address.City + "','" + address.Street + "','" + address.Info + "','" + address.Code_Posti + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }

        }

        public DatabaseResult updateAddress(Address address)
        {
            string sql = "update address set city='" + address.City + "',street='" + address.Street + "',info='" + address.Info + "',code_posti='" + address.Code_Posti + "' where id=" + address.Id.ToString();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }

        }

        public DatabaseResult deleteAddress(int id)
        {
            string sql = "delete from address where id=" + id.ToString();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }


        //address  ************************************


        //branch *****************************
        public DatabaseResult addBranch(BranchDetails branch)
        {
            string sql = "insert into branch values('" + branch.Branchcode + "','" + branch.Address_Id + "','" + branch.Branchname + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }


        public DatabaseResult updateBranch(BranchDetails branch)
        {
            string sql = "update branch set address_id='" + branch.Address_Id +
                "',branchname ='" + branch.Branchname + "' where branchcode= '"
                +branch.Branchcode+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult deleteBranch(string branchcode)
        {
            string sql = "delete from branch where branchcode= '" + branchcode + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public List<Branch>  GetBranches()
        {
            string sql = "select branch.branchcode , branch.branchname , address.* from branch left join address on " +
                "branch.address_id=address.id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Branch> branchs = new List<Branch>();
                while (reader.Read())
                {
                    BranchDetails branchDetails = new BranchDetails();
                    
                    Address address = new Address();

                    branchDetails.Branchcode = reader.GetString(0);
                    branchDetails.Branchname = reader.GetString(1);

                    address.Id = reader.GetInt32(2);
                    address.City = reader.GetString(3);
                    address.Street = reader.GetString(4);
                    address.Info = reader.GetString(5);
                    address.Code_Posti = reader.GetString(6);

                    branchs.Add(new Branch(branchDetails, address));

                    
                }
                conn.Close();
                return branchs;
                
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
        // branch *******************************************

        public DatabaseResult addBanker(Banker banker)
        {
            short gender;
            if (banker.Gender)
            {
                gender = 1;
            }
            else gender = 0;
            string sql = "insert into banker values('" + banker.NationalCode + "','" + banker.Branchcode +
                "','" + banker.Address_Id+"','"+banker.Position+"','"+banker.Fname+"','"+banker.Lname+"','"+ banker.Birthdate
                + "','"+ banker.Fathername+"','"+banker.Education+"',"+gender+",'"+banker.PhoneNumber+ "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateBanker(Banker banker)
        {
            short gender;
            if (banker.Gender)
            {
                gender = 1;
            }
            else gender = 0;
            string sql = "update banker set branchcode='" + banker.Branchcode +
                "',address_id='" + banker.Address_Id + "',position='" + banker.Position + "',fname='" + banker.Fname + "',lname='" + banker.Lname + 
                "',birthdate='" + banker.Birthdate
                + "',fathername='" + banker.Fathername + "',education='" + banker.Education + "',gender=" + gender + ",phonenumber='" + banker.PhoneNumber +
                "' where nationalcode='"+banker.NationalCode+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult deleteBanker(string nationalcode)
        {
            string sql = "delete from banker where nationalcode='" + nationalcode + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        // banker ******************************************

        public DatabaseResult addCustomer(Customer customer)
        {
            short gender;
            if (customer.Gender)
            {
                gender = 1;
            } else gender = 0;
            string sql = "insert into customer values('" + customer.NationalCode + "','" + customer.Address_Id +
                "','" + customer.Fname + "','" + customer.Lname + "','" + customer.Birthdate + "','" + customer.FatherName +
                "','" + customer.Education + "','" + customer.Job + "'," + gender + ",'" + customer.PhoneNumber + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateCustomer(Customer customer)
        {
            short gender;
            if (customer.Gender)
            {
                gender = 1;
            }
            else gender = 0;
            string sql = "update customer set address_id='" + customer.Address_Id + "',fname='" + customer.Fname +
                "',lastname='" + customer.Lname + "',birthdate='" + customer.Birthdate + "',fathername='" + customer.FatherName +
                "',education='" + customer.Education + "',job='" + customer.Job + "',gender=" + gender + ",phonenumber=" + customer.PhoneNumber
                + " where nationalcode='" + customer.NationalCode + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult deleteCustomer(string nationalcode)
        {
            string sql = "delete from customer where nationalcode='" + nationalcode + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }
        // customer *******************************************
        // check *******************************************
        public DatabaseResult addCheck(Check check)
        {
            string sql = "insert into _check values ('" + check.CheckNumber + "','" + check.BranchCode + "','" +
                check.AccountNumber + "','" + check.CustomerNationalCode + "','" + check.ShebaAccountNumber + "','" +
                check.CheckDate + "'," + check.Amount.ToString() + ",'" + check.ReciverName + "','" + check.ReciverNationalNumber + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateCheck(Check check)
        {
            string sql = "update _check set branchcode='" + check.BranchCode + "',accountnumber='" + check.AccountNumber +
                "',customernationalcode='" + check.CustomerNationalCode + "',shebaaccountnumber='" + check.ShebaAccountNumber +
                "',checkdate='" + check.CheckDate + "',amount=" + check.Amount.ToString() + ",recivername='" + check.ReciverName +
                "',recivernationalnumber='" + check.ReciverNationalNumber + "' where checknumber='" + check.CheckNumber + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult deleteCheck(string checknumber)
        {
            string sql = "delete from _check where checknumber='" + checknumber + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }
        //check ******************************************

       
        // loan ********************************************
        public DatabaseResult addLoan(Loan loan)
        {
            string sql = "insert into loan values(" + loan.LoanNumber.ToString() + ",'" + loan.LoanGaruntor + "','" +
                loan.BorrowerNationalCode + "'," + loan.LoanAmount.ToString() + ",'" + loan.DueDate.ToString() + "','" +
                loan.BankerNationalCode + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateLoan(Loan loan)
        {
            string sql = "update loan set loanguarantor='" + loan.LoanGaruntor + "',borrowernationalcode='" +
                loan.BorrowerNationalCode + "',loanamount=" + loan.LoanAmount.ToString() + ",duedate='" + loan.DueDate.ToString() + 
                "',bankernationalcode='" + loan.BankerNationalCode + "' where loannumber ='"+loan.LoanNumber.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult deleteLoan(int loannumber)
        {
            string sql = "delete from loan where loannumber='" + loannumber.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        // loan *******************************

        //transaction *******************************
        public DatabaseResult addTransaction(Transaction transaction)
        {
            string sql = "insert into transaction values('" + transaction.TransactionNumber.ToString() + "','" + transaction.CustomerNationalCode + "','" +
                transaction.AccountNumber + "','" + transaction.TransactionType + "','" + transaction.TransactionAmount + "','" +
                transaction.TransactionDate+"','"+transaction.DestenationCardNumber + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateTransaction(Transaction transaction)
        {
            string sql = "update transaction set customernationalcode='" + transaction.CustomerNationalCode + "',accountnumber='" +
                transaction.AccountNumber + "',transactionamount='" + transaction.TransactionAmount.ToString() + "',transactiondate='" + transaction.TransactionDate +
                "',destinationcardnumber='" + transaction.DestenationCardNumber + "' where transactionnumber ='" + transaction.TransactionNumber.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult deleteTransaction(int transactionnumber)
        {
            string sql = "delete from transaction where transactionnumber='" + transactionnumber.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }
        // transaction ************************

        //account *******************************
        public DatabaseResult addAccount(Account account)
        {
            string sql = "insert into account values('" + account.AccountNumber + "','" + account.BankerNationalCode + "','" +
                account.CustomerNationalCode + "','" + account.Branchcode + "','" + account.Cardnumber + "','" +
                account.Shebaaccountnumber+ "','" + account.Firstpass+"','" +account.Secondpass+"','"+account.AccountType.ToString()
                +"','"+account.AccountOpenningDate+"','"+account.ProfitPercentage.ToString()+"','"+account.Balance+ "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateAccount(Account account)
        {
            string sql = "update account set bankernationalcode='"+ account.BankerNationalCode + "',customernationalcode='" +
                 account.CustomerNationalCode + "',branchcode='" + account.Branchcode + "',cardnumber='" + account.Cardnumber + "',shebaaccountnumber='" +
                 account.Shebaaccountnumber + "',firstpassword='" + account.Firstpass + "',secondpassword='" + account.Secondpass + "',balance='" + account.Balance + 
                 "' where accountnumber ='"+account.AccountNumber+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult deleteAccount(string accountnumber)
        {
            string sql = "delete from account where accountnumber='" + accountnumber + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                return new DatabaseResult(false, ex.Message);
            }
        }
        // account ************************
    }
}
