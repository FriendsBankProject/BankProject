﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class LoanDetails
    {
        private int loanNumber;
        private string loanGaruntor;
        private string borrowerNationalCode;
        private long loanAmount;
        private string dueDate;
        private string bankerNationalCode;

        public LoanDetails()
        {
        }

        public LoanDetails(int loanNumber,string loanGurantor,string borrowerNationalCode,long loanAmount,
            string dueDate,string bankerNationalCode)
        {
            this.loanNumber = loanNumber;
            this.loanGaruntor = loanGurantor;
            this.borrowerNationalCode = borrowerNationalCode;
            this.loanAmount = loanAmount;
            this.dueDate = dueDate;
            this.bankerNationalCode = bankerNationalCode;
        }

        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public string LoanGaruntor { get => loanGaruntor; set => loanGaruntor = value; }
        public string BorrowerNationalCode { get => borrowerNationalCode; set => borrowerNationalCode = value; }
        public long LoanAmount { get => loanAmount; set => loanAmount = value; }
        public string DueDate { get => dueDate; set => dueDate = value; }
        public string BankerNationalCode { get => bankerNationalCode; set => bankerNationalCode = value; }
    }
}
