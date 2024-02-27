namespace WindowsFormsApp4
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
            this.btn_ganti = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_red = new System.Windows.Forms.RadioButton();
            this.rbtn_green = new System.Windows.Forms.RadioButton();
            this.rbtn_blue = new System.Windows.Forms.RadioButton();
            this.label_ganti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ganti
            // 
            this.btn_ganti.Location = new System.Drawing.Point(315, 209);
            this.btn_ganti.Name = "btn_ganti";
            this.btn_ganti.Size = new System.Drawing.Size(141, 28);
            this.btn_ganti.TabIndex = 0;
            this.btn_ganti.Text = "Ganti";
            this.btn_ganti.UseVisualStyleBackColor = true;
            this.btn_ganti.Click += new System.EventHandler(this.btn_ganti_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.Location = new System.Drawing.Point(310, 172);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(146, 31);
            this.textBox_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtn_red
            // 
            this.rbtn_red.AutoSize = true;
            this.rbtn_red.Location = new System.Drawing.Point(483, 157);
            this.rbtn_red.Name = "rbtn_red";
            this.rbtn_red.Size = new System.Drawing.Size(45, 17);
            this.rbtn_red.TabIndex = 3;
            this.rbtn_red.TabStop = true;
            this.rbtn_red.Text = "Red";
            this.rbtn_red.UseVisualStyleBackColor = true;
            this.rbtn_red.CheckedChanged += new System.EventHandler(this.rbtn_red_CheckedChanged);
            // 
            // rbtn_green
            // 
            this.rbtn_green.AutoSize = true;
            this.rbtn_green.Location = new System.Drawing.Point(483, 172);
            this.rbtn_green.Name = "rbtn_green";
            this.rbtn_green.Size = new System.Drawing.Size(54, 17);
            this.rbtn_green.TabIndex = 4;
            this.rbtn_green.TabStop = true;
            this.rbtn_green.Text = "Green";
            this.rbtn_green.UseVisualStyleBackColor = true;
            // 
            // rbtn_blue
            // 
            this.rbtn_blue.AutoSize = true;
            this.rbtn_blue.Location = new System.Drawing.Point(483, 187);
            this.rbtn_blue.Name = "rbtn_blue";
            this.rbtn_blue.Size = new System.Drawing.Size(46, 17);
            this.rbtn_blue.TabIndex = 5;
            this.rbtn_blue.TabStop = true;
            this.rbtn_blue.Text = "Blue";
            this.rbtn_blue.UseVisualStyleBackColor = true;
            // 
            // label_ganti
            // 
            this.label_ganti.AutoSize = true;
            this.label_ganti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ganti.Location = new System.Drawing.Point(345, 125);
            this.label_ganti.Name = "label_ganti";
            this.label_ganti.Size = new System.Drawing.Size(68, 25);
            this.label_ganti.TabIndex = 7;
            this.label_ganti.Text = "Ganti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ganti);
            this.Controls.Add(this.rbtn_blue);
            this.Controls.Add(this.rbtn_green);
            this.Controls.Add(this.rbtn_red);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.btn_ganti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ganti;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_red;
        private System.Windows.Forms.RadioButton rbtn_green;
        private System.Windows.Forms.RadioButton rbtn_blue;
        private System.Windows.Forms.Label label_ganti;
    }
}

