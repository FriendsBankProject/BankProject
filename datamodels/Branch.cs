using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class Branch
    {
        private string branchcode;
        private int address_Id;
        private string branchname;

        public string Branchcode { get => branchcode; set => branchcode = value; }
        public int Address_Id { get => address_Id; set => address_Id = value; }
        public string Branchname { get => branchname; set => branchname = value; }
    }
}
