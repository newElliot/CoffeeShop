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
    public partial class mgStoreHouse : Form
    {
        public mgStoreHouse()
        {
            InitializeComponent();
            num_weight.Value = 0;
            
            LoadComboboxSupplier(cbb_NCC);
            LoadComboboxSort(cbb_LocNCC);
            cbb_NCC.SelectedItem = null;
            cbb_LocNCC.SelectedItem = null;
            LoadListMaterial();

            btn_Update.Enabled = false;
        }

        #region Methods
        
        void LoadComboboxSupplier(ComboBox cbb)
        {
            cbb.DataSource = SupplierDAO.Instance.GetListSupplier();
            cbb.DisplayMember = "name";
            cbb.ValueMember = "id";
        }

        void LoadComboboxSort(ComboBox cbb)
        {
            cbb.DataSource = SupplierDAO.Instance.GetListSupplier();
            cbb.DisplayMember = "name";
            cbb.ValueMember = "id";
        }

        void LoadListMaterial()
        {
            lv_DataMaterial.Items.Clear();

            List<Material> list = MaterialDAO.Instance.GetListMaterial();
            foreach(Material item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.ID.ToString());
                lvItem.SubItems.Add(item.Name.ToString());
                lvItem.SubItems.Add(item.Unit.ToString());
                lvItem.SubItems.Add(item.Weight.ToString());
                lvItem.SubItems.Add(item.Price.ToString("c", cons.culture));
                lvItem.SubItems.Add(item.Supplier.ToString());
                lv_DataMaterial.Items.Add(lvItem);
            }
        }

        void ClearDataBox()
        {
            txt_Name.Text = txt_Price.Text = txt_Unit.Text = "";
            num_weight.Value = 0;
            cbb_NCC.SelectedItem = null;
            btn_Update.Enabled = false;
        }

        void AddNewMaterial()
        {
            string name = txt_Name.Text;
            string unit = txt_Unit.Text;
            string tempPrice = txt_Price.Text;
            float weight = float.Parse(num_weight.Value.ToString());
            if (txt_Name.Text == "" || txt_Price.Text == "" || txt_Unit.Text == "" || cbb_NCC.SelectedItem == null)
            {
                MessageBox.Show("Thí chủ phải nhập đầy đủ thông tin.");
            }
            else if(cons.IsNumber(tempPrice) == false)
            {
                MessageBox.Show("Nhập lại đơn giá.");
            }else if(num_weight.Value == 0)
            {
                MessageBox.Show("Số lượng không thể bằng 0");
            }else
            {
                if(MaterialDAO.Instance.AddnewMaterial(name, unit, weight,float.Parse(txt_Price.Text) , Convert.ToInt32(cbb_NCC.SelectedValue.ToString())) > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    if (addnewMaterial != null)
                        addnewMaterial(this, new EventArgs());
                }
                
            }
            ClearDataBox();
        }

        void DetailMaterial()
        {
            try
            {
                int id = Convert.ToInt32(lv_DataMaterial.SelectedItems[0].Text);
                Material material = MaterialDAO.Instance.DetailMaterial(id);
                txt_Name.Text = material.Name;
                txt_Price.Text = material.Price.ToString();
                txt_Unit.Text = material.Unit;

                num_weight.Value = Convert.ToInt32(material.Weight);

                Supplier sp = SupplierDAO.Instance.GetSupplierByIdMaterial(id);

                int index = -1;
                int i = 0;

                foreach (Supplier item in cbb_NCC.Items)
                {
                    if (item.ID == sp.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbb_NCC.SelectedIndex = i;
            }
            catch
            {
                return;
            }
        }

        void UpdateMaterial()
        {
            try
            {
                int id = Convert.ToInt32(lv_DataMaterial.SelectedItems[0].Text);
                string name = txt_Name.Text;
                string unit = txt_Unit.Text;
                string Tempprice = txt_Price.Text;
                int idSupplier = Convert.ToInt32(cbb_NCC.SelectedValue);
                float weight = float.Parse(num_weight.Value.ToString());
                if (txt_Name.Text == "" || txt_Price.Text == "" || txt_Unit.Text == "")
                {
                    MessageBox.Show("Thí chủ không được để trống dữ liệu khi update.");
                }
                else if (num_weight.Value == 0)
                {
                    MessageBox.Show("Thí chủ không được để trọng lượng hàng bằng 0.");
                }
                else if (cons.IsNumber(txt_Price.Text) == false)
                {
                    MessageBox.Show("Thí chủ không được nhập đơn giá bằng chữ.");
                }
                else
                {
                    if (MaterialDAO.Instance.UpdateMaterial(id, name, unit, weight, float.Parse(Tempprice), idSupplier) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công !");
                        if (update1Material != null)
                            update1Material(this, new EventArgs());
                    }
                    LoadListMaterial();
                }
            }
            catch 
            {
                return;
            }
        }

        void SortBySupplier()
        {
            lv_DataMaterial.Items.Clear();

            int id = Convert.ToInt32(cbb_LocNCC.SelectedValue);
            List<Material> list = MaterialDAO.Instance.GetListMaterialBelongToSupplier(id);

            foreach (Material item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.ID.ToString());
                lvItem.SubItems.Add(item.Name.ToString());
                lvItem.SubItems.Add(item.Unit.ToString());
                lvItem.SubItems.Add(item.Weight.ToString());
                lvItem.SubItems.Add(item.Price.ToString("c", cons.culture));
                lvItem.SubItems.Add(item.Supplier.ToString());
                lv_DataMaterial.Items.Add(lvItem);
            }
            
            
        }
        #endregion

        #region Events

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddNewMaterial();
            LoadListMaterial();
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
            DetailMaterial();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateMaterial();
            ClearDataBox();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            SortBySupplier();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inSupplier_Click(object sender, EventArgs e)
        {
            mgSupplier sp = new mgSupplier();
            sp.AddSupplier += sp_AddSupplier;
            sp.UpdateSupplier += sp_UpdateSupplier;
            sp.ShowDialog();
            
        }

        void sp_UpdateSupplier(object sender, EventArgs e)
        {
            LoadComboboxSupplier(cbb_NCC);
        }

        void sp_AddSupplier(object sender, EventArgs e)
        {
            LoadComboboxSupplier(cbb_NCC);
        }

        private event EventHandler addnewMaterial;
        public event EventHandler AddnewMaterial
        {
            add { addnewMaterial += value; }
            remove { addnewMaterial -= value; }
        }


        private event EventHandler update1Material;
        public event EventHandler Update1Material
        {
            add { update1Material += value; }
            remove { update1Material -= value; }
        }
        #endregion

    }
}
