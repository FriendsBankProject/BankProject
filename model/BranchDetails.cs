using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.datamodels
{
   public class BranchDetails
    {
        private string branchcode;
        private string code_Posti;
        private string branchname;

        public string Branchcode { get => branchcode; set => branchcode = value; }
        public string Code_Posti { get => code_Posti; set => code_Posti = value; }
        public string Branchname { get => branchname; set => branchname = value; }

        public BranchDetails(string branchcode , string code_posti, string branchname)
        {
            this.branchcode = branchcode;
            this.code_Posti = code_posti;
            this.branchname = branchname;
        }
        public BranchDetails() { }
    }
}
