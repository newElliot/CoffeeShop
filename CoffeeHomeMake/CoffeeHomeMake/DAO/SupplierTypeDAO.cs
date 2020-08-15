using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class SupplierTypeDAO
    {
        private static SupplierTypeDAO instance;

        public static SupplierTypeDAO Instance
        {
            get { if (instance == null) instance = new SupplierTypeDAO(); return SupplierTypeDAO.instance; }
            private set { SupplierTypeDAO.instance = value; }
        }

        private SupplierTypeDAO() { }

        public List<SupplierType> GetListType()
        {
            List<SupplierType> list = new List<SupplierType>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select * from SupplierType");

            foreach (DataRow item in data.Rows)
            {
                SupplierType st = new SupplierType(item);
                list.Add(st);
            }
            return list;
        }

        public SupplierType GetTypeByIDSupplier(int id)
        {
            string query = "select st.id, st.name from Supplier as s, SupplierType as st where s.type = st.id and s.id =" + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                SupplierType st = new SupplierType(data.Rows[0]);
                return st;
            }
            return null;
        }
    }
}
