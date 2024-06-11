namespace WindowsFormsApp1
{
    partial class tkelurahan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.tblKelurahan = new System.Windows.Forms.DataGridView();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_kecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblKelurahan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Kelurahan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari dengan nama";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(832, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(598, 140);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(84, 37);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(690, 140);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(84, 37);
            this.btn_hapus.TabIndex = 4;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(780, 140);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(84, 37);
            this.btn_tambah.TabIndex = 5;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // dataGridView1
            // 
            this.tblKelurahan.AllowUserToAddRows = false;
            this.tblKelurahan.AllowUserToDeleteRows = false;
            this.tblKelurahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKelurahan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_id,
            this.c_kecamatan});
            this.tblKelurahan.Location = new System.Drawing.Point(33, 185);
            this.tblKelurahan.Name = "dataGridView1";
            this.tblKelurahan.ReadOnly = true;
            this.tblKelurahan.RowHeadersWidth = 51;
            this.tblKelurahan.RowTemplate.Height = 24;
            this.tblKelurahan.Size = new System.Drawing.Size(831, 188);
            this.tblKelurahan.TabIndex = 6;
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "id";
            this.c_id.HeaderText = "ID";
            this.c_id.MinimumWidth = 6;
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Width = 125;
            // 
            // c_kecamatan
            // 
            this.c_kecamatan.DataPropertyName = "name";
            this.c_kecamatan.HeaderText = "Kelurahan";
            this.c_kecamatan.MinimumWidth = 6;
            this.c_kecamatan.Name = "c_kecamatan";
            this.c_kecamatan.ReadOnly = true;
            this.c_kecamatan.Width = 550;
            // 
            // tkelurahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.tblKelurahan);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tkelurahan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tkelurahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKelurahan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.DataGridView tblKelurahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kecamatan;
    }
}

