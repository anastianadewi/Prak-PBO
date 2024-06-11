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
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width += 5;
            if (flowLayoutPanel1.Width >= 801)
            {
                timer1.Stop();
                login fm2 = new login();
                fm2.Show();
                this.Hide();
            }
        }
    }
}
