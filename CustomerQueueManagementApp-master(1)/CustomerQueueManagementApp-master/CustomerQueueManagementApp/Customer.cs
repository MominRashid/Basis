using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQueueManagementApp
{
    class Customer
    {
        public int id;
        public string name;
        public string complain;

        public string GetName()
        {
            return name;
        }
    }
}
