namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tboxInputKiri = new System.Windows.Forms.TextBox();
            this.tboxInputKanan = new System.Windows.Forms.TextBox();
            this.labelNamaKiri = new System.Windows.Forms.Label();
            this.labelNamaKanan = new System.Windows.Forms.Label();
            this.btnInputkiri = new System.Windows.Forms.Button();
            this.btnInputKanan = new System.Windows.Forms.Button();
            this.listBoxInputKiri = new System.Windows.Forms.ListBox();
            this.listBoxInputKanan = new System.Windows.Forms.ListBox();
            this.btnpindahKiriSemua = new System.Windows.Forms.Button();
            this.btnPindahKanan = new System.Windows.Forms.Button();
            this.btnPindahKiri = new System.Windows.Forms.Button();
            this.btnPindahKananSemua = new System.Windows.Forms.Button();
            this.btnClearKiri = new System.Windows.Forms.Button();
            this.btnClearKanan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tboxInputKiri
            // 
            this.tboxInputKiri.ForeColor = System.Drawing.Color.Black;
            this.tboxInputKiri.Location = new System.Drawing.Point(58, 83);
            this.tboxInputKiri.Name = "tboxInputKiri";
            this.tboxInputKiri.Size = new System.Drawing.Size(279, 31);
            this.tboxInputKiri.TabIndex = 2;
            // 
            // tboxInputKanan
            // 
            this.tboxInputKanan.Location = new System.Drawing.Point(505, 83);
            this.tboxInputKanan.Name = "tboxInputKanan";
            this.tboxInputKanan.Size = new System.Drawing.Size(279, 31);
            this.tboxInputKanan.TabIndex = 3;
            // 
            // labelNamaKiri
            // 
            this.labelNamaKiri.AutoSize = true;
            this.labelNamaKiri.Location = new System.Drawing.Point(161, 55);
            this.labelNamaKiri.Name = "labelNamaKiri";
            this.labelNamaKiri.Size = new System.Drawing.Size(68, 25);
            this.labelNamaKiri.TabIndex = 4;
            this.labelNamaKiri.Text = "Nama";
            this.labelNamaKiri.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNamaKanan
            // 
            this.labelNamaKanan.AutoSize = true;
            this.labelNamaKanan.Location = new System.Drawing.Point(615, 55);
            this.labelNamaKanan.Name = "labelNamaKanan";
            this.labelNamaKanan.Size = new System.Drawing.Size(68, 25);
            this.labelNamaKanan.TabIndex = 5;
            this.labelNamaKanan.Text = "Nama";
            // 
            // btnInputkiri
            // 
            this.btnInputkiri.Location = new System.Drawing.Point(130, 130);
            this.btnInputkiri.Name = "btnInputkiri";
            this.btnInputkiri.Size = new System.Drawing.Size(134, 44);
            this.btnInputkiri.TabIndex = 7;
            this.btnInputkiri.Text = "Input";
            this.btnInputkiri.UseVisualStyleBackColor = true;
            this.btnInputkiri.Click += new System.EventHandler(this.btnInputkiri_Click);
            // 
            // btnInputKanan
            // 
            this.btnInputKanan.Location = new System.Drawing.Point(584, 130);
            this.btnInputKanan.Name = "btnInputKanan";
            this.btnInputKanan.Size = new System.Drawing.Size(134, 44);
            this.btnInputKanan.TabIndex = 8;
            this.btnInputKanan.Text = "Input";
            this.btnInputKanan.UseVisualStyleBackColor = true;
            this.btnInputKanan.Click += new System.EventHandler(this.btnInputKanan_Click);
            // 
            // listBoxInputKiri
            // 
            this.listBoxInputKiri.FormattingEnabled = true;
            this.listBoxInputKiri.ItemHeight = 25;
            this.listBoxInputKiri.Location = new System.Drawing.Point(58, 211);
            this.listBoxInputKiri.Name = "listBoxInputKiri";
            this.listBoxInputKiri.Size = new System.Drawing.Size(278, 279);
            this.listBoxInputKiri.TabIndex = 9;
            // 
            // listBoxInputKanan
            // 
            this.listBoxInputKanan.FormattingEnabled = true;
            this.listBoxInputKanan.ItemHeight = 25;
            this.listBoxInputKanan.Location = new System.Drawing.Point(505, 211);
            this.listBoxInputKanan.Name = "listBoxInputKanan";
            this.listBoxInputKanan.Size = new System.Drawing.Size(279, 279);
            this.listBoxInputKanan.TabIndex = 10;
            this.listBoxInputKanan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnpindahKiriSemua
            // 
            this.btnpindahKiriSemua.Location = new System.Drawing.Point(384, 253);
            this.btnpindahKiriSemua.Name = "btnpindahKiriSemua";
            this.btnpindahKiriSemua.Size = new System.Drawing.Size(66, 45);
            this.btnpindahKiriSemua.TabIndex = 11;
            this.btnpindahKiriSemua.Text = "<<";
            this.btnpindahKiriSemua.UseVisualStyleBackColor = true;
            this.btnpindahKiriSemua.Click += new System.EventHandler(this.btnpindahKiriSemua_Click);
            // 
            // btnPindahKanan
            // 
            this.btnPindahKanan.Location = new System.Drawing.Point(384, 354);
            this.btnPindahKanan.Name = "btnPindahKanan";
            this.btnPindahKanan.Size = new System.Drawing.Size(66, 47);
            this.btnPindahKanan.TabIndex = 12;
            this.btnPindahKanan.Text = ">";
            this.btnPindahKanan.UseVisualStyleBackColor = true;
            this.btnPindahKanan.Click += new System.EventHandler(this.btnPindahKanan_Click);
            // 
            // btnPindahKiri
            // 
            this.btnPindahKiri.Location = new System.Drawing.Point(384, 304);
            this.btnPindahKiri.Name = "btnPindahKiri";
            this.btnPindahKiri.Size = new System.Drawing.Size(66, 44);
            this.btnPindahKiri.TabIndex = 13;
            this.btnPindahKiri.Text = "<";
            this.btnPindahKiri.UseVisualStyleBackColor = true;
            this.btnPindahKiri.Click += new System.EventHandler(this.btnPindahKiri_Click);
            // 
            // btnPindahKananSemua
            // 
            this.btnPindahKananSemua.Location = new System.Drawing.Point(384, 407);
            this.btnPindahKananSemua.Name = "btnPindahKananSemua";
            this.btnPindahKananSemua.Size = new System.Drawing.Size(66, 47);
            this.btnPindahKananSemua.TabIndex = 14;
            this.btnPindahKananSemua.Text = ">>";
            this.btnPindahKananSemua.UseVisualStyleBackColor = true;
            this.btnPindahKananSemua.Click += new System.EventHandler(this.btnPindahKananSemua_Click);
            // 
            // btnClearKiri
            // 
            this.btnClearKiri.Location = new System.Drawing.Point(248, 511);
            this.btnClearKiri.Name = "btnClearKiri";
            this.btnClearKiri.Size = new System.Drawing.Size(89, 44);
            this.btnClearKiri.TabIndex = 15;
            this.btnClearKiri.Text = "Clear";
            this.btnClearKiri.UseVisualStyleBackColor = true;
            this.btnClearKiri.Click += new System.EventHandler(this.btnClearKiri_Click);
            // 
            // btnClearKanan
            // 
            this.btnClearKanan.Location = new System.Drawing.Point(505, 511);
            this.btnClearKanan.Name = "btnClearKanan";
            this.btnClearKanan.Size = new System.Drawing.Size(89, 44);
            this.btnClearKanan.TabIndex = 16;
            this.btnClearKanan.Text = "Clear";
            this.btnClearKanan.UseVisualStyleBackColor = true;
            this.btnClearKanan.Click += new System.EventHandler(this.btnClearKanan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 837);
            this.Controls.Add(this.btnClearKanan);
            this.Controls.Add(this.btnClearKiri);
            this.Controls.Add(this.btnPindahKananSemua);
            this.Controls.Add(this.btnPindahKiri);
            this.Controls.Add(this.btnPindahKanan);
            this.Controls.Add(this.btnpindahKiriSemua);
            this.Controls.Add(this.listBoxInputKanan);
            this.Controls.Add(this.listBoxInputKiri);
            this.Controls.Add(this.btnInputKanan);
            this.Controls.Add(this.btnInputkiri);
            this.Controls.Add(this.labelNamaKanan);
            this.Controls.Add(this.labelNamaKiri);
            this.Controls.Add(this.tboxInputKanan);
            this.Controls.Add(this.tboxInputKiri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox tboxInputKiri;
        private System.Windows.Forms.TextBox tboxInputKanan;
        private System.Windows.Forms.Label labelNamaKiri;
        private System.Windows.Forms.Label labelNamaKanan;
        private System.Windows.Forms.Button btnInputkiri;
        private System.Windows.Forms.Button btnInputKanan;
        private System.Windows.Forms.ListBox listBoxInputKiri;
        private System.Windows.Forms.ListBox listBoxInputKanan;
        private System.Windows.Forms.Button btnpindahKiriSemua;
        private System.Windows.Forms.Button btnPindahKanan;
        private System.Windows.Forms.Button btnPindahKiri;
        private System.Windows.Forms.Button btnPindahKananSemua;
        private System.Windows.Forms.Button btnClearKiri;
        private System.Windows.Forms.Button btnClearKanan;
    }
}

