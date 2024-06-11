using PercobaanPPC;
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
        public login()
        {
            InitializeComponent();
        }

        //BUTTON LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            //TEXTBOX1 USERNAME
            //TEXTBOX2 PASSWORD
            if (textBox1.Text == "anas" && textBox2.Text == "anas")
            {
                string username = textBox1.Text; // Simpan nama pengguna
                dashboard tdashboard = new dashboard(username); // Teruskan nama pengguna ke dashboard
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

       
    }
}
