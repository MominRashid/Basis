using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppStudentType
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }

        Student aStudent = new Student();
        
        private void showButtom_Click(object sender, EventArgs e)
        {

            aStudent.regNo = regnoTextBox.Text;
            aStudent.fname = firstnameTextBox.Text;
            aStudent.lname = lastnameTextBox.Text;

            string msg = aStudent.GetFullName()+ " has Reg Number " + aStudent.regNo;
            

            MessageBox.Show(msg);

            regnoTextBox.Text = "";
            firstnameTextBox.Text = "";
            lastnameTextBox.Text = "";

        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            regnoTextBox.Text = aStudent.regNo; 
            firstnameTextBox.Text = aStudent.fname;
            lastnameTextBox.Text = aStudent.lname;

        }
    }
}
