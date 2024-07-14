using PercobaanPPC.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PercobaanPPC
{
    public partial class tdashboard : Form
    {
        private RecapModel model;
        public tdashboard()
        {
            InitializeComponent();
            model = new RecapModel();
        }

        private void tdashboard_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            DataTable data = model.getAllWithOrder();
            dataGridView1.DataSource = data;
        }

        private void loadChart(string daerah)
        {
            string[] daerahSplit = daerah.Split(',');
            DataTable data = model.getAllByDaerah(daerahSplit[0].Trim(), daerahSplit[1].Trim());
            chart1.DataSource = data;
            chart1.Series["Jumlah"].XValueMember = "penyakit";
            chart1.Series["Jumlah"].YValueMembers = "total";
            chart1.Series["Jumlah"].ChartType = SeriesChartType.Column;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string daerah = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                loadChart(daerah);
            }
        }
    }
}
