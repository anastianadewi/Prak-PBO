using PercobaanPPC;
using PercobaanPPC.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tambah_kel : Form
    {
        private KelurahanModel model = new KelurahanModel();

        // Constructor dengan parameter tkelurahan
        public tambah_kel()
        {
            InitializeComponent();
        
        }

        //kembali
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

        //simpan
        private void button1_Click(object sender, EventArgs e)
        {
            // Lakukan proses penyimpanan atau tindakan yang diperlukan di sini
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
                tkelurahan kelurahan = new tkelurahan();
                kelurahan.TopLevel = false;
                kelurahan.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Clear();
                this.Controls.Add(kelurahan);
                kelurahan.Show();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data kecamatan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
