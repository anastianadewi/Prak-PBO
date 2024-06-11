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

namespace WindowsFormsApp1
{
    public partial class tkelurahan : Form
    {
        KelurahanModel model=new KelurahanModel();
        public tkelurahan()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Membuat instance form edit_kec
            edit_kel editkel = new edit_kel();

            // Menetapkan properti TopLevel dan FormBorderStyle
            editkel.TopLevel = false;
            editkel.FormBorderStyle = FormBorderStyle.None;

            // Menambahkan form edit_kec langsung ke Controls dari form tkecamatan
            this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
            this.Controls.Add(editkel); // Tambahkan form edit_kec ke form tkecamatan

            // Menampilkan form edit_kec
            editkel.Show();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            // Membuat instance form edit_kec
            tambah_kel tambahkel = new tambah_kel();

            // Menetapkan properti TopLevel dan FormBorderStyle
            tambahkel.TopLevel = false;
            tambahkel.FormBorderStyle = FormBorderStyle.None;

            // Menambahkan form edit_kec langsung ke Controls dari form tkecamatan
            this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
            this.Controls.Add(tambahkel); // Tambahkan form edit_kec ke form tkecamatan

            // Menampilkan form edit_kec
            tambahkel.Show();
        }

        private void tkelurahan_Load(object sender, EventArgs e)
        {
            tblKelurahan.DataSource = model.getAll();
        }
    }
}
