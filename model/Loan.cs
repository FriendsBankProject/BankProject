using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.model
{
    class Loan
    {
        private LoanDetails loanDetails;
        private CustomerDetails borrower;
        private CustomerDetails gurantor;
        private BankerDetails banker;

         public Loan()
        {

        }
        public Loan(LoanDetails loan,CustomerDetails borrower,CustomerDetails gurantor,BankerDetails banker)
        {
            this.loanDetails = loan;
            this.borrower = borrower;
            this.gurantor = gurantor;
            this.banker = banker;
        }

        internal LoanDetails LoanDetails { get => loanDetails; set => loanDetails = value; }
        internal CustomerDetails Borrower { get => borrower; set => borrower = value; }
        internal CustomerDetails Gurantor { get => gurantor; set => gurantor = value; }
        internal BankerDetails Banker { get => banker; set => banker = value; }

        public override string ToString()
        {
            return loanDetails.LoanNumber.ToString() + " " + borrower.Fname + " "
                + loanDetails.LoanAmount.ToString() + gurantor.Fname;
        }
    }
}
