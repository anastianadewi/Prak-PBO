using PercobaanPPC.model;
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
        private KecamatanModel model = new KecamatanModel();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Ambil nama kecamatan dari textbox
            string name = tbName.Text.Trim();

            // Set nama kecamatan di model
            model.Nama = name;

            // Simpan kecamatan ke database
            int result = model.save();

            if (result > 0)
            {
                MessageBox.Show("Data kecamatan berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kembali ke form tkecamatan setelah berhasil disimpan
                tkecamatan kecamatan = new tkecamatan();
                kecamatan.TopLevel = false;
                kecamatan.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Clear();
                this.Controls.Add(kecamatan);
                kecamatan.Show();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data kecamatan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
