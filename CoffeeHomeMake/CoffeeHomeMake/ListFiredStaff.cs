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
    public partial class ListFiredStaff : Form
    {
        public ListFiredStaff()
        {
            InitializeComponent();
            LoadListFired();
        }

        void LoadListFired()
        {
            lv_Fired.Items.Clear();

            List<PersonnelInfo> list = PersonnelInfoDAO.Instance.GetListFiredStaff();

            foreach(PersonnelInfo item in list)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());
                lvItem.SubItems.Add(item.Address.ToString());
                lvItem.SubItems.Add(item.CMND.ToString());
                lvItem.SubItems.Add(item.DateAtWork.ToString("dd-MM-yyyy"));
                lvItem.SubItems.Add(item.DateLeave.ToString());
                lvItem.SubItems.Add(item.Location.ToString());
                lvItem.SubItems.Add(item.Position.ToString());

                lv_Fired.Items.Add(lvItem);
            }
        }
    }
}
