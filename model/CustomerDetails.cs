using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
   public class CustomerDetails
    {
        private string nationalCode;
        private string code_Posti;
        private string fname;
        private string lname;
        private string birthdate;
        private string fatherName;
        private string education;
        private string job;
        private bool gender; // true is male and false is female !!!!
        private string phoneNumber;

         public CustomerDetails(string nationalCode,string code_Posti,string fname,string lname,string birthdate,string fatherName
             ,string education , string job,bool gender, string phoneNumber)
        {
            this.nationalCode = nationalCode;
            this.code_Posti = code_Posti;
            this.fname = fname;
            this.lname = lname;
            this.birthdate = birthdate;
            this.fatherName = fatherName;
            this.education = education;
            this.job = job;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
        }

        public CustomerDetails()
        {

        }


        public string NationalCode { get => nationalCode; set => nationalCode = value; }
        public string Code_Posti { get => code_Posti; set => code_Posti = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string Education { get => education; set => education = value; }
        public string Job { get => job; set => job = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public override string ToString()
        {
            return "Customer:\n" + Fname + "\n" + Lname +
                "\n" + NationalCode + "\n";
            
           
        }
    }
}
