using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeHomeMake.DTO;
using CoffeeHomeMake.DAO;

namespace CoffeeHomeMake
{
    public partial class ImportCoupon : Form
    {
        public ImportCoupon()
        {
            InitializeComponent();

            LoadEveryThings();
        }

        #region Methods
        void LoadEveryThings()
        {
            LoadDataList();
            LoadCategoryMaterial();
            LoadPersonnel();

            cbb_MaterialCategory.SelectedItem = null;
            cbb_Staff.SelectedItem = null;
            num_count.Value = 0;
        }

        void LoadDataList()
        {
            lv_list.Items.Clear();

            List<ImportGoods> list = ImportGoodsDAO.Instance.GetListImport();

            foreach (ImportGoods item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.ID.ToString());
                lvItem.SubItems.Add(item.TheDay.ToString("dd-MM-yyyy"));
                lvItem.SubItems.Add(item.NameStaff);
                lvItem.SubItems.Add(item.Supplier);
                lvItem.SubItems.Add(item.Material);
                lvItem.SubItems.Add(item.Price.ToString("c", cons.culture));
                lvItem.SubItems.Add(item.Unit);
                lvItem.SubItems.Add(item.Weight.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Total.ToString("c", cons.culture));

                lv_list.Items.Add(lvItem);
            }
        }

        void LoadCategoryMaterial()
        {
            cbb_MaterialCategory.DataSource = MaterialDAO.Instance.GetListMaterial();
            cbb_MaterialCategory.DisplayMember = "name";
            cbb_MaterialCategory.ValueMember = "id";
        }

        void LoadPersonnel()
        {
            cbb_Staff.DataSource = PersonnelDAO.Instance.GetListStaffOnWork();
            cbb_Staff.DisplayMember = "name";
            cbb_Staff.ValueMember = "id";
        }

        void AddNewImportGoods()
        {
            DateTime date = dtp_DateImport.Value;
            int idPersonnel = Convert.ToInt32(cbb_Staff.SelectedValue);
            int idMaterial = Convert.ToInt32(cbb_MaterialCategory.SelectedValue);
            int count = Convert.ToInt32(num_count.Value);

            if (cbb_MaterialCategory.SelectedItem == null || cbb_Staff.SelectedItem == null)
            {
                MessageBox.Show("Biết nhập cái gì khi thí chủ chưa chọn vật liệu or tên nhân viên !!!");
            }
            else if (num_count.Value == 0)
            {
                MessageBox.Show("Số lượng không thể bằng 0.");
            }
            else
            {
                if (ImportGoodsDAO.Instance.InsertImportGoods(date, idPersonnel, idMaterial, count) > 0)
                {
                    MessageBox.Show("Nhập mới thành công !!!");
                }
                else
                {
                    MessageBox.Show("Thất bại.");
                }
            }
        }
        #endregion

        #region Events

        private void btn_inImportGoods_Click(object sender, EventArgs e)
        {
            mgStoreHouse mghouse = new mgStoreHouse();
            this.Hide();
            mghouse.AddnewMaterial += mghouse_AddnewMaterial;
            mghouse.Update1Material += mghouse_UpdateMaterial;
            mghouse.ShowDialog();
            this.Show();
        }

        void mghouse_UpdateMaterial(object sender, EventArgs e)
        {
            LoadCategoryMaterial();
        }

        void mghouse_AddnewMaterial(object sender, EventArgs e)
        {
            LoadCategoryMaterial();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddNewImportGoods();
            LoadDataList();
            LoadEveryThings();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadEveryThings();
        }
        #endregion

    }
}
