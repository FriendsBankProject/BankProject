using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.model
{
    class Transaction
    {
        private TransactionDetails transactionDetails;
        private string sender;
        private string reciver;

        public Transaction(TransactionDetails transactionDetails , string sender,string reciver)
        {
            this.transactionDetails = transactionDetails;
            this.sender = sender;
            this.reciver = reciver;
        }
        public string Sender { get => sender; set => sender = value; }
        public string Reciver { get => reciver; set => reciver = value; }
        internal TransactionDetails TransactionDetails { get => transactionDetails; set => transactionDetails = value; }

        public override string ToString()
        {
            return transactionDetails.TransactionNumber.ToString() + " " + sender + "  " + transactionDetails.TransactionDate + "  " + reciver;
        }
    }
}
