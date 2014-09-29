using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkTImeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            string s = balancrTextBox.Text;

            double balance = Convert.ToDouble(s);

            string sys = posPreComboBox.Text;

            string mobileOperator = operatorComboBox.Text;

            if (mobileOperator == "Grameen")
            {
                if (sys == "Prepaid")
                {
                    double talktime = balance/.5;
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else if (sys == "Post Paid")
                {
                    double talktime1 = balance/.4;
                    int talktime = Convert.ToInt32(talktime1);
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else
                {
                    MessageBox.Show("Enter Option");
                }
            }
            else if (mobileOperator == "Robi")
            {
                if (sys == "Prepaid")
                {
                    double talktime1 = balance/.55;
                    int talktime = Convert.ToInt32(talktime1);
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else if (sys == "Post Paid")
                {
                    double talktime1 = balance/.45;
                    int talktime = Convert.ToInt32(talktime1);
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else
                {
                    MessageBox.Show("Enter Option");
                }
            
        }
            else if (mobileOperator == "Airtel")
            {
                if (sys == "Prepaid")
                {
                    double talktime1 = balance/.52;
                    int talktime = Convert.ToInt32(talktime1);
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else if (sys == "Post Paid")
                {
                    double talktime1 = balance/.42;
                    int talktime = Convert.ToInt32(talktime1);
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else
                {
                    MessageBox.Show("Enter Option");
                }
            
        }
            else 
            if (mobileOperator == "Banglalink")
            {
                if (sys == "Prepaid")
                {
                    double talktime1 = balance/.60;
                    int talktime = Convert.ToInt32(talktime1);
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else if (sys == "Post Paid")
                {
                    double talktime1 = balance/.40;
                    int talktime = Convert.ToInt32(talktime1);
                    label.Text = Convert.ToString(talktime + " minutes");
                }
                else
                {
                    MessageBox.Show("Enter Option");
                }

            }
            else
            {
                MessageBox.Show("Enter Operator");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
    }
}
