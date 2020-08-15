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
    public partial class mgReportMonth : Form
    {
        public mgReportMonth()
        {
            InitializeComponent();
            
            LoadDateTime();
            LoadData(dtp_Fromday.Value, dtp_Today.Value);
        }

        void LoadDateTime()
        {
            DateTime today = DateTime.Now;

            dtp_Fromday.Value = new DateTime(today.Year, today.Month, 1);
            dtp_Today.Value = dtp_Fromday.Value.AddMonths(1).AddDays(-1);
        }

        void LoadData(DateTime from ,DateTime to)
        {
            dgv_DataGid.DataSource = BillDAO.Instance.CreateReportMonth(from, to, Convert.ToInt32(txt_PageNumber.Text));
            txt_Pevenue.Text = BillDAO.Instance.Prevenue(from, to).ToString("c", cons.culture);

            txt_TotalBill.Text = BillDAO.Instance.TotalBill(from, to).ToString();
            AverageBill();
        }

        void AverageBill()
        {
            string Money = txt_Pevenue.Text;
            float money = float.Parse(Money.Split(',')[0].Replace('.', ','));

            int bill = Convert.ToInt32(txt_TotalBill.Text);
            
            txt_AVG.Text = (money / bill).ToString("c", cons.culture);
            
           
        }

        private void btn_ShowReport_Click(object sender, EventArgs e)
        {
            LoadData(dtp_Fromday.Value, dtp_Today.Value);
            AverageBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            txt_PageNumber.Text = "1";
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(txt_TotalBill.Text);

            int last = sum / 10;

            if (sum % 10 != 0)
                last++;
            txt_PageNumber.Text = last.ToString();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txt_PageNumber.Text);

            if (temp == 1)
                txt_PageNumber.Text = "1";
            else
                temp -= 1;
            txt_PageNumber.Text = temp.ToString();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(txt_TotalBill.Text);

            int last = sum / 10;

            if (sum % 10 != 0)
                last++;

            int temp = Convert.ToInt32(txt_PageNumber.Text);
            if (temp < last)
                temp++;
            txt_PageNumber.Text = temp.ToString();
        }

        private void txt_PageNumber_TextChanged(object sender, EventArgs e)
        {
            LoadData(dtp_Fromday.Value, dtp_Today.Value);
        }

        
    }
}
