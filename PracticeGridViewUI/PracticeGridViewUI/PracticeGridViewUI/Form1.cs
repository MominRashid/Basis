using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeGridViewUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string itemName = itemNameComboBox.Text;
            double itemPrice = Convert.ToDouble(itemPriceTextBox.Text);
            double itemQuantity = Convert.ToDouble(quantityTextBox.Text);
            double totalCost = itemPrice * itemQuantity;

            itemDataGridView.Rows.Add(itemName, itemPrice, itemQuantity, totalCost);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemNameComboBox.Text = "";
            itemPriceTextBox.Text = "";
            quantityTextBox.Text = "";
            itemDataGridView.Rows.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            itemNameComboBox.Text = "";
            itemPriceTextBox.Text = "";
            quantityTextBox.Text = "";
            itemDataGridView.Rows.RemoveAt(itemDataGridView.CurrentCell.RowIndex);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string itemName = itemNameComboBox.Text;
            double itemPrice = Convert.ToDouble(itemPriceTextBox.Text);
            double itemQuantity = Convert.ToDouble(quantityTextBox.Text);
            double totalCost = itemPrice * itemQuantity;
            var index = itemDataGridView.SelectedRows[0].Index;
            itemDataGridView.Rows[index].Cells[0].Value = itemName;
            itemDataGridView.Rows[index].Cells[1].Value = itemPrice;
            itemDataGridView.Rows[index].Cells[2].Value = itemQuantity;
            itemDataGridView.Rows[index].Cells[3].Value = totalCost;
        }

        private void itemDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow gridObj  = itemDataGridView.SelectedRows[0] ;
            itemNameComboBox.Text = gridObj.Cells[0].Value.ToString();
            itemPriceTextBox.Text = gridObj.Cells[1].Value.ToString();
            quantityTextBox.Text = gridObj.Cells[2].Value.ToString();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
