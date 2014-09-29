using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculationApp
{
    public partial class CollectionUI : Form
    {

        private int[] numbers = new int[5];
        private int index = 0;
        public CollectionUI()
        {
            InitializeComponent();
        }
        

        private void addButton_Click(object sender, EventArgs e)
        {
            int inputNumber = Convert.ToInt32(numberTextBox.Text);
            numbers[index] = inputNumber;
            index++;
            ShowListBoxItem();
            ShowTotal();
            countTextBox.Text = index.ToString();

        }

        private void ShowTotal()
        {
            int sum = 0;
            foreach (int aNumber in numbers)
            {
                sum += aNumber;
            }
            totalTextBox.Text = sum.ToString();
        }

        private void ShowListBoxItem()
        {
            numberListBox.Items.Clear();
            foreach (int aNumber in numbers)
            {
                numberListBox.Items.Add(aNumber);
            }
        }
    }
}
