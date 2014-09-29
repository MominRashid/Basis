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

namespace CustomarQueueManagmentApp
{
    public partial class CustomarCareUI : Form
    {
        public CustomarCareUI()
        {
            InitializeComponent();
        }
        Queue<CustomarClass> aQueue = new Queue<CustomarClass>();

        CustomarClass customarClass = new CustomarClass();

        private int serial = 1;
        private void Enqueuebutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == ""  || ComplaintextBox.Text == "")
            {
                MessageBox.Show("Pls Entry Data");
            }


            customarClass.serial = serial.ToString();
            customarClass.name = NametextBox.Text;
            customarClass.complain = ComplaintextBox.Text;
            
            aQueue.Enqueue(customarClass);
            serial++;

            ListViewItem item = new ListViewItem();

            item.Text = customarClass.serial;
            item.SubItems.Add(customarClass.name);
            item.SubItems.Add(customarClass.complain);
           listView1.Items.Add(item);
            NametextBox.Text = string.Empty;
            ComplaintextBox.Text = string.Empty;



        }

       
            

       

        private void Dequeuebutton_Click(object sender, EventArgs e)
        {
            //Queue<CustomarClass> aQueue = new Queue<CustomarClass>();

            //CustomarClass customarClass = new CustomarClass();

            customarClass = aQueue.Dequeue();
            SerialtextBox.Text = customarClass.serial;
            NameDequeuetextBox.Text = customarClass.name;
            ComplainDequeuetextBox.Text = customarClass.complain;
            //aQueue.Dequeue();
            listView1.Items[0].Remove();

        }

       
       
        
    }
}
