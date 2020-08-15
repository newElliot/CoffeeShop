using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeHomeMake.DTO;
using System.Data;

namespace CoffeeHomeMake.DAO
{
    public class MenuBillDAO
    {
        private static MenuBillDAO instance;

        public static MenuBillDAO Instance
        {
            get { if (instance == null) instance = new MenuBillDAO(); return MenuBillDAO.instance; }
            private set { MenuBillDAO.instance = value; }
        }

        private MenuBillDAO() { }

        /// <summary>
        /// Hiển thị hóa đơn cho bàn có id là ...
        /// </summary>
        /// <returns></returns>
        public List<MenuBill> GetDetailBillInfoByIdTable(int idTable)
        {
            List<MenuBill> list = new List<MenuBill>();

            string query = "select p.id as id, p.name as name, p.price as price, bi.count as count, (p.price * bi.count) as total from Bill as b, BillInfo as bi, Product as p where b.id = bi.idBill and p.id = bi.idProduct and b.checkOut = 0 and b.idTableFood = " + idTable;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuBill menu = new MenuBill(item);
                list.Add(menu);
            }
            return list;
        }
    }
}
