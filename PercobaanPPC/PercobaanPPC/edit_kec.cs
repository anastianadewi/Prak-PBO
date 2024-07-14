using PercobaanPPC.model;
using System;
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
    public partial class edit_kec : Form
    {
        KecamatanModel model = new KecamatanModel();
        private ulong id; // Variabel untuk menyimpan ID
        public edit_kec(ulong id, string name)
        {
            InitializeComponent();

            // Simpan ID yang diterima dari form sebelumnya
            this.id = id;

            // Tampilkan data pada form
            tbId.Text = id.ToString();
            tbName.Text = name;

        }

        //BUTTON KEMBALI
        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Dapatkan nilai yang diperbarui dari kontrol
            string namaBaru = tbName.Text.Trim();

            // Log nilai sebelum update
            Console.WriteLine($"Updating kecamatan with ID: {id}, Name: {namaBaru}");

            // Perbarui nilai name dalam model
            model.Nama = namaBaru;

            // Perbarui data menggunakan model
            model.Id = id; // Gunakan ID yang disimpan
            int result = model.update();

            // Periksa hasil pembaruan
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kembali ke form sebelumnya
                tkecamatan kecamatan = new tkecamatan();
                kecamatan.TopLevel = false;
                kecamatan.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Clear();
                this.Controls.Add(kecamatan);
                kecamatan.Show();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_kec_Load(object sender, EventArgs e)
        {

        }
    }
}
