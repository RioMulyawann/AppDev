using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
           dt = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelAngka_Click(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            int angka = Convert.ToInt32(tboxAngka.Text);
            int factor = 0;
            for (int i = 1; i <= angka; i++)
            {
                if (angka % i == 0)
                {
                    factor++;
                }
            }
            if (factor == 2)
            {
                DialogResult dr = MessageBox.Show("Apakah Angka Tersebut Prima?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) { MessageBox.Show("BENAAR"); }
                else if (dr== DialogResult.No) { MessageBox.Show("Salah rekkk"); }

            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah Angka Tersebut Prima?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) { MessageBox.Show("BENAAR"); }
                else if (dr == DialogResult.Yes) { MessageBox.Show("Salah rekkk"); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("NIM");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Jurusan");
            dt.Rows.Add("0706022310056", "Rio Mulyawan", "ISB");
            dt.Rows.Add("0818396209", "Tony ton", "ISB");
            dataGridView1.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(textBoxNIM.Text,textBoxNAMA.Text,textBoxJurusan.Text);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            MessageBox.Show($"Nama: {dgrv.Cells[0].Value} NIM: {dgrv.Cells[1].Value} JURUSAN: {dgrv.Cells[2].Value}");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dataGridView1.CurrentRow;
            //dataGridView1.Rows.Remove(row);
            string NIM = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int index = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == NIM)
                {
                    index = i;
                }
            }
            dt.Rows.RemoveAt(index);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Selected = dataGridView1.CurrentRow;
            textBoxNIM.Text = Selected.Cells[0].Value.ToString();
            textBoxNIM.Enabled = false;
            textBoxNAMA.Text = Selected.Cells[1].Value.ToString();
            textBoxJurusan.Text = Selected.Cells[2].Value.ToString();
            buttonAdd.Enabled = false;
            buttonUpdate.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string NIM = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int index = 0;
            for (int i = 0;i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == NIM) 
                { index = i; }
            }
            dt.Rows[index][1] = textBoxNAMA.Text;
            dt.Rows[index][2] = textBoxJurusan.Text;
            buttonAdd.Enabled = true;
            textBoxJurusan.Text = "";
            textBoxNIM.Enabled = true;
            textBoxNIM.Text = "";
            textBoxNAMA.Text = "";
            buttonUpdate.Enabled=false;
        }
    }
}
