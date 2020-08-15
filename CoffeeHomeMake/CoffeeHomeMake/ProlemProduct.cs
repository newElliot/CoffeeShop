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
    public partial class ProlemProduct : Form
    {
        public ProlemProduct(DateTime dateIn, DateTime dateOut)
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            label1.Text = "TOP NHỮNG MÓN CÓ DOANH THU THẤP NHẤT TRONG THÁNG " + today.Month + " NĂM " + today.Year;
            LoadDataList(dateIn, dateOut);

        }

        void LoadDataList(DateTime datein, DateTime dateout)
        {
            lv_Prolem.Items.Clear();

            List<ProlemProductList> list = ProlemProductDAO.Instance.GetListProductProlem(datein, dateout);

            foreach(ProlemProductList item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());
                lvItem.SubItems.Add(item.Price.ToString("c", cons.culture));
                lvItem.SubItems.Add(item.TotalCount.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString("c", cons.culture));

                lv_Prolem.Items.Add(lvItem);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProlemProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thí chủ có chắc chắn muốn thoát ???", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
