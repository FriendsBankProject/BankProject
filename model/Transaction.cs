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
        private string accountNumber;
        private long transactionAmount;
        private string transactionDate;
        private string destenationCardNumber;

        public Transaction(int transactionNumber,string accountNumber,long amount,
            string transactionDate,string destenationCardNumber)
        {
            this.transactionNumber = transactionNumber;
            this.accountNumber = accountNumber;
            this.transactionAmount = amount;
            this.transactionDate = transactionDate;
            this.destenationCardNumber = destenationCardNumber;
        }

        public int TransactionNumber { get => transactionNumber; set => transactionNumber = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public long TransactionAmount { get => transactionAmount; set => transactionAmount = value; }
        public string TransactionDate { get => transactionDate; set => transactionDate = value; }
        public string DestenationCardNumber { get => destenationCardNumber; set => destenationCardNumber = value; }

    }
}