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


        private void timer1_Tick(object sender, EventArgs e)
        {
            geser += 5;
            if(geser >= 1200)
            {
                geser = -400;
            }
            label2.Left = geser;
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

        //DASHBOARD
        private void button1_Click(object sender, EventArgs e)
        {
            tdashboard dashboard = new tdashboard();
            dashboard.TopLevel = false;
            panel6.Controls.Clear();
            panel6.Controls.Add(dashboard);
            dashboard.Show();
            dashboard.FormBorderStyle = FormBorderStyle.None;
        }

        //WILAYAH
        private void button2_Click(object sender, EventArgs e)
        {
            // Membuat instance form tkecamatan
            tkecamatan kecamatan = new tkecamatan();
            kecamatan.TopLevel = false;
            kecamatan.FormBorderStyle = FormBorderStyle.None;

            // Membersihkan panel sebelum menambahkan form tkecamatan
            panel6.Controls.Clear();

            // Menambahkan form tkecamatan ke panel
            panel6.Controls.Add(kecamatan);

            // Menampilkan form tkecamatan
            kecamatan.Show();

            // Mengatur posisi form tkecamatan di dalam panel
            kecamatan.Location = new Point(0, 0); // Sesuaikan dengan posisi yang diinginkan

            // Membuat instance form tkelurahan
            tkelurahan kelurahan = new tkelurahan();
            kelurahan.TopLevel = false;
            kelurahan.FormBorderStyle = FormBorderStyle.None;

            // Menambahkan form tkelurahan ke panel
            panel6.Controls.Add(kelurahan);

            // Menampilkan form tkelurahan
            kelurahan.Show();

            // Mengatur posisi form tkelurahan di dalam panel
            kelurahan.Location = new Point(kecamatan.Width, 0);// Sesuaikan dengan posisi yang diinginkan
        }



        //USER
        private void button5_Click(object sender, EventArgs e)
        {
            user tuser = new user();
            tuser.TopLevel = false;
            panel6.Controls.Clear();
            panel6.Controls.Add(tuser);
            tuser.Show();
            tuser.FormBorderStyle = FormBorderStyle.None;
        }

        //DATA PENYAKIT
        private void button3_Click(object sender, EventArgs e)
        {
            // Membuat instance form penyakit
            penyakit tpenyakit = new penyakit();
            tpenyakit.TopLevel = false;
            tpenyakit.FormBorderStyle = FormBorderStyle.None;

            // Membersihkan panel sebelum menambahkan form penyakit
            panel6.Controls.Clear();

            // Menambahkan form penyakit ke panel
            panel6.Controls.Add(tpenyakit);

            // Menampilkan form penyakit
            tpenyakit.Show();


        }

        //REKAP PENYAKIT
        private void button4_Click(object sender, EventArgs e)
        {
            rekap_penyakit trekap = new rekap_penyakit();
            trekap.TopLevel = false;
            panel6.Controls.Clear();
            panel6.Controls.Add(trekap);
            trekap.Show();
            trekap.FormBorderStyle = FormBorderStyle.None;
        }

        
    }
}
