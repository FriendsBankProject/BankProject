using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Check
    {
        private string checkNumber;
        private string branchCode;
        private string accountNumber;
        private string customerNationalCode;
        private string shebaAccountNumber;
        private string checkDate;
        private long amount;
        private string reciverName;
        private string reciverNationalNumber;

        public string CheckNumber { get => checkNumber; set => checkNumber = value; }
        public string BranchCode { get => branchCode; set => branchCode = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string CustomerNationalCode { get => customerNationalCode; set => customerNationalCode = value; }
        public string ShebaAccountNumber { get => shebaAccountNumber; set => shebaAccountNumber = value; }
        public string CheckDate { get => checkDate; set => checkDate = value; }
        public long Amount { get => amount; set => amount = value; }
        public string ReciverName { get => reciverName; set => reciverName = value; }
        public string ReciverNationalNumber { get => reciverNationalNumber; set => reciverNationalNumber = value; }
    }
}
