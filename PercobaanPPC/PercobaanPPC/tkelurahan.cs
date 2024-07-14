using PercobaanPPC;
using PercobaanPPC.model;
using PercobaanPPC.other;
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
            // Pastikan ada baris yang dipilih
            if (tblKelurahan.SelectedRows.Count > 0)
            {
                // Dapatkan ID dan nama dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblKelurahan.SelectedRows[0].Cells["Id"].Value);
                string name = tblKelurahan.SelectedRows[0].Cells["name"].Value.ToString();

                // Buat instansi dari edit_kec dengan nilai ID dan nama yang diperoleh
                edit_kel edit_Kel = new edit_kel(id, name);

                // Menetapkan properti TopLevel dan FormBorderStyle
                edit_Kel.TopLevel = false;
                edit_Kel.FormBorderStyle = FormBorderStyle.None;

                // Menambahkan form edit_kec langsung ke Controls dari form tkecamatan
                this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
                this.Controls.Add(edit_Kel); // Tambahkan form edit_kec ke form tkecamatan

                // Menampilkan form edit_kec
                edit_Kel.Show();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            LoadData();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {

            // Pastikan ada baris yang dipilih
            if (tblKelurahan.SelectedRows.Count > 0)
            {
                // Dapatkan ID dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblKelurahan.SelectedRows[0].Cells["Id"].Value);

                // Konfirmasi penghapusan
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Hapus data menggunakan model
                    int result = model.delete(id);

                    // Periksa hasil penghapusan
                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh data di tabel
                        tblKelurahan.DataSource = model.getAll();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void LoadData()
        {
            tblKelurahan.DataSource = model.getAll();
            // Optional: Set default sort order here
            tblKelurahan.Sort(tblKelurahan.Columns["Id"], ListSortDirection.Ascending);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get text entered in textBox1
            string searchText = textBox1.Text.Trim();

            // Execute query with parameters using the initialized connection object
            DataTable filteredData = model.getKelurahanByName(searchText);

            // Set data source for DataGridView
            tblKelurahan.DataSource = filteredData;
        }
    }
}
