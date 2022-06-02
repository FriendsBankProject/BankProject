using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMekllat.controller
{
    class DatabaseResult
    {
        private string error;
        private bool result;

        public DatabaseResult(bool result,string error)
        {
            this.error = error;
            this.result = result;
        }
        public string Error { get => error;  }
        public bool Result { get => result; }
    }
}
