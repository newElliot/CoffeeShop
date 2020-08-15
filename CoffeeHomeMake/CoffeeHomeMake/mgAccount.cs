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
    public partial class mgAccount : Form
    {
        public mgAccount()
        {
            InitializeComponent();
            LoadComboboxStaff();
            cbb_Staff.SelectedItem = null;
        }

        void LoadComboboxStaff()
        {
            cbb_Staff.DataSource = PersonnelDAO.Instance.GetListStaffOnWorkAndHaveAccount();
            cbb_Staff.DisplayMember = "name";
            cbb_Staff.ValueMember = "id";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string pass = txt_Pass.Text;
            string displayname = txt_DisPlayName.Text;
            int idPersonnel = Convert.ToInt32(cbb_Staff.SelectedValue);

            if (txt_UserName.Text == "" || txt_Pass.Text == "" || txt_DisPlayName.Text == "")
            {
                MessageBox.Show("Thí chủ phải điền đầy đủ thông tin !!!");
            }
            else if (cbb_Staff.SelectedItem == null)
            {
                MessageBox.Show("Nhân viên và chức vụ nhân viên chưa có giá trị!!!");
            }
            else
            {
                if (AccountDAO.Instance.AddNewAccount(username, pass, displayname, idPersonnel) > 0)
                {
                    MessageBox.Show("Đã tạo mới tài khoản thành công !!!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
