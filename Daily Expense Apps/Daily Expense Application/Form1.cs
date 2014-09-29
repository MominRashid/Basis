using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace Daily_Expense_Application
{
    public partial class DailyExpenseForm : Form
    {
        public DailyExpenseForm()
        {
            totalExpense = 0;
            maximumExpense = 0;
            InitializeComponent();
        }

        private string fileLocation = @"D:/New folder/emon.csv";        
        private double totalExpense;
        private double tempVal;
        private double maximumExpense;

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (txtAmount.Text == "" 
                || txtParticular.Text =="" 
                || categoryComboBox.Text =="")
            {
                MessageBox.Show("plz give Values");
                return;                
            }
            
            FileStream aStream = new FileStream(fileLocation ,FileMode.Append);
            CsvFileWriter aWriter= new CsvFileWriter(aStream);

            List<string> aDailyExpense = new List<string>();


             
            tempVal = Convert.ToDouble(txtAmount.Text);
            totalExpense += tempVal;

            if (maximumExpense < tempVal)
            {
                maximumExpense = tempVal;
            }

            aDailyExpense.Add(txtAmount.Text);
            aDailyExpense.Add(categoryComboBox.Text);
            aDailyExpense.Add(txtParticular.Text);

            aWriter.WriteRow(aDailyExpense);
            aStream.Close();

            MessageBox.Show("okk success");



            txtAmount.Text = "";
            txtParticular.Text = "";
        }

        private void viewSummaryShowButton_Click(object sender, EventArgs e)
        {
            txtTotal.Text = totalExpense.ToString();
            maximumExpenseTextBox.Text = maximumExpense.ToString();

            double maxVal = 0;
            showListView.Items.Clear();

            FileStream aStream = new FileStream(fileLocation, FileMode.Open);

            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aDailyExpense = new List<string>();

            if (new FileInfo(fileLocation).Length != 0)
            {
                while (aReader.ReadRow(aDailyExpense))
                {
                    tempVal = Convert.ToDouble(aDailyExpense[0]);
                    if (maxVal < tempVal)
                    {
                        maxVal = tempVal;
                    }

                    totalExpense += tempVal;
                }
            }

            txtTotal.Text = totalExpense.ToString();
            maximumExpenseTextBox.Text = maxVal.ToString();
            aStream.Close();

        }

        private void DailyExpenseForm_Load(object sender, EventArgs e)
        {
            totalExpense = 0;
            maximumExpense = 0;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            showListView.Items.Clear();

            string haveToMatch = categoryComboBox2.Text;
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);

            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aDailyExpense = new List<string>();

            ListViewItem listViewItem;

            if (new FileInfo(fileLocation).Length != 0)
            {
                while (aReader.ReadRow(aDailyExpense))
                {
                    if (aDailyExpense[1] == haveToMatch)
                    {

                        listViewItem = new ListViewItem(
                        new string []
                        {
                            
                            aDailyExpense[0],
                            aDailyExpense[1],
                            aDailyExpense[2]
                        }
                    );
                        
                        showListView.Items.Add(listViewItem);

                        total += Convert.ToDouble(aDailyExpense[0]);
                    }
                }
            }
            aStream.Close();


            totalTextBox.Text = total.ToString();
        }
    }
}
