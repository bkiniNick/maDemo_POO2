using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit_1
{
    public sealed  class Transaction
    {
        public string cardNumber { get; set; }
        public string owner { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Transaction()
        { 
        


        }

    }
}
