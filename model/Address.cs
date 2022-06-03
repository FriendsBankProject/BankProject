using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Address
    {
        private string code_posti;
        private string city;
        private string street;
        private string info;
        
        public Address(string code_posti,string city,string street, string info)
        {
            this.code_posti = code_posti;
            this.city = city;
            this.street = street;
            this.info = info;
        }

        public Address()
        {

        }

        public string City
        {
            set => city = value;
            get => city;
        }

        public string Info
        {
            set => info = value;
            get => info;
        }

        public string Code_Posti
        {
            set => code_posti = value;
            get => code_posti;
        }
        public string Street { get => street; set => street = value; }

        public override string ToString()
        {
            return "Address:\n"+ city + "\n" + street + "\n" + info + "\n" + code_posti;
        }
    }
}
