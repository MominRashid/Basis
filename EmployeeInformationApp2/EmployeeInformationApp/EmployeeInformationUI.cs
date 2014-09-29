using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class EmployeeInformationUI : Form
    {
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee=new Employee();

            aEmployee.id = idTextBox.Text;
            aEmployee.name = nameTextBox.Text;
            aEmployee.salary = Convert.ToDouble(salaryTextBox.Text);

            string msg = "Employee Id: " + aEmployee.id + "\n"
                         + "Employee Name: " + aEmployee.name + "\n"
                         + "Salary: " + aEmployee.salary;

            MessageBox.Show(msg);
        }

    }
}
