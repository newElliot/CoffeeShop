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
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake
{
    public partial class DetailTatistical : Form
    {
        #region Properties
        private DateTime dateCheckOut;

        public DateTime DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private DateTime dateCheckIn;

        public DateTime DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
        #endregion

        public DetailTatistical()
        {
            
            InitializeComponent();
            LoadMonth();
            LoadChartTop5Sell();
            FillInDetail();
            dtp_From.Hide();
            dtp_To.Hide();
        }
        #region Methods
        void LoadMonth()
        {
            DateTime today = DateTime.Now;
            dtp_From.Value = new DateTime(today.Year, today.Month, 1);
            dtp_To.Value = dtp_From.Value.AddMonths(1).AddDays(-1);
            lb_DoanhThu.Text = BillDAO.Instance.Prevenue(dtp_From.Value, dtp_To.Value).ToString("c", cons.culture);
        }

        void LoadChartTop5Sell()
        {
            DateTime today = DateTime.Now;

            List<Top10Sell> list = Top10SellDAO.Instance.GetListTop5(dtp_From.Value, dtp_To.Value);

            foreach (Top10Sell item in list)
            {
                chart_Product.Series["top10"].Points.AddXY(item.Name, item.TotalCount);
            }
            chart_Product.Titles.Add("TOP 10 MÓN ĐƯỢC THỰC KHÁCH YÊU THÍCH NHẤT THÁNG " + today.Month);
        }

        void FillInDetail()
        {
            lv_DetailTop5.Items.Clear();

            float prevenue = float.Parse(lb_DoanhThu.Text.Split(',')[0].Replace('.', ','));

            List<DetailTop10> list = Top10SellDAO.Instance.GetListDetailTop10(dtp_From.Value, dtp_To.Value, prevenue);

            foreach (DetailTop10 item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Total.ToString("c", cons.culture));
                lvItem.SubItems.Add(item.Percent.ToString() + "%");

                lv_DetailTop5.Items.Add(lvItem);
            }
        }


        #endregion

        #region Events
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailTatistical_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thí chủ chắc chắn muốn thoát ? ", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_More_Click(object sender, EventArgs e)
        {
            ProlemProduct fPro = new ProlemProduct(dtp_From.Value, dtp_To.Value);
            this.Hide();
            fPro.ShowDialog();
            this.Show();
        }

        #endregion
    }
}
