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

namespace PercobaanPPC
{
    public partial class dashboard : Form
    {
        int geser = 0;
        private string username; // Menyimpan nama pengguna

        public dashboard(string username)
        {
            InitializeComponent();
            this.username = username; // Menyimpan nama pengguna saat membuat instance dashboard
            label1.Text = "Selamat datang, " + username; // Menampilkan nama pengguna di label
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //Dashboard
            tdashboard dashboard = new tdashboard();
            dashboard.TopLevel = false;
            tabPage1.Controls.Add(dashboard);
            dashboard.Show();
            dashboard.FormBorderStyle = FormBorderStyle.None;

            //Wilayah
            // Membuat instance form tkecamatan
            tkecamatan kecamatan = new tkecamatan();
            kecamatan.TopLevel = false;
            kecamatan.FormBorderStyle = FormBorderStyle.None;
            kecamatan.Dock = DockStyle.Fill;

            // Membersihkan panel sebelum menambahkan form tkecamatan
            panelKecamatan.Controls.Clear();

            // Menambahkan form tkecamatan ke panel
            panelKecamatan.Controls.Add(kecamatan);

            // Menampilkan form tkecamatan
            kecamatan.Show();

            // Mengatur posisi form tkecamatan di dalam panel
            kecamatan.Location = new Point(0, 0); // Sesuaikan dengan posisi yang diinginkan

            // Membuat instance form tkelurahan
            tkelurahan kelurahan = new tkelurahan();
            kelurahan.TopLevel = false;
            kelurahan.FormBorderStyle = FormBorderStyle.None;
            kelurahan.Dock = DockStyle.Fill;
            panelKelurahan.Controls.Clear();

            // Menambahkan form tkelurahan ke panel
            panelKelurahan.Controls.Add(kelurahan);

            // Menampilkan form tkelurahan
            kelurahan.Show();


            //Rekap
            rekap_penyakit trekap = new rekap_penyakit();
            trekap.TopLevel = false;
            tabPage4.Controls.Clear();
            tabPage4.Controls.Add(trekap);
            trekap.Show();
            trekap.FormBorderStyle = FormBorderStyle.None;

            //Penyakit
            // Membuat instance form penyakit
            penyakit tpenyakit = new penyakit();
            tpenyakit.TopLevel = false;
            tpenyakit.FormBorderStyle = FormBorderStyle.None;

            // Membersihkan panel sebelum menambahkan form penyakit
            tabPage3.Controls.Clear();

            // Menambahkan form penyakit ke panel
            tabPage3.Controls.Add(tpenyakit);

            // Menampilkan form penyakit
            tpenyakit.Show();

            //User
            user tuser = new user();
            tuser.TopLevel = false;
            tabPage5.Controls.Clear();
            tabPage5.Controls.Add(tuser);
            tuser.Show();
            tuser.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
