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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PercobaanPPC
{
    public partial class user : Form
    {
        UserModel model = new UserModel();
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            tblUser.DataSource = model.getAll();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox5.Text.Trim();

            DataTable filteredData = model.findUserByName(searchText);

            tblUser.DataSource = filteredData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (tblUser.SelectedRows.Count > 0)
            {
                // Dapatkan ID dari baris yang dipilih
                ulong id = Convert.ToUInt64(tblUser.SelectedRows[0].Cells["Id"].Value);

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
                        tblUser.DataSource = model.getAll();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ambil nama penyakit dari textbox
            string name = tbName.Text.Trim();
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            // Set nama penyakit di model
            model.Name = name;
            model.Username = username;
            model.Password = password;

            // Simpan penyakit ke database
            int result = model.save();

            if (result > 0)
            {
                MessageBox.Show("Data User berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;

        }
        private void RefreshData()
        {
            // Refresh data di tabel
            tblUser.DataSource = model.getAll();
        }
    }
}
