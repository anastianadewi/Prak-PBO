using PercobaanPPC.model;
using PercobaanPPC.other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            LoadData();
        }

        private void LoadData()
        {
            tblKecamatan.DataSource = model.getAll();
            // Optional: Set default sort order here
            tblKecamatan.Sort(tblKecamatan.Columns["Id"], ListSortDirection.Ascending);
        }

        //BUTTON EDIT
        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (tblKecamatan.SelectedRows.Count > 0)
            {
                // Dapatkan ID dan nama dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblKecamatan.SelectedRows[0].Cells["Id"].Value);
                string name = tblKecamatan.SelectedRows[0].Cells["name"].Value.ToString();

                // Buat instansi dari edit_kec dengan nilai ID dan nama yang diperoleh
                edit_kec editkec = new edit_kec(id, name);

                // Menetapkan properti TopLevel dan FormBorderStyle
                editkec.TopLevel = false;
                editkec.FormBorderStyle = FormBorderStyle.None;

                // Menambahkan form edit_kec langsung ke Controls dari form tkecamatan
                this.Controls.Clear(); // Hapus semua kontrol sebelum menambahkan
                this.Controls.Add(editkec); // Tambahkan form edit_kec ke form tkecamatan

                // Menampilkan form edit_kec
                editkec.Show();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (tblKecamatan.SelectedRows.Count > 0)
            {
                // Dapatkan ID dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblKecamatan.SelectedRows[0].Cells["Id"].Value);

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
                        tblKecamatan.DataSource = model.getAll();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Dapatkan teks yang dimasukkan ke dalam textbox6
            string searchText = textBox1.Text.Trim();
            // Eksekusi query dengan parameter menggunakan objek con yang sudah dideklarasikan di tingkat kelas penyakit
            DataTable filteredData = model.getKecamatanByName(searchText);

            // Set data sumber untuk DataGridView
            tblKecamatan.DataSource = filteredData;
        }
    }
    }

