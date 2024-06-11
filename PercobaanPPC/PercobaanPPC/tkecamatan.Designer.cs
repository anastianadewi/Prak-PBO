namespace PercobaanPPC
{
    partial class tkecamatan
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
            this.tblKecamatan = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblKecamatan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Kecamatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari dengan nama";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(345, 82);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(50, 20);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(399, 82);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(50, 20);
            this.btn_hapus.TabIndex = 4;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(453, 82);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(60, 20);
            this.btn_tambah.TabIndex = 5;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // tblKecamatan
            // 
            this.tblKecamatan.AllowUserToAddRows = false;
            this.tblKecamatan.AllowUserToDeleteRows = false;
            this.tblKecamatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKecamatan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama});
            this.tblKecamatan.Location = new System.Drawing.Point(20, 107);
            this.tblKecamatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblKecamatan.Name = "tblKecamatan";
            this.tblKecamatan.ReadOnly = true;
            this.tblKecamatan.RowHeadersWidth = 62;
            this.tblKecamatan.RowTemplate.Height = 28;
            this.tblKecamatan.Size = new System.Drawing.Size(493, 98);
            this.tblKecamatan.TabIndex = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "name";
            this.nama.HeaderText = "Kecamatan";
            this.nama.MinimumWidth = 8;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 525;
            // 
            // tkecamatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.tblKecamatan);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tkecamatan";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.tkecamatan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKecamatan)).EndInit();
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
        private System.Windows.Forms.DataGridView tblKecamatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
    }
}