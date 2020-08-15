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
    public partial class mgProduct : Form
    {
        bool action;

        public mgProduct()
        {
            InitializeComponent();
            LoadDataGid();
            LoadCBBCategories();
            LoadCBB_CategorySort();
        }

        #region Methods
        void LoadDataGid()
        {
            dgv_DataGid.DataSource = ProductDAO.Instance.GetListProductByPageNumber(Convert.ToInt32(txt_PageNumber.Text));
        }
        
        void LoadCBBCategories()
        {
            cbb_Category.DataSource = CategoryDAO.Instance.GetListCategory();
            cbb_Category.DisplayMember = "name";
            cbb_Category.ValueMember = "id";
        }

        void LoadCBB_CategorySort()
        {
            cbb_Sort.DataSource = CategoryDAO.Instance.GetListCategory();
            cbb_Sort.DisplayMember = "name";
            cbb_Sort.ValueMember = "id";
        }

        void AddNewProduct()
        {
            string name = txt_Name.Text;

            int idCate = Convert.ToInt32(cbb_Category.SelectedValue.ToString());

            string price = txt_Price.Text;

            if (cons.IsNumber(price))
            {
                ProductDAO.Instance.AddProduct(name, float.Parse(price), idCate);
                MessageBox.Show("Thêm mới thành công !!!");
            }
            else
            {
                MessageBox.Show("Đơn giá phải là giá trị số !!!");
            }

        }

        void UpdateProduct()
        {
            try
            {
                string name = txt_Name.Text;
                string price = txt_Price.Text;
                int idCategory = Convert.ToInt32(cbb_Category.SelectedValue.ToString());

                if (txt_Name.Text == "" || txt_Price.Text == "")
                {
                    MessageBox.Show("Thí chủ phải nhập đầy đủ thông tin phía trên.");
                }
                else if (cons.IsNumber(price) == true)
                {
                    ProductDAO.Instance.UpdateProduct(Convert.ToInt32(txt_ID.Text), name, float.Parse(txt_Price.Text), idCategory);
                    MessageBox.Show("Cập nhật thành công !!!");
                    ClearDataTextBox();
                }
                else
                {
                    MessageBox.Show("Đơn giá phải là giá trị số !!!");
                }
            }
            catch
            {
                return;
            }
        }

        void DeleteProduct()
        {
            int id = Convert.ToInt32(txt_ID.Text);

            ProductDAO.Instance.DeleteProduct(id);
        }

        void ClearDataTextBox()
        {
            txt_ID.Text = txt_Name.Text = txt_Price.Text = "";
            cbb_Category.SelectedItem = null;
        }

        void CellClick()
        {
            int POS = dgv_DataGid.CurrentCell.RowIndex;

            txt_ID.Text = dgv_DataGid.Rows[POS].Cells[0].Value.ToString();
            txt_Name.Text = dgv_DataGid.Rows[POS].Cells[1].Value.ToString();
            txt_Price.Text = dgv_DataGid.Rows[POS].Cells[2].Value.ToString();
        }

        void SortByCategory(int id)
        {
            dgv_DataGid.DataSource = ProductDAO.Instance.SortProductByCategory(id);
        }
        #endregion

        #region Events

        private void btn_Watch_Click(object sender, EventArgs e)
        {
            LoadDataGid();
            ClearDataTextBox();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            action = true;
            txt_Name.Text = txt_Price.Text = txt_ID.Text = "";
            MessageBox.Show("Nhập vào các trường bên trên để thêm mới 1 sản phẩm !!!");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(action == true)
            {
                AddNewProduct();
            }
            else
            {
                UpdateProduct();
            }
            LoadDataGid();
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            action = false;

            CellClick();

            cbb_Category.SelectedValue = CategoryDAO.Instance.GetCategoryByIDProduct(Convert.ToInt32(txt_ID.Text));
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string name = txt_Find.Text;
            dgv_DataGid.DataSource = ProductDAO.Instance.FindSomeThings(name);
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mgProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thí chủ có chắc chắn muốn thoát ?", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CellClick();
            if(MessageBox.Show(String.Format("Tất cả dữ liệu liên quan đến món {0} sẽ bị xóa vĩnh viễn bao gồm cả những hóa đơn bán lẻ trong quá khứ \n Xác nhận trước khi thực hiện", txt_Name.Text), "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteProduct();
                MessageBox.Show("Thao tác thành công !!!");
            }
            LoadDataGid();
            ClearDataTextBox();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbb_Sort.SelectedValue);
            SortByCategory(id);
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            txt_PageNumber.Text = "1";
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txt_PageNumber.Text);

            if (temp == 1)
                txt_PageNumber.Text = "1";
            else
            {
                temp -= 1;
            }
            txt_PageNumber.Text = temp.ToString();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int Sum = ProductDAO.Instance.GetNumberTotalProduct();

            int lastPage = Sum / 10;

            if (Sum % 10 != 0)
            {
                lastPage++;
            }

            int temp = Convert.ToInt32(txt_PageNumber.Text);
            if (temp < lastPage)
            {
                temp += 1;
            }
            txt_PageNumber.Text = temp.ToString();
        }

        private void txt_PageNumber_TextChanged(object sender, EventArgs e)
        {
            LoadDataGid();
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            int Sum = ProductDAO.Instance.GetNumberTotalProduct();

            int lastPage = Sum / 10;

            if (Sum % 10 != 0)
            {
                lastPage++;
            }
            txt_PageNumber.Text = lastPage.ToString();
        }

        #endregion

    }
}
