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
    public partial class ManagerHome : Form
    {

        #region Properties
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        #endregion

        public ManagerHome(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            lb_hello.Text = lb_hello.Text + acc.DisplayName;
        }

        #region Methods
        void ChangeAccount(int type)
        {
            btn_inManagerStaff.Enabled = btn_inProduct.Enabled = btn_inStoreHouse.Enabled = btn_inCategory.Enabled = type == 1;
        }
        #endregion

        #region Events

        private void btn_inRestaurant_Click(object sender, EventArgs e)
        {
            Restaurant fRestaurant = new Restaurant(LoginAccount);
            this.Hide();
            fRestaurant.ShowDialog();
            this.Show();
        }

        private void btn_inCategory_Click(object sender, EventArgs e)
        {
            mgCategory fCategory = new mgCategory();
            fCategory.ShowDialog();
        }

        private void btn_inProduct_Click(object sender, EventArgs e)
        {
            mgProduct fProduct = new mgProduct();
            fProduct.ShowDialog();
        }

        private void btn_inReportDay_Click(object sender, EventArgs e)
        {
            mgReportPerDay fReport = new mgReportPerDay();
            fReport.ShowDialog();
        }

        private void btn_insTatistical_Click(object sender, EventArgs e)
        {
            mgReportMonth fReportMonth = new mgReportMonth();
            fReportMonth.ShowDialog();
        }

        private void btn_inDetailTatistical_Click(object sender, EventArgs e)
        {
            DetailTatistical detail = new DetailTatistical();
            this.Hide();
            detail.ShowDialog();
            this.Show();
        }

        private void btn_inManagerStaff_Click(object sender, EventArgs e)
        {
            ManagermentStaff ms = new ManagermentStaff();
            this.Hide();
            ms.ShowDialog();
            this.Show();
        }

        private void btn_inStoreHouse_Click(object sender, EventArgs e)
        {
            ImportCoupon import = new ImportCoupon();
            this.Hide();
            import.ShowDialog();
            this.Show();
        }

        private void btn_inPersonnelAccount_Click(object sender, EventArgs e)
        {
            mgChangeInfoThisAccount ChangeInfo = new mgChangeInfoThisAccount(LoginAccount);
            ChangeInfo.ShowDialog();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
