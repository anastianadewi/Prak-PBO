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
    public partial class tkecamatan : Form
    {
        KecamatanModel model = new KecamatanModel();
        public tkecamatan()
        {
            InitializeComponent();
        }

        private void tkecamatan_Load(object sender, EventArgs e)
        {
            tblKecamatan.DataSource = model.getAll();
        }

        //BUTTON EDIT
        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Membuat instance form edit_kec
            edit_kec editkec = new edit_kec();

            // Menetapkan properti TopLevel dan FormBorderStyle
            editkec.TopLevel = false;
            editkec.FormBorderStyle = FormBorderStyle.None;

            // Menambahkan form edit_kec langsung ke Controls dari form tkecamatan
            this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
            this.Controls.Add(editkec); // Tambahkan form edit_kec ke form tkecamatan

            // Menampilkan form edit_kec
            editkec.Show();
        }

        //BUTTON TAMBAH
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            // Membuat instance form tambah_kec
            tambah_kec tambahkec = new tambah_kec();

            // Menetapkan properti TopLevel dan FormBorderStyle
            tambahkec.TopLevel = false;
            tambahkec.FormBorderStyle = FormBorderStyle.None;

            // Menyembunyikan form tkecamatan
            this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
            this.Controls.Add(tambahkec);

            // Menampilkan form tambah_kec
            tambahkec.Show();
        }
    }
}
