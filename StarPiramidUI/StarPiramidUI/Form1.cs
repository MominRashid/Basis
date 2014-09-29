using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarPiramidUI
{
    public partial class Form1 : Form
    {
        string star1;
        public Form1()
        {
            InitializeComponent();
        }

        private void piramidButton_Click(object sender, EventArgs e)
        {
            int level = Convert.ToInt32(levelTextBOx.Text);
            
            
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    star1+="*";
                }
                listBox.Items.Add(star1);
               // listBox.Items.Add("\n");
                star1 = null;
            }
        }
    }
}
