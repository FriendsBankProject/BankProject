using BankMekllat.datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.model
{
    class Customer
    {
        private CustomerDetails customerDetails;
        private Address address;

        public Customer(CustomerDetails customer,Address address)
        {
            this.CustomerDetails = customer;
            this.Address = address;
        }

        internal CustomerDetails CustomerDetails { get => customerDetails; set => customerDetails = value; }
        internal Address Address { get => address; set => address = value; }

        public override string ToString()
        {
            return customerDetails.Fname + " " + customerDetails.Lname + " " + customerDetails.PhoneNumber + " " + address.City;
        }
    }
}
