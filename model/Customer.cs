using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Customer
    {
        private string nationalCode;
        private int address_Id;
        private string fname;
        private string lname;
        private string birthdate;
        private string fatherName;
        private string education;
        private string job;
        private bool gender; // true is male and false is female !!!!
        private string phoneNumber;

        public string NationalCode { get => nationalCode; set => nationalCode = value; }
        public int Address_Id { get => address_Id; set => address_Id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string Education { get => education; set => education = value; }
        public string Job { get => job; set => job = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
