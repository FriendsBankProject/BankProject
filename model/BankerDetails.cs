using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
   public class BankerDetails
    {
        private string nationalCode;
        private int branchcode;
        private string code_posti;
        private int position; // 0 is boss and 1 is employee !!!
        private string fname;
        private string birthdate;
        private string lname;
        private string fathername;
        private string education;
        private bool gender; //true is male and false is female !!!
        private string phoneNumber;

        public string NationalCode { get => nationalCode; set => nationalCode = value; }
        public int Branchcode { get => branchcode; set => branchcode = value; }
        public string Code_Posti { get => code_posti; set => code_posti = value; }
        public int Position { get => position; set => position = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => Lname1; set => Lname1 = value; }
        public string Lname1 { get => lname; set => lname = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Fathername { get => fathername; set => fathername = value; }
        public string Education { get => education; set => education = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public override string ToString()
        {
            string str = "Banker:\n" + Fname + "\n" + Lname +
                "\n" + NationalCode + "\n";
            if (Position == 0)
                str += "Boss";
            else str += "Employee";
            return str;
        }

        public BankerDetails(string nationalCode,int branchcode, string code_posti,int position , string fname, string birthdate, string lname , string fathername,
            string education,bool gender,string phonenumber)
        {
            this.nationalCode = nationalCode;
            this.branchcode = branchcode;
            this.code_posti = code_posti;
            this.position = position;
            this.fname = fname;
            this.birthdate = birthdate;
            this.lname = lname;
            this.fathername = fathername;
            this.education = education;
            this.gender = gender;
            this.phoneNumber = phonenumber;
        }

        public BankerDetails() { }
    }
}
