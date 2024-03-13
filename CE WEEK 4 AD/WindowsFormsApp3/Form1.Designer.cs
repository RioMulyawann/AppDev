namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_check = new System.Windows.Forms.Button();
            this.tboxAngka = new System.Windows.Forms.TextBox();
            this.labelAngka = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxJurusan = new System.Windows.Forms.TextBox();
            this.textBoxNAMA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(190, 176);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(415, 153);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tboxAngka
            // 
            this.tboxAngka.Location = new System.Drawing.Point(190, 108);
            this.tboxAngka.Name = "tboxAngka";
            this.tboxAngka.Size = new System.Drawing.Size(420, 31);
            this.tboxAngka.TabIndex = 1;
            // 
            // labelAngka
            // 
            this.labelAngka.AutoSize = true;
            this.labelAngka.Location = new System.Drawing.Point(200, 69);
            this.labelAngka.Name = "labelAngka";
            this.labelAngka.Size = new System.Drawing.Size(73, 25);
            this.labelAngka.TabIndex = 2;
            this.labelAngka.Text = "Angka";
            this.labelAngka.Click += new System.EventHandler(this.labelAngka_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(619, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(914, 552);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(1588, 222);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(379, 31);
            this.textBoxNIM.TabIndex = 4;
            // 
            // textBoxJurusan
            // 
            this.textBoxJurusan.Location = new System.Drawing.Point(1588, 410);
            this.textBoxJurusan.Name = "textBoxJurusan";
            this.textBoxJurusan.Size = new System.Drawing.Size(379, 31);
            this.textBoxJurusan.TabIndex = 5;
            // 
            // textBoxNAMA
            // 
            this.textBoxNAMA.Location = new System.Drawing.Point(1588, 313);
            this.textBoxNAMA.Name = "textBoxNAMA";
            this.textBoxNAMA.Size = new System.Drawing.Size(379, 31);
            this.textBoxNAMA.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1596, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1596, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jurusan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1583, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1708, 480);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(184, 74);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(255, 679);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(193, 113);
            this.buttonView.TabIndex = 11;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(268, 524);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 113);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(1708, 601);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(184, 84);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2061, 914);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNAMA);
            this.Controls.Add(this.textBoxJurusan);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelAngka);
            this.Controls.Add(this.tboxAngka);
            this.Controls.Add(this.btn_check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox tboxAngka;
        private System.Windows.Forms.Label labelAngka;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.TextBox textBoxJurusan;
        private System.Windows.Forms.TextBox textBoxNAMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

