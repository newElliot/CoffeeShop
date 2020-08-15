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
    public partial class mgSupplier : Form
    {
        public mgSupplier()
        {
            InitializeComponent();
            LoadComboboxGroup();
            LoadDataList();
            cbb_Group.SelectedItem = null;
            btn_Update.Enabled = false;
        }

        #region Methods
        void LoadComboboxGroup()
        {
            cbb_Group.DataSource = SupplierTypeDAO.Instance.GetListType();
            cbb_Group.DisplayMember = "name";
            cbb_Group.ValueMember = "id";
        }

        void LoadDataList()
        {
            lv_List.Items.Clear();

            List<SupplierList> list = SupplierListDAO.Instance.GetListSupplierInfo();

            foreach(SupplierList item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.ID.ToString());
                lvItem.SubItems.Add(item.Name);
                lvItem.SubItems.Add(item.Address);
                lvItem.SubItems.Add(item.Phone);
                lvItem.SubItems.Add(item.Group);

                lv_List.Items.Add(lvItem);
            }
        }

        void ClearDataBox()
        {
            txt_address.Text = txt_Name.Text = txt_Phone.Text = "";

            cbb_Group.SelectedItem = null;
            btn_Update.Enabled = false;
        }

        void Add()
        {
            string name = txt_Name.Text;
            string address = txt_address.Text;
            string phone = txt_Phone.Text;

            int idSupplierType = Convert.ToInt32(cbb_Group.SelectedValue);

            if (txt_address.Text == "" || txt_Name.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Thí chủ phải nhập đầy đủ thông tin !!!");
            }
            else if (cbb_Group.SelectedItem == null)
            {
                MessageBox.Show("Không được để trống <Nhóm>");
            }
            else
            {
                if (SupplierDAO.Instance.AddnewSupplier(name, address, phone, idSupplierType) > 0)
                {
                    MessageBox.Show("Thêm mới thành công !!!");
                    
                    LoadDataList();
                    if (addSupplier != null)
                        addSupplier(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Thất bại.");
                }
            }
            ClearDataBox();
        }

        void Detail()
        {
            try
            {
                int id = Convert.ToInt32(lv_List.SelectedItems[0].Text);

                Supplier sp = SupplierDAO.Instance.GetSupplierInfoByid(id);

                txt_Name.Text = sp.Name;
                txt_address.Text = sp.Address;
                txt_Phone.Text = sp.Phone;

                SupplierType st = SupplierTypeDAO.Instance.GetTypeByIDSupplier(id);

                int index = -1;
                int i = 0;

                foreach (SupplierType item in cbb_Group.Items)
                {
                    if (item.ID == sp.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbb_Group.SelectedIndex = i;

            }
            catch
            {
                return;
            }

        }

        //void Update()
        //{
        //    try
        //    {
        //        int id = Convert.ToInt32(lv_List.SelectedItems[0].Text);

        //        string name = txt_Name.Text;
        //        string address = txt_address.Text;
        //        string phone = txt_Phone.Text;
        //        int type = Convert.ToInt32(cbb_Group.SelectedValue);

        //        if (txt_Name.Text == "" || txt_address.Text == "" || txt_Phone.Text == "")
        //        {
        //            MessageBox.Show("Thí chủ không được để trống bất kì thông tin gì !!!");
        //        }
        //        else
        //        {
        //            if (SupplierDAO.Instance.UpdateSupplier(id, name, address, phone, type) > 0)
        //            {
        //                MessageBox.Show("Cập nhật thành công !!!");
        //                LoadDataList();
        //                if (updateSupplier != null)
        //                    updateSupplier(this, new EventArgs());

        //            }
        //            else
        //            {
        //                MessageBox.Show("Thất bại.");
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}
        #endregion

        #region Events
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add();
            LoadDataList();
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
            Detail();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update();
            ClearDataBox();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private event EventHandler addSupplier;
        public event EventHandler AddSupplier
        {
            add { addSupplier += value; }
            remove { addSupplier -= value; }
        }

        private event EventHandler updateSupplier;
        public event EventHandler UpdateSupplier
        {
            add { updateSupplier += value; }
            remove { updateSupplier -= value; }
        }
        #endregion
    }
}
