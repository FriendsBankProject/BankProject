using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.model
{
    class Account
    {
        private AccountDetails account;
        private CustomerDetails customer;
        private BankerDetails banker;
        private BranchDetails branch;

        public Account(AccountDetails account,CustomerDetails customer,BankerDetails banker,BranchDetails branch)
        {
            this.AccountDetails = account;
            this.Customer = customer;
            this.Banker = banker;
            this.Branch = branch;
        }

        internal AccountDetails AccountDetails { get => account; set => account = value; }
        internal CustomerDetails Customer { get => customer; set => customer = value; }
        internal BankerDetails Banker { get => banker; set => banker = value; }
        internal BranchDetails Branch { get => branch; set => branch = value; }

        public override string ToString()
        {
            return customer.Fname + " " + customer.Lname + " " + account.AccountNumber + " " + banker.Fname;
        }
    }
}
