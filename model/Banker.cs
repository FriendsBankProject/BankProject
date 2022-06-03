using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.model
{
    class Banker
    {
        private BankerDetails bankerDetails;
        private BranchDetails branchDetails;
        private Address address;

        public Banker(BankerDetails bankerDetails, BranchDetails branchDetails,Address address)
        {
            this.BankerDetails = bankerDetails;
            this.branchDetails = branchDetails;
            this.Address = address;
        }

        internal BankerDetails BankerDetails { get => bankerDetails; set => bankerDetails = value; }
        internal BranchDetails BranchDetails { get => branchDetails; set => branchDetails = value; }
        internal Address Address { get => address; set => address = value; }

        public override string ToString()
        {
            return bankerDetails.Fname + "  " + bankerDetails.Lname + "  " + bankerDetails.PhoneNumber + "  " + address.City + "  " + branchDetails.Branchname;
        }
    }
}
