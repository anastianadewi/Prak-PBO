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
        int counter = 0;
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 1;
            if (counter >=3)
            {
                timer1.Stop();
                login fm2 = new login();
                fm2.Show();
                this.Hide();
            }
        }
    }
}
