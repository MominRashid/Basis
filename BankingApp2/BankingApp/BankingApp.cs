using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class BankingApp : Form
    {
  
        public BankingApp()
        {
            InitializeComponent();
        }

        Account aAccount = new Account();

        private void createButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text != string.Empty && nameTextBox.Text != string.Empty)
            {
                aAccount.number = numberTextBox.Text;
                aAccount.name = nameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Plz Enter All Data");
            }
            numberTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
        }
        private void depositButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != string.Empty)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aAccount.Deposit(amount);
  
            }
            else
            {
                MessageBox.Show("Plz Enter Amount");
            }
            amountTextBox.Text = string.Empty;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != string.Empty)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aAccount.Withdraw(amount);
               
            }
            else
            {
                MessageBox.Show("Plz Enter Amount");
            }
            amountTextBox.Text = string.Empty;
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aAccount.GetReport());

        }



    }
}
