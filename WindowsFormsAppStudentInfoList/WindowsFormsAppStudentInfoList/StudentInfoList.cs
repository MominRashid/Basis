using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppStudentInfoList
{
    public partial class StudentInfoList : Form
    {
        public StudentInfoList()
        {
            InitializeComponent();
        }

         List<StudentList> students = new List<StudentList>(); 
        private void showButtom_Click(object sender, EventArgs e)
        {
            StudentList astudent = new StudentList();
            astudent.regNo = regnoTextBox.Text;
            astudent.fName = firstnameTextBox.Text;
            astudent.lName = lastnameTextBox.Text;
            students.Add(astudent);

            string msg = astudent.GetFullName() + " has registration No: " + astudent.regNo;
            MessageBox.Show(msg);

            regnoTextBox.Text = "";
            firstnameTextBox.Text = "";
            lastnameTextBox.Text = ""; 


        }

        private void retriveButton_Click(object sender, EventArgs e)
        {

            string aline = "Registration No\t" + "Full Name\n";
            foreach (StudentList aStudent in students)
            {
               aline += aStudent.regNo + "\t" + aStudent.GetFullName() + "\n";
            }
            MessageBox.Show(aline);
        }
    }
}
