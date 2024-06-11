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

namespace WindowsFormsApp1
{
    public partial class penyakit : Form
    {
        PenyakitModel model;
        public penyakit()
        {
            InitializeComponent();
            DatabaseConfig con = new DatabaseConfig(); // Ini hanya contoh, pastikan Anda menggunakan objek DatabaseConfig yang valid
            model = new PenyakitModel(con);
        }

        private void penyakit_Load(object sender, EventArgs e)
        {
            tblPenyakit.DataSource = model.getAll();
        }

       
    }
}
