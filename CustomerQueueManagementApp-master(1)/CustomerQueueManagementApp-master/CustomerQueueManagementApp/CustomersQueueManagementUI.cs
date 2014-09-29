using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomersQueueManagementUI : Form
    {
        public CustomersQueueManagementUI()
        {
            InitializeComponent();
        }

        Queue<Customer> customersQueue = new Queue<Customer>();
        
        int serialNo=1;     
        private void enqueueButton_Click(object sender, EventArgs e)
        {

            Customer anCustomer = new Customer();
            anCustomer.id = serialNo;
            anCustomer.name = enquNameTextBox.Text;
            anCustomer.complain = enquComplainTextBox.Text;
            customersQueue.Enqueue(anCustomer);

            ListViewItem items = new ListViewItem(serialNo.ToString());
            items.SubItems.Add(enquNameTextBox.Text);
            items.SubItems.Add(enquComplainTextBox.Text);
            queueList.Items.Add(items);

            enquNameTextBox.Text = string.Empty;
            enquComplainTextBox.Text = string.Empty;
            
            MessageBox.Show(anCustomer.GetName()+"'s Serial Numbers is : "+ anCustomer.id);
            serialNo++;
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (complainQueue.Count !=0)
            {

                Customer anCustomer = customersQueue.Dequeue();
                dequSerialTextBox.Text = anCustomer.id.ToString();
                dequNameTextBox.Text = anCustomer.name;
                dequCompTextBox.Text = anCustomer.complain;
            }

            else
            {
                dequSerialTextBox.Text = string.Empty;
                dequNameTextBox.Text = string.Empty;
                dequCompTextBox.Text = string.Empty;

                MessageBox.Show("There is no Complaints!");
            }

            if (queueList.Items.Count!=0)
            {
                queueList.Items.RemoveAt(0);
            }
            
        }

        
    }
}
