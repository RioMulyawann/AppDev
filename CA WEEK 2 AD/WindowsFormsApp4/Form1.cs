using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_red_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ganti_Click(object sender, EventArgs e)
        {
            label_ganti.Text = textBox_input.Text;
            if (rbtn_blue.Checked == true ) 
            {
                label_ganti.ForeColor = Color.Blue ;
            }
            else if (rbtn_green.Checked == true)
            {
                label_ganti.ForeColor =Color.Green ;
            }
            else if (rbtn_red.Checked == true)
            {
                label_ganti.ForeColor = Color.Red ;
            }
        }
    }
}
