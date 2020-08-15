using CoffeeHomeMake.DAO;
using CoffeeHomeMake.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHomeMake
{
    public partial class Restaurant : Form
    {

        #region Properties
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        private int iDBill;

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }

        private string nameStaff;

        public string NameStaff
        {
            get { return nameStaff; }
            set { nameStaff = value; }
        }

        private int disCount;

        public int DisCount
        {
            get { return disCount; }
            set { disCount = value; }
        }

        #endregion

        public Restaurant(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

            txt_IDPersonnel.Text = acc.IDpersonnel.ToString();
            LoadEveryThings();
            
        }

        #region Methods
        void LoadEveryThings()
        {
            LoadTableFood();
            LoadCategory();
            TimeSystem.Start(); // Hiển thị thời gian
            LoadNameOfStaff();
            LoadComboSwitchTable();

        }

        void LoadNameOfStaff()
        {
            int id = Convert.ToInt32(txt_IDPersonnel.Text);
            txt_StaffName.Text = PersonnelDAO.Instance.GetNamebyIDPersonnel(id);
        }

        void LoadCategory()
        {
            flp_Category.Controls.Clear();
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            foreach (Category item in listCategory)
            {
                Button btn_Cate = new Button()
                {
                    Width = cons.Category_Width,
                    Height = cons.Category_Height,
                };
                Font f = new Font("Sitka Display", 14);
                btn_Cate.Font = f;
                btn_Cate.TextAlign = ContentAlignment.TopCenter;
                btn_Cate.BackgroundImageLayout = ImageLayout.Stretch;
                btn_Cate.FlatStyle = FlatStyle.Flat;
                btn_Cate.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\icon3.png");
                btn_Cate.Text = item.Name;

                btn_Cate.Tag = item;
                btn_Cate.Click += btn_Cate_Click;

                flp_Category.Controls.Add(btn_Cate);
            }
        }

        void LoadProductByIDCategory(int idCategory)
        {
            flp_DetailCategory.Controls.Clear();
            List<Product> list = ProductDAO.Instance.GetListProductbyIdCategory(idCategory);
            foreach (Product item in list)
            {
                Button btn_Food = new Button()
                {
                    Width = cons.Food_Width,
                    Height = cons.Food_Height
                };
                Font f = new Font("Sitka Display", 12);
                btn_Food.Font = f;
                btn_Food.Text = item.Name + Environment.NewLine + item.Price.ToString("c", cons.culture);
                btn_Food.ForeColor = Color.White;
                btn_Food.BackColor = Color.FromArgb(238, 121, 66); //238 118 33
                btn_Food.FlatStyle = FlatStyle.Flat;
                btn_Food.Tag = item;
                btn_Food.Click += btn_Food_Click;

                flp_DetailCategory.Controls.Add(btn_Food);
            }
        }

        void LoadTableFood()
        {
            flp_Table.Controls.Clear();
            List<TableFood> listTable = TableFoodDAO.Instance.GetListTableFood();
            foreach (TableFood item in listTable)
            {
                Button btn = new Button()
                {
                    Width = cons.Table_Width,
                    Height = cons.Table_Height
                };

                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Quicksand Medium", 12);
                btn.FlatStyle = FlatStyle.Flat;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(255, 130, 71);
                        break;
                    default:
                        btn.Text = item.Name + Environment.NewLine + item.Status + Environment.NewLine + DateTime.Now.ToString("hh:mm:ss");
                        btn.BackColor = Color.FromArgb(0, 139, 0);
                        break;
                }
                btn.Tag = item;

                btn.Click += btn_Click;

                flp_Table.Controls.Add(btn);
            }
        }

        void ShowBill(int idTable)
        {
            lv_Bill.Items.Clear();
            float total = 0;
            int count = 0;
            List<MenuBill> list = MenuBillDAO.Instance.GetDetailBillInfoByIdTable(idTable);
            foreach (MenuBill item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.IDProduct.ToString());
                lvItem.SubItems.Add(item.Name.ToString());
                lvItem.SubItems.Add(item.Price.ToString("c", cons.culture));
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Total.ToString("c", cons.culture));

                Font f = new Font("Times New Roman", 12);
                lvItem.Font = f;
                total += item.Total;
                count += item.Count;

                lv_Bill.Items.Add(lvItem);
            }
            lb_totalPrice.Text = total.ToString("c", cons.culture);
            lb_count.Text = count.ToString();
        }

        void LoadComboSwitchTable()
        {
            cbb_FromTable.DataSource = TableFoodDAO.Instance.GetListTableFood(); cbb_ToTable.DataSource = TableFoodDAO.Instance.GetListTableFood();
            cbb_FromTable.DisplayMember = "name"; cbb_ToTable.DisplayMember = "name";
        }

        void CheckOut(int idBill, int discount, float realPay)
        {
            BillDAO.Instance.CheckOut(idBill, discount, realPay);
        }

        void DeleteProduct(int idBill ,int idProduct)
        {
            BillInfoDAO.Instance.DeleteCountInBillInfo(idBill, idProduct);   
        }

        void SwitchTable()
        {
            int id1 = (cbb_FromTable.SelectedItem as TableFood).ID;
            int id2 = (cbb_ToTable.SelectedItem as TableFood).ID;
            int idPersonnel = Convert.ToInt32(txt_IDPersonnel.Text);

            if(id1 == id2)
            {
                return;
            }

            if(TableFoodDAO.Instance.SwitchTable(id1, id2, idPersonnel) > 0)
            {
                MessageBox.Show("Chuyển bàn thành công !!!");
            }
        }

        void CombineTable()
        {
            int id1 = (cbb_FromTable.SelectedItem as TableFood).ID;
            int id2 = (cbb_ToTable.SelectedItem as TableFood).ID;
            int idPersonnel = Convert.ToInt32(txt_IDPersonnel.Text);

            if(id1 == id2)
            {
                return;
            }

            if (TableFoodDAO.Instance.CombineTable(id1, id2, idPersonnel) > 0)
            {
                MessageBox.Show("Gộp bàn thành công !!!");
            }
        }
        #endregion

        #region Events

        void btn_Food_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = Convert.ToInt32(lb_TenBan.Text);

                int idBill = BillDAO.Instance.GetUnCheckBillbyIdTable(idTable);
                int idPersonnel = Convert.ToInt32(txt_IDPersonnel.Text);
                int idProduct = ((sender as Button).Tag as Product).ID;
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(idTable, idPersonnel);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), idProduct);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, idProduct);
                }

                ShowBill(idTable);
                LoadTableFood();
            }
            catch { return; }
        }

        void btn_Cate_Click(object sender, EventArgs e)
        {
            int idCategory = ((sender as Button).Tag as Category).ID;
            LoadProductByIDCategory(idCategory);
        }

        void btn_Click(object sender, EventArgs e)
        {
            int idTable = ((sender as Button).Tag as TableFood).ID;
            lb_SoBill.Text = lb_TenBan.Text = ((sender as Button).Tag as TableFood).ID.ToString();
            lv_Bill.Tag = (sender as Button).Tag;
            ShowBill(idTable);
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeSystem_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(lb_disCount.Text);
            if (temp < 90)
            {
                temp += 10;
            }
            lb_disCount.Text = temp.ToString();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(lb_disCount.Text);
            if (temp <= 0)
            {
                lb_disCount.Text = "0";
            }
            else
            {
                temp -= 10;
                lb_disCount.Text = temp.ToString();
            }
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = Convert.ToInt32(lb_TenBan.Text);
                
                IDBill = BillDAO.Instance.GetUnCheckBillbyIdTable(idTable);

                if (IDBill != -1)
                {
                    int discount = Convert.ToInt32(lb_disCount.Text);
                    BillCheckOut f = new BillCheckOut(IDBill, txt_StaffName.Text, discount);
                    f.CheckOut += f_CheckOut;
                    f.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            catch { return; }
        }

        void f_CheckOut(object sender, EventArgs e)
        {
            int idTable = Convert.ToInt32(lb_TenBan.Text);
            ShowBill(idTable);
            LoadTableFood();
            lb_disCount.Text = "0";
        }

        private void Restaurant_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                TableFood table = lv_Bill.Tag as TableFood;
                int id = Convert.ToInt32(txt_Product.Text);
                int idTable = Convert.ToInt32(lb_TenBan.Text);

                int idBill = BillDAO.Instance.GetUnCheckBillbyIdTable(idTable);
                DeleteProduct(idBill, id);
                ShowBill(table.ID);
            }
            catch
            {
                return;
            }
        }

        private void lv_Bill_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lv_Bill.SelectedItems[0];

            txt_Product.Text = item.SubItems[0].Text;
        }

        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            SwitchTable();
            LoadTableFood();
        }

        private void btn_Combine_Click(object sender, EventArgs e)
        {
            CombineTable();
            LoadTableFood();
        }
        #endregion

    }
}