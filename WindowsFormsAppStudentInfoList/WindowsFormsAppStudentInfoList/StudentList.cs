using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppStudentInfoList
{
    class StudentList
    {
        public string regNo;
        public string fName;
        public string lName;

        public string GetFullName()
        {
            return fName + " " + lName;
        }
    }
}
