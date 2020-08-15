using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class Account
    {
        public Account(string username, string displayname, int type, int idPersonnel, string password = null)
        {
            this.UserName = username;
            this.DisplayName = displayname;
            this.PassWord = password;
            this.Type = type;
            this.IDpersonnel = idPersonnel;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.Type = (int)row["type"];
            this.IDpersonnel =(int)row["idPersonnel"];
        }

        private int iDpersonnel;

        public int IDpersonnel
        {
            get { return iDpersonnel; }
            set { iDpersonnel = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
