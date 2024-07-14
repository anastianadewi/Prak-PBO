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
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    public partial class edit_kel : Form
    {
        KelurahanModel model = new KelurahanModel();
        private ulong id; // Variabel untuk menyimpan ID
        public edit_kel(ulong id, string name)
        {
            InitializeComponent();
            // Simpan ID yang diterima dari form sebelumnya
            this.id = id;

            // Tampilkan data pada form
            tbId.Text = id.ToString();
            tbName.Text = name;

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
                tkelurahan kelurahan = new tkelurahan();
                kelurahan.TopLevel = false;
                kelurahan.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Clear();
                this.Controls.Add(kelurahan);
                kelurahan.Show();
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
