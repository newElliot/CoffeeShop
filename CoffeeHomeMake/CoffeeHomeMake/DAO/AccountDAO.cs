using CoffeeHomeMake.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHomeMake.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        /// <summary>
        /// Đăng nhập thành công
        /// </summary>
        /// <returns></returns>
        public bool LogInSuccessfull(string userName, string passWord)
        {
            byte[] tempPass = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(tempPass);

            string hashPass = "";

            foreach (byte item in hasData)
            {
                hashPass += item;
            }

            string query = "USP_LogIn @userName , @passWord";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, hashPass });

            return data.Rows.Count > 0;
        }

        public Account GetAccountbyUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Account where userName = '"+ userName +"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public int AddNewAccount(string userName, string pass, string displayName, int idPersonnel)
        {
            byte[] tempPass = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(tempPass);

            string hashPass = "";

            foreach(byte item in hashData)
            {
                hashPass += item;
            }

            string query = "USP_AddNewAccount @userName , @pass , @displayName , @idPersonnel";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userName, hashPass, displayName, idPersonnel });

            return result;
        }

        //public int UpdateAccount(string userName, string displayName, string pass, string newpass)
        //{
        //    int result;

        //    return result;
        //}

    }
}
