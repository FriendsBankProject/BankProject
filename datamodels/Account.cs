using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Account
    {
        private string accountNumber;
        private string bankerNationalCode;
        private string customerNationalCode;
        private string branchcode;
        private string cardnumber;
        private string shebaaccountnumber;
        private string firstpass;
        private string secondpass;
        private int secondDynamicCode;
        private DateTime createDynamicCodeTime;
        private int accountType; // 0 -> current account , 1 -> saving account
        private DateTime accountOpenningDate;
        private int profitPercentage;
        private long balance;

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string BankerNationalCode { get => bankerNationalCode; set => bankerNationalCode = value; }
        public string CustomerNationalCode { get => customerNationalCode; set => customerNationalCode = value; }
        public string Branchcode { get => branchcode; set => branchcode = value; }
        public string Cardnumber { get => cardnumber; set => cardnumber = value; }
        public string Shebaaccountnumber { get => shebaaccountnumber; set => shebaaccountnumber = value; }
        public string Firstpass { get => firstpass; set => firstpass = value; }
        public string Secondpass { get => secondpass; set => secondpass = value; }
        public int SecondDynamicCode { get => secondDynamicCode; set => secondDynamicCode = value; }
        public DateTime CreateDynamicCodeTime { get => createDynamicCodeTime; set => createDynamicCodeTime = value; }
        public int AccountType { get => accountType; set => accountType = value; }
        public DateTime AccountOpenningDate { get => accountOpenningDate; set => accountOpenningDate = value; }
        public int ProfitPercentage { get => profitPercentage; set => profitPercentage = value; }
        public long Balance { get => balance; set => balance = value; }
    }
}
