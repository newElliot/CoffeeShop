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
    public partial class ManagermentStaff : Form
    {
        public ManagermentStaff()
        {
            InitializeComponent();
            LoadEveryThings();
            cbb_WorkPlace.SelectedItem = null;
            cbb_pos.SelectedItem = null;
            btn_update.Enabled = false;
            btn_Fired.Enabled = false;
            btn_Detail.Enabled = false;
        }

        #region Methods

        void LoadEveryThings()
        {
            LoadComboboxStaff();
            LoadComboboxWorkPlace();
            LoadComboboxPosition();
            LoadDataStaff();
        }

        void ClearDataBox()
        {
            cbb_pos.SelectedItem = null;
            cbb_WorkPlace.SelectedItem = null;
            txt_Address.Text = txt_CMND.Text  = txt_Name.Text = txt_Salary.Text = "";
            btn_update.Enabled = false;
            lb_MaNV.Text = "#";
        }

        void LoadComboboxWorkPlace()
        {
            cbb_WorkPlace.DataSource = WorkPlaceDAO.Instance.GetListWorkPlace();
            cbb_WorkPlace.DisplayMember = "address";
            cbb_WorkPlace.ValueMember = "id";
        }

        void LoadComboboxPosition()
        {
            cbb_pos.DataSource = PersonnelTypeDAO.Instance.GetListPersonnelType();
            cbb_pos.DisplayMember = "name";
            cbb_pos.ValueMember = "id";
        }

        void LoadWorkPlaceByidPersonnel(int id)
        {
            WorkPlace wp = WorkPlaceDAO.Instance.GetWorkPlaceByIdPersonnel(id);
            cbb_WorkPlace.SelectedItem = wp.Address;
            int index = -1;
            int i = 0;
            foreach (WorkPlace item in cbb_WorkPlace.Items)
            {
                if (item.ID == wp.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbb_WorkPlace.SelectedIndex = i;
        }

        void LoadPositionByIdPersonnel(int id)
        {
            PersonnelType pt = PersonnelTypeDAO.Instance.GetTypeByIdPersonnel(id);
            int index = -1;
            int i = 0;
            foreach(PersonnelType item in cbb_pos.Items)
            {
                if(item.ID == pt.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbb_pos.SelectedIndex = i;
        }

        void LoadInfoPersonnel()
        {
            try
            {
                int id = Convert.ToInt32(lv_Staff.SelectedItems[0].Text);
                PersonnelInfo data = PersonnelInfoDAO.Instance.GetInfoPersonnel(id);

                txt_Name.Text = data.Name;
                txt_Address.Text = data.Address;
                txt_CMND.Text = data.CMND;
                txt_Salary.Text = data.SalaryPerHours.ToString();

                DateTime bornDay = data.BornDay;
                dtp_NgaySinh.Value = bornDay;

                DateTime dateAtWork = data.DateAtWork;
                dtp_DateAtWork.Value = dateAtWork;

                LoadWorkPlaceByidPersonnel(id);
                LoadPositionByIdPersonnel(id);

                int sex = data.Sex;
                if (sex == 1)
                    cb_Sex.Checked = true;
                else
                    cb_Sex.Checked = false;
            }
            catch
            {
                return;
            }
        }

        void LoadDataStaff()
        {
            lv_Staff.Items.Clear();
            List<PersonnelInfo> list = PersonnelInfoDAO.Instance.GetListStaff();

            foreach (PersonnelInfo item in list)
            {
                if (item.Status != "Đã nghỉ việc")
                {
                    ListViewItem lvItem = new ListViewItem(item.ID.ToString());
                    lvItem.SubItems.Add(item.Name.ToString());
                    lvItem.SubItems.Add(item.Address.ToString());
                    lvItem.SubItems.Add(item.BornDay.ToString());
                    lvItem.SubItems.Add(item.Sex.ToString());
                    lvItem.SubItems.Add(item.CMND.ToString());
                    lvItem.SubItems.Add(item.DateAtWork.ToString());
                    lvItem.SubItems.Add(item.SalaryPerHours.ToString("c", cons.culture));
                    lvItem.SubItems.Add(item.WorkPlace.ToString());
                    lvItem.SubItems.Add(item.Location.ToString());
                    lvItem.SubItems.Add(item.Position.ToString());
                    lvItem.SubItems.Add(item.Status.ToString());
                    lvItem.SubItems.Add(item.DateLeave.ToString());
                    lv_Staff.Tag = item;

                    lv_Staff.Items.Add(lvItem);
                }
            }
        }

        void AddNewStaff()
        {
            try
            {
                string name = txt_Name.Text;
                string address = txt_Address.Text;
                DateTime bornday = dtp_NgaySinh.Value;
                string CMND = txt_CMND.Text;
                DateTime dateatwork = dtp_DateAtWork.Value;

                int idWorkPlace = Convert.ToInt32(cbb_WorkPlace.SelectedValue);
                int idPersonnelType = Convert.ToInt32(cbb_pos.SelectedValue);

                

                int sex;
                if (cb_Sex.Checked == true)
                {
                    sex = 1;
                }
                else sex = 0;

                float salary = float.Parse(txt_Salary.Text);
                if (txt_Salary.Text == "" || txt_Name.Text == "" || txt_CMND.Text == "" || txt_Address.Text == "" || cbb_pos.SelectedItem == null || cbb_WorkPlace.SelectedItem == null)
                {
                    MessageBox.Show("Thí chủ phải nhập đầy đủ các thông tin phía trên !!!", "Tao bắn mày nha mậy :((");
                }
                else
                {
                    if (PersonnelInfoDAO.Instance.InsertNewStaff(name, address, sex, bornday, idPersonnelType, idWorkPlace, salary, CMND, dateatwork) > 0)
                    {
                        MessageBox.Show("Thêm mới nhân viên thành công !!!");
                    }
                    else
                    {
                        MessageBox.Show("Có gì đó sai sai ...");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Thí chủ đui hả, nhập thông tin chưa mà đòi thêm !!!");
                return;
            }
        }

        void UpdatePersonnelInfo()
        {
            try
            {
                int id = Convert.ToInt32(lb_MaNV.Text);

                string name = txt_Name.Text;
                string address = txt_Address.Text;
                float salary = float.Parse(txt_Salary.Text);
                string cmnd = txt_CMND.Text;

                DateTime bornday = dtp_NgaySinh.Value;
                DateTime dayAtWork = dtp_DateAtWork.Value;

                int personnelType = Convert.ToInt32(cbb_pos.SelectedValue);
                int workPlace = Convert.ToInt32(cbb_WorkPlace.SelectedValue);

                int sex;
                if (cb_Sex.Checked == true)
                {
                    sex = 1;
                }
                else sex = 0;

                if (txt_Salary.Text == "" || txt_Name.Text == "" || txt_CMND.Text == "" || txt_Address.Text == "" || cbb_pos.SelectedItem == null || cbb_WorkPlace.SelectedItem == null)
                {
                    MessageBox.Show("Thí chủ phải nhập đầy đủ các thông tin phía trên !!!", "Tao bắn mày nha mậy :((");
                }
                else
                {
                    if (MessageBox.Show("Thí chủ chắc chắn muốn thay đổi thông tin ???", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (PersonnelDAO.Instance.UpdatePersonnelInfo(id, name, address, bornday, personnelType, workPlace, salary, cmnd, dayAtWork, sex) > 0)
                        {
                            MessageBox.Show("Cập nhật thành công !!!");
                            ClearDataBox();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thất bại !!!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tác vụ thất bại.");
                return;
            }

        }

        void Fired()
        {
            try
            {
                int id = Convert.ToInt32(lb_MaNV.Text);

                if (MessageBox.Show("Thí chủ có chắc chắn cho nhân viên thôi việc ???", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (PersonnelDAO.Instance.Fired(id) > 0)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        void LoadComboboxStaff()
        {
            cbb_admin.DataSource = PersonnelDAO.Instance.ListAdmin();
            cbb_admin.DisplayMember = "name";

            cbb_cook.DataSource = PersonnelDAO.Instance.ListCook();
            cbb_cook.DisplayMember = "name";

            cbb_waiter.DataSource = PersonnelDAO.Instance.ListService();
            cbb_waiter.DisplayMember = "name";

            cbb_Secu.DataSource = PersonnelDAO.Instance.ListSecurity();
            cbb_Secu.DisplayMember = "name";

            cbb_Ship.DataSource = PersonnelDAO.Instance.ListShipper();
            cbb_Ship.DisplayMember = "name";
        }
        #endregion

        #region Events

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddNewStaff();
            ClearDataBox();
            LoadDataStaff();
            LoadComboboxStaff();
            btn_Detail.Enabled = false;
        }

        private void lv_Staff_MouseClick(object sender, MouseEventArgs e)
        {
            ClearDataBox();
            int id = Convert.ToInt32(lv_Staff.SelectedItems[0].Text);
            lb_MaNV.Text = id.ToString();
            btn_Fired.Enabled = true;
            btn_Detail.Enabled = true;
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            LoadInfoPersonnel();
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdatePersonnelInfo();
            LoadDataStaff();
            LoadComboboxStaff();
            btn_Detail.Enabled = false;
        }

        private void btn_Fired_Click(object sender, EventArgs e)
        {
            Fired();
            LoadDataStaff();
            LoadComboboxStaff();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inFiredList_Click(object sender, EventArgs e)
        {
            ListFiredStaff fired = new ListFiredStaff();
            fired.ShowDialog();
        }

        private void btn_inCreateAccount_Click(object sender, EventArgs e)
        {
            mgAccount acc = new mgAccount();
            acc.ShowDialog();
        }

        #endregion

    }
}
