using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public void InsertBillInfo(int idBill, int idProduct)
        {
            DataProvider.Instance.ExcuteNonQuery("USP_InsertBillInfo @idBill , @idProduct", new object[] { idBill, idProduct});
        }

        public int DeleteCountInBillInfo(int idBill, int idProduct)
        {
            int data = DataProvider.Instance.ExcuteNonQuery("USP_DeleteCountBillInfo @idBill , @idProduct", new object[] {idBill , idProduct });

            return data;
        }

        /// <summary>
        /// Xóa những BillInfo nào có chứa IDPRoduct cần xóa
        /// </summary>
        public void DeleteIDProduct(int idProduct)
        {
            string query = "delete BillInfo where idProduct = " + idProduct;

            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
