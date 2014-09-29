using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EmployeeSalaryForm : Form
    {
        public EmployeeSalaryForm()
        {
            InitializeComponent();
        }

        private string employeeName;
        private string id;
        private string salaryAccount ;
        private string location = @"D:\EmployeeData.txt";
        private double totalSalary = 0;
        

        private void saveButton_Click(object sender, EventArgs e)
        {

            FileStream fileStream = new FileStream(location , FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            
            employeeName = employeeNameTextBox.Text;
            id = idTextBox.Text;
            salaryAccount = salaryAccountTextBox.Text;

            totalSalary += Convert.ToDouble(salaryAccount);
            streamWriter.Write(employeeName + "," + id + "," + salaryAccount);
            streamWriter.WriteLine();
            streamWriter.Close();
            



        }

        private void showTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream filsStream = new FileStream(location , FileMode.Open);
            StreamReader streamReader = new StreamReader(filsStream);

            employeeNameTextBox.Clear();
            totalSalary = 0;

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                MessageBox.Show(line);
                
                //string[] val;
                char[] seq =  {','};

                string[] val = line.Split(seq);
                //employeeShowListBox.Items.Add(val[0],val[1],val[2]);

                ListViewItem l = new ListViewItem(new string[]
                {
                    val[0],val[1],val[2]
                } );

                employeeShowListBox.Items.Add(l);
                if(val[2] != "0")
                totalSalary += Convert.ToDouble(val[2]);
            }
            streamReader.Close();
            totalAccountTextBox.Text = Convert.ToString(totalSalary);

        }

        private void EmployeeSalaryForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
