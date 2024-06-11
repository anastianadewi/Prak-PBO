﻿using System;
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
    public partial class edit_kel : Form
    {
        public edit_kel()
        {
            InitializeComponent();
            
        }
        
        //KEMBALI
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin membatalkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                // Membuat instance form edit_kec
                tkelurahan kelurahan = new tkelurahan();

                // Menetapkan properti TopLevel dan FormBorderStyle
                kelurahan.TopLevel = false;
                kelurahan.FormBorderStyle = FormBorderStyle.None;

                // Menambahkan form edit_kec langsung ke Controls dari form tkecamatan
                this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
                this.Controls.Add(kelurahan); // Tambahkan form edit_kec ke form tkecamatan

                // Menampilkan form edit_kec
                kelurahan.Show();
            }
        }

        //SIMPAN
        private void button1_Click(object sender, EventArgs e)
        {
            // Lakukan proses penyimpanan atau tindakan yang diperlukan di sini

            
        }
    }
}
