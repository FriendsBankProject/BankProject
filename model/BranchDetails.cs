using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
    class BranchDetails
    {
        private string branchcode;
        private string code_Posti;
        private string branchname;

        public string Branchcode { get => branchcode; set => branchcode = value; }
        public string Code_Posti { get => code_Posti; set => code_Posti = value; }
        public string Branchname { get => branchname; set => branchname = value; }
    }
}
