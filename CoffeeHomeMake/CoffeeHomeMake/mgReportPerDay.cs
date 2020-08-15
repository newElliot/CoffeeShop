using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeHomeMake.DAO;

namespace CoffeeHomeMake
{
    public partial class mgReportPerDay : Form
    {
        public mgReportPerDay()
        {
            InitializeComponent();
        }

        #region Methods
        #endregion

        #region Events

        private void btn_Report_Click(object sender, EventArgs e)
        {
            DateTime Date = dtp_PickDay.Value;

            if(MessageBox.Show("Tạo báo cáo ngày " + Date, "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.USP_ReportPerDayTableAdapter.Fill(this.CoffeeHomeMakeDataSet.USP_ReportPerDay,Date);

                this.rp_Report.RefreshReport();
            }
        }
        #endregion

        private void mgReportPerDay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CoffeeHomeMakeDataSet.USP_ReportPerDay' table. You can move, or remove it, as needed.
            
        }

        private void mgReportPerDay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thí chủ chắc chắn thoát ?", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
