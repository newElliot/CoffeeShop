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
    public partial class mgCategory : Form
    {
        public mgCategory()
        {
            InitializeComponent();
            LoadDataGid();

            TimeSystem.Start();
        }

        bool action;

        #region Methods
        void LoadDataGid()
        {
            dgv_Category.DataSource = CategoryDAO.Instance.LoadCategory();
        }

        void AddNewCategory()
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Không được để trống tên !!!");
                return;
            }
            if (CategoryDAO.Instance.InsertCategory(txt_name.Text) > 0)
            {
                MessageBox.Show("Thêm mới thành công !!!");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            LoadDataGid();
            txt_name.Text = "";
        }

        void FixCategory()
        {
            string name = txt_name.Text;
            int POS = dgv_Category.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgv_Category.Rows[POS].Cells[0].Value);
            if(CategoryDAO.Instance.UpdateCategory(name,id) > 0)
            {
                MessageBox.Show("Update thành công !!!");
            }
            else
            {
                MessageBox.Show("Thất bại !!!");
            }
            LoadDataGid();
            txt_name.Text = "";
        }
        #endregion

        #region Events
        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            MessageBox.Show("Nhập vào khung bên trên để bắt đầu thêm mới Category !!!");
            action = true;
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập vào khung bên trên để bắt đầu sửa tên Category đã chọn !!!");
            action = false;
        }

        private void dgv_Category_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int POS = dgv_Category.CurrentCell.RowIndex;

            txt_name.Text = dgv_Category.Rows[POS].Cells[1].Value.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (action == true)
            {
                AddNewCategory();
            }
            else
            {
                FixCategory();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mgCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thí chủ chắc chắn muốn thoát !!!", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void TimeSystem_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion
    }
}
