using PercobaanPPC;
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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class penyakit : Form
    {

        PenyakitModel model;
        public penyakit()
        {
            InitializeComponent();
            model = new PenyakitModel(); 
        }

        private void penyakit_Load(object sender, EventArgs e)
        {
            tblPenyakit.DataSource = model.getAll();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (tblPenyakit.SelectedRows.Count > 0)
            {
                // Dapatkan ID dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblPenyakit.SelectedRows[0].Cells["Id"].Value);

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
                        tblPenyakit.DataSource = model.getAll();
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



        private void button1_Click(object sender, EventArgs e)
        {
            // Dapatkan nilai yang diperbarui dari kontrol
            string namaBaru = tbName.Text.Trim();

            // Pastikan ada baris yang dipilih
            if (tblPenyakit.SelectedRows.Count > 0)
            {
                // Dapatkan ID dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblPenyakit.SelectedRows[0].Cells["Id"].Value);

                // Perbarui nilai name dalam DataGridView
                tblPenyakit.SelectedRows[0].Cells["name"].Value = namaBaru;

                // Perbarui data menggunakan model
                model.Id = id; // Gunakan ID yang disimpan
                model.Name = namaBaru;
                int result = model.update();

                // Periksa hasil pembaruan
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbName.Text = string.Empty;
                    tbId.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Kembalikan nilai asli jika gagal memperbarui (opsional)
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshData()
        {
            // Refresh data di tabel
            tblPenyakit.DataSource = model.getAll();
        }


        private void tblPenyakit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (tblPenyakit.SelectedRows.Count > 0)
            {
                // Dapatkan ID dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblPenyakit.SelectedRows[0].Cells["Id"].Value);

                // Dapatkan nilai yang diperbarui dari kontrol
                string namaBaru = tbName.Text.Trim();

                // Perbarui data menggunakan model
                model.Id = id; // Gunakan ID yang disimpan
                model.Name = namaBaru;
                int result = model.update();

                // Periksa hasil pembaruan
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh data di tabel
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Kembalikan nilai asli jika gagal memperbarui (opsional)
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tblPenyakit_SelectionChanged(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (tblPenyakit.SelectedRows.Count > 0)
            {
                // Dapatkan nilai dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblPenyakit.SelectedRows[0].Cells["Id"].Value);
                string name = tblPenyakit.SelectedRows[0].Cells["name"].Value.ToString();

                // Tampilkan nilai pada textbox
                tbName.Text = name;
                tbId.Text = id.ToString();
            }
            else
            {
                // Kosongkan textbox jika tidak ada baris yang dipilih
                tbName.Text = string.Empty;
                tbId.Text = string.Empty;
            }
        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Dapatkan teks yang dimasukkan ke dalam textbox6
            string searchText = textBox6.Text.Trim();


            // Eksekusi query dengan parameter menggunakan objek con yang sudah dideklarasikan di tingkat kelas penyakit
            DataTable filteredData = model.getPenyakitByName(searchText);

            // Set data sumber untuk DataGridView
            tblPenyakit.DataSource = filteredData;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Ambil nama penyakit dari textbox
            string name = tbName.Text.Trim();

            // Set nama penyakit di model
            model.Name = name;

            // Simpan penyakit ke database
            int result = model.save();

            if (result > 0)
            {
                MessageBox.Show("Data penyakit berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear textbox setelah penyimpanan berhasil
                ClearTextBoxes();

                // Refresh data di tabel
                RefreshData();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data penyakit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            // Mengosongkan nilai teks dari textbox
            tbName.Text = string.Empty;
            tbId.Text = string.Empty;
        }
    }
}
