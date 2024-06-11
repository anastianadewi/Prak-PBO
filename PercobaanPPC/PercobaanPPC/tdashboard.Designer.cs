namespace PercobaanPPC
{
    partial class tdashboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c_wilayah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_penyakittertinggi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_wilayah,
            this.c_penyakittertinggi,
            this.c_jumlah});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // c_wilayah
            // 
            this.c_wilayah.HeaderText = "Wilayah";
            this.c_wilayah.MinimumWidth = 8;
            this.c_wilayah.Name = "c_wilayah";
            this.c_wilayah.ReadOnly = true;
            this.c_wilayah.Width = 200;
            // 
            // c_penyakittertinggi
            // 
            this.c_penyakittertinggi.HeaderText = "Penyakit Tertinggi";
            this.c_penyakittertinggi.MinimumWidth = 8;
            this.c_penyakittertinggi.Name = "c_penyakittertinggi";
            this.c_penyakittertinggi.ReadOnly = true;
            this.c_penyakittertinggi.Width = 200;
            // 
            // c_jumlah
            // 
            this.c_jumlah.HeaderText = "Jumlah";
            this.c_jumlah.MinimumWidth = 8;
            this.c_jumlah.Name = "c_jumlah";
            this.c_jumlah.ReadOnly = true;
            this.c_jumlah.Width = 200;
            // 
            // tdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tdashboard";
            this.Text = "tdashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_wilayah;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_penyakittertinggi;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_jumlah;
    }
}