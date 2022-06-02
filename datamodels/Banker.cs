using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Banker
    {
        private string nationalCode;
        private string branchcode;
        private int address_Id;
        private int position; // 0 is boss and 1 is employee !!!
        private string fname;
        private DateTime birthdate;
        private string lname;
        private string fathername;
        private string education;
        private bool gender; //true is male and false is female !!!
        private string phoneNumber;

        public string NationalCode { get => nationalCode; set => nationalCode = value; }
        public string Branchcode { get => branchcode; set => branchcode = value; }
        public int Address_Id { get => address_Id; set => address_Id = value; }
        public int Position { get => position; set => position = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => Lname1; set => Lname1 = value; }
        public string Lname1 { get => lname; set => lname = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Fathername { get => fathername; set => fathername = value; }
        public string Education { get => education; set => education = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
