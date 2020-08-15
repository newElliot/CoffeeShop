using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeHomeMake.DTO;
using System.Data;

namespace CoffeeHomeMake.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUnCheckBillbyIdTable(int id)
        {
            string query = "select * from Bill where idTableFood = "+ id +" and checkout = 0";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int idTable, int idPersonnel)
        {
            string query = "USP_InsertBill  @idTableFood , @idPersonnel";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idTable, idPersonnel});        
        }

        public int GetMaxIdBill()
        {
            try 
            {
                return (int)DataProvider.Instance.ExcuteScalar("select Max(id) from Bill");
            }
            catch 
            {
                return 1;
            }
        }

        /// <summary>
        /// Thanh toán hóa đơn cho bàn ăn
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="realPay"></param>
        public void CheckOut(int idBill, int discount, float realPay)
        {
            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), checkOut = 1, " + "discount = " + discount + ", realPay = " + realPay + " WHERE id = " + idBill;
            
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public List<MenuBill> PrintBill(int idBill)
        {
            List<MenuBill> list = new List<MenuBill>();
            string query = "select p.id ,p.name, p.price, bi.count, p.price*bi.count as [Total] from Bill as b, BillInfo as bi, Product as p where b.id = bi.idBill and p.id = bi.idProduct and b.checkOut = 0 and  idBill = " + idBill;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            
            foreach(DataRow item in data.Rows)
            {
                MenuBill menu = new MenuBill(item);
                list.Add(menu);
            }

            return list;
        }

        public bool CheckOutForBill(int id, int discount, float realPay)
        {
            string query = "update Bill set checkOut = 1, dateCheckOut = GETDATE(), discount = "+ discount +", realPay = "+ realPay +" where id = " + id;

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public void CreateReportPerDay(string date)
        {
            DataProvider.Instance.ExcuteNonQuery("USP_ReportPerDay @date", new object[]{date});
        }


        public DataTable CreateReportMonth(DateTime dateCheckIn, DateTime dateCheckOut, int pageNumber)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListBillByPageNumber @dateCheckIn , @dateCheckOut , @pageNumber", new object[] { dateCheckIn, dateCheckOut, pageNumber });

            return data;
        }

        public Double Prevenue(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            try
            {
                string query = "select SUM(realPay) from Bill as b, Personnel as p where checkOut = 1 and p.id = b.idPersonnel and dateCheckIn >= '" + dateCheckIn + "' and dateCheckOut <= '" + dateCheckOut + "'";

                double result = (double)DataProvider.Instance.ExcuteScalar(query);

                return result;
            }
            catch
            {
                return 0;
            }

        }

        public int TotalBill(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            string query = "select count(b.id) from Bill as b, Personnel as p where checkOut = 1 and p.id = b.idPersonnel and dateCheckIn >= '" + dateCheckIn + "' and dateCheckOut <= '" + dateCheckOut + "'";

            int total = (int)DataProvider.Instance.ExcuteScalar(query);

            return total;
        }
    }
}
