using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Transaction
    {
        private int transactionNumber;
        private string customerNationalCode;
        private string accountNumber;
        private int transactionType; // todo
        private long transactionAmount;
        private string transactionDate;
        private string destenationCardNumber;

        public int TransactionNumber { get => transactionNumber; set => transactionNumber = value; }
        public string CustomerNationalCode { get => customerNationalCode; set => customerNationalCode = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public int TransactionType { get => transactionType; set => transactionType = value; }
        public long TransactionAmount { get => transactionAmount; set => transactionAmount = value; }
        public string TransactionDate { get => transactionDate; set => transactionDate = value; }
        public string DestenationCardNumber { get => destenationCardNumber; set => destenationCardNumber = value; }



        public Transaction(int transactionnum, string customernational,string accountnum,
            long transactionamount,string destination)
        {
            this.transactionNumber = transactionnum;
            this.customerNationalCode = customernational;
            this.accountNumber = accountnum;
            this.transactionAmount = transactionamount;
            this.destenationCardNumber = destination;
        }

        public Transaction() { }
    }
}
