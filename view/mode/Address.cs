using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Address
    {
        private int id;
        private string city;
        private string street;
        private string info;
        private string code_posti;

        public int Id
        {
            set => id = value;
            get => id;
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
    }
}
