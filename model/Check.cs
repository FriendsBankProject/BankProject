using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.model
{
    class Check
    {
        private CheckDetails checkDetails;
        private BranchDetails branchDetails;
        private CustomerDetails customerDetails;
          public Check(CheckDetails check, CustomerDetails customer, BranchDetails branch)
        {
            this.checkDetails = check;
            this.customerDetails = customer;
            this.branchDetails = branch;
        }

        internal CheckDetails CheckDetails { get => checkDetails; set => checkDetails = value; }
        internal BranchDetails BranchDetails { get => branchDetails; set => branchDetails = value; }
        internal CustomerDetails CustomerDetails { get => customerDetails; set => customerDetails = value; }

        public override string ToString()
        {
            return checkDetails.CheckNumber + "  " + customerDetails.Fname + "  " + checkDetails.ReciverName;
        }
    }
}
