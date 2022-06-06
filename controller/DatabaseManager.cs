
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using BankMekllat.datamodels;
using BankMekllat.model;
using System.Windows.Forms;
using System;

namespace BankMekllat.controller
{
    class DatabaseManager
    {
        private Form mainForm;
        private bool formIsRunning;
        private MySqlConnection conn;
        private string database = "Bank_Mellat";
        private string host = "localhost";
        private int port = 3306;
        private static DatabaseManager databaseManager;

        public bool FormIsRunning { get => formIsRunning; set => formIsRunning = value; }

        private DatabaseManager() { }

        public static DatabaseManager getInstance()
        {
            if (databaseManager == null)
            {
                databaseManager = new DatabaseManager();
            }
            return databaseManager;
        }

        public DatabaseResult connect(Form mainForm,string user,string pass)
        {
            this.mainForm = mainForm;
            string connString = "Server=" + host + ";database="
                + database + ";port=" + port + ";User Id=" + user
                + ";password=" + pass + ";convert zero datetime=True";
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                conn.Close();
                return new DatabaseResult(true, "");
            }
            catch (MySqlException ex)
            {
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public void closeProgram()
        {
            mainForm.Close();
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }

        }

        public DatabaseResult updateAddress(Address address)
        {
            string sql = "update address set city='" + address.City + "',street='" + address.Street + "',info='" + address.Info + "' where code_posti='" + address.Code_Posti + "'";
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }

        }

        public DatabaseResult deleteAddress(string code_posti)
        {
            string sql = "delete from address where code_posti='" + code_posti + "'";
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

         public List<Address> GetAddresses()
        {
            string sql = "select * from address";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Address> addresses = new List<Address>();
                while (reader.Read())
                {
                    Address address = new Address();
                    address.Code_Posti = reader.GetString(0);
                    address.City = reader.GetString(1);
                    address.Street = reader.GetString(2);
                    address.Info = reader.GetString(3);

                    addresses.Add(address);
                }
                conn.Close();
                return addresses;
            }
            catch (MySqlException )
            {
                conn.Close();
                return null;
            }
        }

        //address  ************************************


        //branch *****************************
        public DatabaseResult addBranch(BranchDetails branch)
        {
            string sql = "insert into branch values('" + branch.Branchcode + "','" + branch.Code_Posti+ "','" + branch.Branchname + "')";
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }


        public DatabaseResult updateBranch(BranchDetails branch)
        {
            string sql = "update branch set address_id='" + branch.Code_Posti +
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
                conn.Close();
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public List<Branch>  GetBranches()
        {
            string sql = "select branch.branchcode , branch.branchname , address.* from branch left join address on " +
                "branch.code_posti=address.code_posti";
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

                    address.Code_Posti = reader.GetString(2);
                    address.City = reader.GetString(3);
                    address.Street = reader.GetString(4);
                    address.Info = reader.GetString(5);
                    

                    branchs.Add(new Branch(branchDetails, address));

                    
                }
                conn.Close();
                return branchs;
                
            }
            catch (MySqlException)
            {
                conn.Close();
                return null;
            }
        }
        // branch *******************************************

        public DatabaseResult addBanker(BankerDetails banker)
        {
            short gender;
            if (banker.Gender)
            {
                gender = 1;
            }
            else gender = 0;
            string sql = "insert into banker values('" + banker.NationalCode + "','" + banker.Branchcode +
                "','" + banker.Code_Posti+"','"+banker.Position+"','"+banker.Fname+"','"+banker.Lname+"','"+ banker.Birthdate
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateBanker(BankerDetails banker)
        {
            short gender;
            if (banker.Gender)
            {
                gender = 1;
            }
            else gender = 0;
            string sql = "update banker set branchcode='" + banker.Branchcode +
                "',address_id='" + banker.Code_Posti + "',position='" + banker.Position + "',fname='" + banker.Fname + "',lname='" + banker.Lname + 
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
                conn.Close();
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }


        public List<Banker> GetBankers()
        {
            string sql = "select banker.* , branch.branchcode , branch.branchname , address.* from banker , branch , address where" +
            " banker.code_posti=address.code_posti and banker.branchcode=branch.branchcode"; 
           
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    List<Banker> bankers = new List<Banker>();
                    while (reader.Read())
                    {
                    BankerDetails bankerDetails = new BankerDetails();
                        BranchDetails branchDetails = new BranchDetails();

                        Address address = new Address();

                    bankerDetails.NationalCode = reader.GetString(0);
                    bankerDetails.Branchcode = reader.GetInt32(1);
                    bankerDetails.Position = reader.GetInt32(3);
                    bankerDetails.Fname = reader.GetString(4);
                    bankerDetails.Lname = reader.GetString(5);
                    bankerDetails.Birthdate = reader.GetDateTime(6).ToString();
                    bankerDetails.Fathername = reader.GetString(7);
                    bankerDetails.Education = reader.GetString(8);
                    bankerDetails.Gender = reader.GetInt16(9) == 1;
                    bankerDetails.PhoneNumber = reader.GetString(10);


                        branchDetails.Branchcode = reader.GetString(11);
                        branchDetails.Branchname = reader.GetString(12);

                        address.Code_Posti = reader.GetString(13);
                        address.City = reader.GetString(14);
                        address.Street = reader.GetString(15);
                        address.Info = reader.GetString(16);
                        

                        bankers.Add(new Banker(bankerDetails, branchDetails, address));


                    }
                    conn.Close();
                    return bankers;

                }
                catch (MySqlException)
                {
                conn.Close();
                return null;
                }
            }
        

        // banker ******************************************

        public DatabaseResult addCustomer(CustomerDetails customer)
        {
            short gender;
            if (customer.Gender)
            {
                gender = 1;
            } else gender = 0;
            string sql = "insert into customer values('" + customer.NationalCode + "','" + customer.Code_Posti+
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateCustomer(CustomerDetails customer)
        {
            short gender;
            if (customer.Gender)
            {
                gender = 1;
            }
            else gender = 0;
            string sql = "update customer set address_id='" + customer.Code_Posti + "',fname='" + customer.Fname +
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
                conn.Close();
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public List<Customer> GetCustomers()
        {
            string sql = "select * from customer , address where customer.code_posti=address.code_posti";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Customer> customers = new List<Customer>();
                while (reader.Read())
                {
                  
                    Address address = new Address();
                    CustomerDetails customerDetails = new CustomerDetails();

                    customerDetails.NationalCode = reader.GetString(0);
                    customerDetails.Code_Posti = reader.GetString(1);
                    customerDetails.Fname = reader.GetString(2);
                    customerDetails.Lname = reader.GetString(3);
                    customerDetails.Birthdate = reader.GetDateTime(4).ToString();
                    customerDetails.FatherName = reader.GetString(5);
                    customerDetails.Education = reader.GetString(6);
                    customerDetails.Job = reader.GetString(7);
                    customerDetails.Gender = reader.GetInt16(8) == 1;
                    customerDetails.PhoneNumber = reader.GetString(9);

                    address.Code_Posti = reader.GetString(10);
                    address.City = reader.GetString(11);
                    address.Street = reader.GetString(12);
                    address.Info = reader.GetString(13);
                    

                    customers.Add(new Customer(customerDetails, address));


                }
                conn.Close();
                return customers;

            }
            catch (MySqlException)
            {
                conn.Close();
                return null;
            }
        }
        
        // customer *******************************************
        // check *******************************************
        public DatabaseResult addCheck(CheckDetails check)
        {
            string sql = "insert into _check values ('" + check.CheckNumber + "','" + check.BranchCode + "','" + check.CustomerNationalCode + "','"+
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateCheck(CheckDetails check)
        {
            string sql = "update _check set branchcode='" + check.BranchCode +"',customernationalcode='" + check.CustomerNationalCode +"',checkdate='" + check.CheckDate + "',amount=" + check.Amount.ToString() + ",recivername='" + check.ReciverName +
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
                conn.Close();
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public List<Check> GetChecks()
        {
            string sql = "select * from _check , customer , branch " +
                "where _check.BranchCode=branch.Branchcode and " +
                "_check.CustomerNationalCode=customer.NationalCode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Check> checks = new List<Check>();
                while (reader.Read())
                {

                    CheckDetails check = new CheckDetails();
                    CustomerDetails customer = new CustomerDetails();
                    BranchDetails branch = new BranchDetails();

                    check.CheckNumber = reader.GetString(0);
                    check.BranchCode = reader.GetString(1);
                    check.CustomerNationalCode = reader.GetString(2);
                    check.CheckDate = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                    check.Amount = reader.GetInt64(4);
                    check.ReciverName = reader.GetString(5);
                    check.ReciverNationalNumber = reader.GetString(6);

                    customer.NationalCode = reader.GetString(7);
                    customer.Code_Posti = reader.GetString(8);
                    customer.Fname = reader.GetString(9);
                    customer.Lname = reader.GetString(10);
                    customer.Birthdate = reader.GetDateTime(11).ToString();
                    customer.FatherName = reader.GetString(12);
                    customer.Education = reader.GetString(13);
                    customer.Job = reader.GetString(14);
                    customer.Gender = reader.GetInt16(15) == 1;
                    customer.PhoneNumber = reader.GetString(16);

                    branch.Branchcode = reader.GetString(17);
                    branch.Code_Posti = reader.GetString(18);
                    branch.Branchname = reader.GetString(19);

                    checks.Add(new Check(check, customer, branch));


                }
                conn.Close();
                return checks;

            }
            catch (MySqlException )
            {
                conn.Close();
                return null;
            }
        }
        //check ******************************************

       
        // loan ********************************************
        public DatabaseResult addLoan(LoanDetails loan)
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateLoan(LoanDetails loan)
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
                conn.Close();
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

       public List<Loan> GetLoans()
        {
            string sql = "select * from loan , customer as borrower , customer as gurantor , banker " +
                "where loan.BorrowerNationalCode=borrower.NationalCode and loan.LoanGuarantor= gurantor.NationalCode" +
                " and loan.BankerNationalCode=banker.NationalCode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Loan> loans = new List<Loan>();
                while (reader.Read())
                {

                    LoanDetails loan = new LoanDetails();
                    CustomerDetails borrower = new CustomerDetails();
                    CustomerDetails gurantor = new CustomerDetails();
                    BankerDetails banker = new BankerDetails();


                    loan.LoanNumber = reader.GetInt32(0);
                    loan.LoanAmount = reader.GetInt64(3);
                    loan.DueDate = reader.GetString(4);
                    

                    borrower.NationalCode = reader.GetString(6);
                    borrower.Code_Posti = reader.GetString(7);
                    borrower.Fname = reader.GetString(8);
                    borrower.Lname = reader.GetString(9);
                    borrower.Birthdate = reader.GetDateTime(10).ToString();
                    borrower.FatherName = reader.GetString(11);
                    borrower.Education = reader.GetString(12);
                    borrower.Job = reader.GetString(13);
                    borrower.Gender = reader.GetInt16(14) == 1;
                    borrower.PhoneNumber = reader.GetString(15);

                    gurantor.NationalCode = reader.GetString(16);
                    gurantor.Code_Posti = reader.GetString(17);
                    gurantor.Fname = reader.GetString(18);
                    gurantor.Lname = reader.GetString(19);
                    gurantor.Birthdate = reader.GetDateTime(20).ToString();
                    gurantor.FatherName = reader.GetString(21);
                    gurantor.Education = reader.GetString(22);
                    gurantor.Job = reader.GetString(23);
                    gurantor.Gender = reader.GetInt16(24) == 1;
                    gurantor.PhoneNumber = reader.GetString(25);

                    banker.NationalCode = reader.GetString(26);
                    banker.Branchcode = reader.GetInt32(27);
                    banker.Code_Posti = reader.GetString(28);
                    banker.Position = reader.GetInt32(29);
                    banker.Fname = reader.GetString(30);
                    banker.Lname = reader.GetString(31);
                    banker.Birthdate = reader.GetDateTime(32).ToString();
                    banker.Fathername = reader.GetString(33);
                    banker.Education = reader.GetString(34);
                    banker.Gender = reader.GetInt16(35) == 1;
                    banker.PhoneNumber = reader.GetString(36);

                    loans.Add(new Loan(loan, borrower, gurantor, banker));


                }
                conn.Close();
                return loans;

            }
            catch (MySqlException e)
            {
                conn.Close();
                return null;
            }
        }
        // loan *******************************

        //transaction *******************************
        public DatabaseResult addTransaction(TransactionDetails transaction)
        {
            string sql = "insert into transaction(accountnumber,transactionamount,transactiondate,destinationcardnumber) values('"  +
                transaction.AccountNumber + "','"  + transaction.TransactionAmount + "','" +
                transaction.TransactionDate+"','"+transaction.DestenationCardNumber + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                var r = cmd.ExecuteReader();
                conn.Close();
                return new DatabaseResult(true, getArrivalOfTransaction(transaction.AccountNumber,transaction.TransactionDate).Message);
            }
            catch (MySqlException ex)
            {
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateTransaction(TransactionDetails transaction)
        {
            string sql = "update transaction set accountnumber='" +
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

       public List<Transaction> GetTransactions()
        {
            string sql = "select transaction.* , sender.fname,sender.lname,reciver.fname,reciver.lname " +
                "from transaction join account as senderacc on transaction.AccountNumber=senderacc.AccountNumber " +
                "join customer as sender on senderacc.CustomerNationalCode=sender.NationalCode " +
                "left join account as reciveracc on transaction.DestinationCardNumber=reciveracc.cardnumber " +
                "left join customer as reciver on reciveracc.CustomerNationalCode=reciver.NationalCode";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Transaction> transactions = new List<Transaction>();

                while (reader.Read())
                {
                    TransactionDetails transaction = new TransactionDetails();
                    transaction.TransactionNumber = reader.GetInt32(0);
                    transaction.AccountNumber = reader.GetString(1);
                    transaction.TransactionAmount = reader.GetInt64(2);
                    transaction.TransactionDate = reader.GetDateTime(3).ToString("yyyy-MM-dd HH:mm:ss");
                    transaction.DestenationCardNumber = reader.GetString(4);

                    string sender = reader.GetString(5) + "  " + reader.GetString(6);
                    string reciver = "";

                    if (reader.GetValue(7) != DBNull.Value)
                    {
                        reciver = reader.GetString(7) + "  " + reader.GetString(8);
                    }
                    else reciver = "other bank";
                     

                    transactions.Add(new Transaction(transaction, sender, reciver));
                }
                conn.Close();
                return transactions;

            }
            catch (MySqlException e)
            {
                conn.Close();
                return null;
            }
        }

        public CustomerDetails GetCustomerByCardNumber(string cardNumber)
        {
            string sql = "select nationalcode,fname,lname from customer join account " +
                "on customer.nationalcode=account.customernationalcode and account.cardnumber='" + cardNumber + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                CustomerDetails customer = new CustomerDetails();
                customer.NationalCode = reader.GetString(0);
                customer.Fname = reader.GetString(1);
                customer.Lname = reader.GetString(2);
                
                conn.Close();
                return customer;
            }
            catch (MySqlException)
            {
                conn.Close();
                return null;
            }
        }
        public DatabaseResult getBalance(string accountnumber)
        {
            string sql = "select balance from account where accountnumber='" + accountnumber + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                long balance = (long)cmd.ExecuteScalar();
                conn.Close();
                return new DatabaseResult(true, balance.ToString());
            }
            catch (MySqlException ex)
            {
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }
        public DatabaseResult DecreaseBlance(string accountnumber,long amount)
        {
            DatabaseResult balanceResult = getBalance(accountnumber);
            if (balanceResult.Result)
            {
                long balance = long.Parse(balanceResult.Message);
                if (balance - amount >= 5000)
                {
                     string sql = "update account set balance = balance -'" + amount.ToString() +
                "' where accountnumber='" + accountnumber + "'";
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
                        conn.Close();
                        return new DatabaseResult(false, ex.Message);
                    }
                }
                else
                {
                    return new DatabaseResult(false, "there is no enogh balance!!");
                }
            }
            else
            {
                return balanceResult;
            }
            
        }

        public DatabaseResult IncreaseBlance(string cardNumber, long amount)
        {
            
         string sql = "update account set balance = balance +'" + amount.ToString() +
               "' where cardnumber='" + cardNumber + "'";
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
                        conn.Close();
                        return new DatabaseResult(false, ex.Message);
                    }
               
        }

        public DatabaseResult getArrivalOfTransaction(string accountNumber , string date)
        {
            string sql = "select transaction.*,customer.fname,customer.lname from transaction,customer,account " +
                " where transaction.accountnumber='" + accountNumber + "' and transaction.transactiondate='" + date +
                "' and transaction.accountnumber=account.accountnumber and account.customernationalcode=customer.nationalcode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string result = "";
                result += "transaction number :" + reader.GetInt32(0).ToString();
                result += "\naccount number :" + reader.GetString(1);
                result += "\n" + reader.GetString(5) + "  " + reader.GetString(6);
                result += "\nammount :" + reader.GetInt64(2);
                result += "\ndate :" + reader.GetDateTime(3).ToString("yyyy-MM-dd HH:mm:ss");
                result += "\ndestination card number :" + reader.GetString(4);

                conn.Close();
                return new DatabaseResult(true, result);
            }
            catch (MySqlException ex)
            {
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }
        // transaction ************************

        //account *******************************
        public DatabaseResult addAccount(AccountDetails account)
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public DatabaseResult updateAccount(AccountDetails account)
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
                conn.Close();
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
                conn.Close();
                return new DatabaseResult(false, ex.Message);
            }
        }

        public List<Account> GetAccounts()
        {
            string sql = "select distinct account.* , banker.* ,customer.* , branch.branchcode , branch.branchname from account , banker ,customer, branch , address where" +
           " account.bankernationalcode=banker.nationalcode and account.branchcode=branch.branchcode and account.customernationalcode=customer.nationalcode";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Account> accounts = new List<Account>();
                while (reader.Read())
                {
                    AccountDetails accountDetails = new AccountDetails();
                    BankerDetails bankerDetails = new BankerDetails();
                    BranchDetails branchDetails = new BranchDetails();
                    CustomerDetails customerDetails = new CustomerDetails();


                    accountDetails.AccountNumber = reader.GetString(0);
                    accountDetails.BankerNationalCode = reader.GetString(1);
                    accountDetails.CustomerNationalCode = reader.GetString(2);
                    accountDetails.Branchcode = reader.GetInt32(3);
                    accountDetails.Cardnumber = reader.GetString(4);
                    accountDetails.Shebaaccountnumber = reader.GetString(5);
                    accountDetails.Firstpass = reader.GetString(6);
                    accountDetails.Secondpass = reader.GetString(7);
                    accountDetails.AccountType = reader.GetInt32(8);
                    accountDetails.AccountOpenningDate = reader.GetDateTime(9).ToString();
                    accountDetails.ProfitPercentage = reader.GetInt32(10);
                    accountDetails.Balance = reader.GetInt64(11);

                    bankerDetails.NationalCode = reader.GetString(12);
                    bankerDetails.Branchcode = reader.GetInt32(13);
                    bankerDetails.Code_Posti = reader.GetString(14);
                    bankerDetails.Position = reader.GetInt32(15);
                    bankerDetails.Fname = reader.GetString(16);
                    bankerDetails.Lname = reader.GetString(17);
                    bankerDetails.Birthdate = reader.GetDateTime(18).ToString();
                    bankerDetails.Fathername = reader.GetString(19);
                    bankerDetails.Education = reader.GetString(20);
                    bankerDetails.Gender = reader.GetInt16(21) == 1;
                    bankerDetails.PhoneNumber = reader.GetString(22);

                    customerDetails.NationalCode = reader.GetString(23);
                    customerDetails.Code_Posti = reader.GetString(24);
                    customerDetails.Fname = reader.GetString(25);
                    customerDetails.Lname = reader.GetString(26);
                    customerDetails.Birthdate = reader.GetDateTime(27).ToString();
                    customerDetails.FatherName = reader.GetString(28);
                    customerDetails.Education = reader.GetString(29);
                    customerDetails.Job = reader.GetString(30);
                    customerDetails.Gender = reader.GetInt16(31) == 1;
                    customerDetails.PhoneNumber = reader.GetString(32);


                    branchDetails.Branchcode = reader.GetString(33);
                    branchDetails.Branchname = reader.GetString(34);

                 

                    accounts.Add(new Account(accountDetails,customerDetails, bankerDetails, branchDetails));


                }
                conn.Close();
                return accounts;

            }
            catch (MySqlException)
            {
                conn.Close();
                return null;
            }
        }
        // account ************************
    }
}
