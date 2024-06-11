using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercobaanPPC
{
    public partial class tambah_kec : Form
    {
        public tambah_kec()
        {
            InitializeComponent();
        }

        //BUTTON KEMBALI
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin membatalkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Membuat instance form tambah_kec
                tkecamatan kecamatan = new tkecamatan();

                // Menetapkan properti TopLevel dan FormBorderStyle
                kecamatan.TopLevel = false;
                kecamatan.FormBorderStyle = FormBorderStyle.None;

                // Menyembunyikan form tkecamatan
                this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
                this.Controls.Add(kecamatan);

                // Menampilkan form tambah_kec
                kecamatan.Show();
            }

        }
    }
}
