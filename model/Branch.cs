using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.model
{
    class Branch
    {
        private BranchDetails branchDetails;
        private Address address;

        public Branch(BranchDetails branchDetails , Address address)
        {
            this.address = address;
            this.branchDetails = branchDetails;
        }

        internal BranchDetails BranchDetails { get => branchDetails; set => branchDetails = value; }
        internal Address Address { get => address; set => address = value; }
        public override string ToString()
        {
            return branchDetails.Branchcode + "  " + branchDetails.Branchname + " " + address.City + " " + address.Street;
        }
    }
}
