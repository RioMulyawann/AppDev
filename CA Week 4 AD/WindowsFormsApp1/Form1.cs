using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInputkiri_Click(object sender, EventArgs e)
        {
            if (listBoxInputKanan.Items.Contains(tboxInputKiri.Text.ToUpper()) || listBoxInputKiri.Items.Contains(tboxInputKiri.Text.ToUpper()))
            {
                MessageBox.Show("Error... Name is taken");
            }
            else
            {
                listBoxInputKiri.Items.Add(tboxInputKiri.Text.ToUpper());
            }
            tboxInputKiri.Text = string.Empty;
        }

        private void btnInputKanan_Click(object sender, EventArgs e)
        {
            if (listBoxInputKiri.Items.Contains(tboxInputKanan.Text.ToUpper()) || listBoxInputKanan.Items.Contains(tboxInputKanan.Text.ToUpper()))
            {
                MessageBox.Show("Error... Name is taken");
            }
            else
            {
                listBoxInputKanan.Items.Add(tboxInputKanan.Text.ToUpper());
            }
            
            tboxInputKanan.Text = string.Empty;
        }

        private void btnpindahKiriSemua_Click(object sender, EventArgs e)
        {
            foreach (string nama in listBoxInputKanan.Items) 
            {
               listBoxInputKiri.Items.Add(nama);
              
                             
            }
            listBoxInputKanan.Items.Clear();
        }

        private void btnPindahKananSemua_Click(object sender, EventArgs e)
        {
            foreach (string nama in listBoxInputKiri.Items)
            {
               
                
                listBoxInputKanan.Items.Add(nama);
                

            }
            listBoxInputKiri.Items.Clear();
        }

        private void btnPindahKiri_Click(object sender, EventArgs e)
        {
            if (listBoxInputKanan.SelectedItem == null)
            {
                listBoxInputKiri.Items.Add(listBoxInputKanan.Items[listBoxInputKanan.Items.Count-1]);
                listBoxInputKanan.Items.Remove(listBoxInputKanan.Items[listBoxInputKanan.Items.Count - 1]);
            }
            else
            {
                listBoxInputKiri.Items.Add(listBoxInputKanan.SelectedItem);
                listBoxInputKanan.Items.Remove(listBoxInputKanan.SelectedItem);
            }
            
        }

        private void btnPindahKanan_Click(object sender, EventArgs e)
        {
            if (listBoxInputKiri.SelectedItem == null)
            {
                listBoxInputKanan.Items.Add(listBoxInputKiri.Items[listBoxInputKiri.Items.Count - 1]);
                listBoxInputKiri.Items.Remove(listBoxInputKiri.Items[listBoxInputKiri.Items.Count - 1]);
            }
            else
            {
                listBoxInputKanan.Items.Add(listBoxInputKiri.SelectedItem);
                listBoxInputKiri.Items.Remove(listBoxInputKiri.SelectedItem);
            }
                
        }

        private void btnClearKiri_Click(object sender, EventArgs e)
        {
            listBoxInputKiri.Items.Clear();
        }

        private void btnClearKanan_Click(object sender, EventArgs e)
        {
            listBoxInputKanan.Items.Clear();
        }
    }
}
