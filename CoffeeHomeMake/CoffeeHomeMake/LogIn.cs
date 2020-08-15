using CoffeeHomeMake.DAO;
using CoffeeHomeMake.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHomeMake
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        void Login(string user, string pass)
        {
            if(AccountDAO.Instance.LogInSuccessfull(user, pass))
            {
                Account Login = AccountDAO.Instance.GetAccountbyUserName(user);

                ManagerHome manager = new ManagerHome(Login);
                this.Hide();
                manager.ShowDialog();
                this.Show();
                txt_PassWord.Text = txt_userName.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc passworld.  Xin thí chủ hãy nhập lại !!!");
            }
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            Login(txt_userName.Text, txt_PassWord.Text);
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Thí chủ có chắc muốn thoát chương trình ?", "Lời cảnh tỉnh", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
