using PercobaanPPC;
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
    public partial class login : Form
    {
        private UserModel userModel;
        public login()
        {
            InitializeComponent();
            userModel = new UserModel();
        }

        //BUTTON LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (userModel.login(username, password))
            {
                // Mengambil nama pengguna yang berhasil login
                string loggedInUserName = userModel.Name;
                dashboard tdashboard = new dashboard(loggedInUserName);
                tdashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, User ID atau Password anda salah!",
                    "KESALAHAN", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox1.Select();
                textBox1.Focus();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar dari aplikasi?",
                "KONFIRMASI", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
