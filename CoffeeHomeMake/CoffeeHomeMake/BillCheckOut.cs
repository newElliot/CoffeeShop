using CoffeeHomeMake.DAO;
using CoffeeHomeMake.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHomeMake
{
    public partial class BillCheckOut : Form
    {

        public BillCheckOut(int idBill, string nameStaff, int disCount)
        {
            InitializeComponent();
            LoadBill(idBill, nameStaff,disCount);
            PrintBill();
        }

        void LoadBill(int id, string name, int discount)
        {
            lb_IDBill.Text = id.ToString();
            lb_Cashier.Text = name;
            lb_disCount.Text = discount.ToString();
            lb_dateCheckOut.Text = DateTime.Now.ToString();
        }

        void PrintBill()
        {
            int idBill = Convert.ToInt32(lb_IDBill.Text);

            float total = 0;
            int count = 0;
            
            List<MenuBill> list = BillDAO.Instance.PrintBill(idBill);
            
            foreach(MenuBill item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Total.ToString("c", cons.culture));

                total += item.Total;
                count += item.Count;

                lv_Bill.Items.Add(lvItem);
            }

            int discount = Convert.ToInt32(lb_disCount.Text);
            float discounted = total*discount/100;
            float realPay = total - discounted;
            
            lb_Total.Text = total.ToString("c", cons.culture);
            lb_Count.Text = count.ToString();
            lb_MoneyDiscount.Text = discounted.ToString("c", cons.culture);
            lb_realPay.Text = realPay.ToString("c", cons.culture);
        }

       
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PrintAndUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lb_IDBill.Text);
            int discount = Convert.ToInt32(lb_disCount.Text);
            string realPay = lb_realPay.Text;
            float total = float.Parse(realPay.Split(',')[0].Replace('.', ','));

            if (BillDAO.Instance.CheckOutForBill(id, discount, total))
            {
                MessageBox.Show("Thanh toán thành công !");
                checkOut(this, new EventArgs());
                this.Close();
            }
        }

        private event EventHandler checkOut;
        public event EventHandler CheckOut
        {
            add { checkOut += value; }
            remove { checkOut -= value; }
        }
    }
}
