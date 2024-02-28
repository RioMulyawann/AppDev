namespace WindowsFormsApp5
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
            this.rbtn_muncul = new System.Windows.Forms.RadioButton();
            this.rbtn_hilang = new System.Windows.Forms.RadioButton();
            this.label_tittle = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.label_totalhuruf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtn_muncul
            // 
            this.rbtn_muncul.AutoSize = true;
            this.rbtn_muncul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_muncul.Location = new System.Drawing.Point(274, 211);
            this.rbtn_muncul.Name = "rbtn_muncul";
            this.rbtn_muncul.Size = new System.Drawing.Size(97, 28);
            this.rbtn_muncul.TabIndex = 2;
            this.rbtn_muncul.TabStop = true;
            this.rbtn_muncul.Text = "muncul";
            this.rbtn_muncul.UseVisualStyleBackColor = true;
            this.rbtn_muncul.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_hilang
            // 
            this.rbtn_hilang.AutoSize = true;
            this.rbtn_hilang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_hilang.Location = new System.Drawing.Point(274, 236);
            this.rbtn_hilang.Name = "rbtn_hilang";
            this.rbtn_hilang.Size = new System.Drawing.Size(85, 28);
            this.rbtn_hilang.TabIndex = 1;
            this.rbtn_hilang.TabStop = true;
            this.rbtn_hilang.Text = "hilang";
            this.rbtn_hilang.UseVisualStyleBackColor = true;
            this.rbtn_hilang.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label_tittle
            // 
            this.label_tittle.AutoSize = true;
            this.label_tittle.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tittle.Location = new System.Drawing.Point(311, 75);
            this.label_tittle.Name = "label_tittle";
            this.label_tittle.Size = new System.Drawing.Size(152, 50);
            this.label_tittle.TabIndex = 2;
            this.label_tittle.Text = "Hellow";
            this.label_tittle.Visible = false;
            this.label_tittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(19, 19);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(160, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(22, 51);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(104, 24);
            this.btn_change.TabIndex = 4;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(22, 92);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(69, 13);
            this.label_jumlah.TabIndex = 5;
            this.label_jumlah.Text = "Jumlah Huruf";
            // 
            // label_totalhuruf
            // 
            this.label_totalhuruf.AutoSize = true;
            this.label_totalhuruf.Location = new System.Drawing.Point(98, 92);
            this.label_totalhuruf.Name = "label_totalhuruf";
            this.label_totalhuruf.Size = new System.Drawing.Size(13, 13);
            this.label_totalhuruf.TabIndex = 6;
            this.label_totalhuruf.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_totalhuruf);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label_tittle);
            this.Controls.Add(this.rbtn_hilang);
            this.Controls.Add(this.rbtn_muncul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_muncul;
        private System.Windows.Forms.RadioButton rbtn_hilang;
        private System.Windows.Forms.Label label_tittle;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.Label label_totalhuruf;
    }
}

