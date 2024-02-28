using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if (rbtn_hilang.Checked == false && rbtn_muncul.Checked == false)
            {
                label_tittle.Visible = false;
            }
           else
            {
                if (rbtn_muncul.Checked == true)
                {
                    label_tittle.Visible = true;
                }
               
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label_tittle.Text = "WAH JEPPER JEPPER";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_hilang.Checked == false && rbtn_muncul.Checked == false)
            {
                label_tittle.Visible = false;
            }
            else
            {
                if (rbtn_hilang.Checked == true)
                {
                    label_tittle.Visible = false;
                }
               
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int total = 0;
            label_tittle.Text = textBox_input.Text;
            string temp = textBox_input.Text;
            total = temp.Length;

         label_totalhuruf.Text = total.ToString();
        }
    }
}
