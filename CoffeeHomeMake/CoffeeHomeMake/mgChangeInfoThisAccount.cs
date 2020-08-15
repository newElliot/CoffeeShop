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
    public partial class mgChangeInfoThisAccount : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public mgChangeInfoThisAccount(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadInfoAccount();
        }

        void LoadInfoAccount()
        {
            txt_UserName.Text = LoginAccount.UserName;
            txt_DisplayName.Text = LoginAccount.DisplayName;
            
        }
    }
}
