using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeHomeMake.DTO;
using System.Data;

namespace CoffeeHomeMake.DAO
{
    public class SupplierListDAO
    {
        private static SupplierListDAO instance;

        public static SupplierListDAO Instance
        {
            get { if (instance == null) instance = new SupplierListDAO(); return SupplierListDAO.instance; }
            private set { SupplierListDAO.instance = value; }
        }

        private SupplierListDAO() { }

        public List<SupplierList> GetListSupplierInfo()
        {
            List<SupplierList> list = new List<SupplierList>();
            string query = "select s.id, s.name, s.address, s.phone, st.name as N'group' from Supplier as s, SupplierType as st where s.type = st.id";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                SupplierList sl = new SupplierList(item);
                list.Add(sl);
            }
            return list;
        }
    }
}
