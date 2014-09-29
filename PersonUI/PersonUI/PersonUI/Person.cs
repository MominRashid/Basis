using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUI
{
    internal class Person
    {
        public string fname;
        public string mName;
        public string lname;

        public string GetFullName()
        {
            return fname + "  " + mName + " " + lname;


        }

        public string GetreverseFullName()
        {

            string Fullname = GetFullName();
            char[] cArray = Fullname.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;

        }
    }
}
