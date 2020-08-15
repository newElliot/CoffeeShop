using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;

        public static SupplierDAO Instance
        {
            get { if (instance == null) instance = new SupplierDAO(); return SupplierDAO.instance; }
            private set { SupplierDAO.instance = value; }
        }

        private SupplierDAO() { }

        public List<Supplier> GetListSupplier()
        {
            List<Supplier> list = new List<Supplier>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Supplier");

            foreach(DataRow item in data.Rows)
            {
                Supplier sup = new Supplier(item);
                list.Add(sup);
            }

            return list;
        }

        /// <summary>
        /// Lấy thông tin nhà cung cấp của 1 Nguyên vật liệu nào đó được xác định bởi id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Supplier</returns>
        public Supplier GetSupplierByIdMaterial(int id)
        {
            string query = "select s.id, s.name, s.address, s.phone, s.type from Supplier as s, Material as m where s.id = m.idSupplier and m.id = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                Supplier sp = new Supplier(data.Rows[0]);
                return sp;
            }

            return null;
        }

        public int AddnewSupplier(string name, string address, string phone, int idSupplierType)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("USP_AddnewSupplier @name , @address , @phone , @idSupplierType", new object[] { name, address, phone, idSupplierType });

            return result;
        }

        public Supplier GetSupplierInfoByid(int id)
        {
            string query = "select * from Supplier where id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                Supplier sp = new Supplier(data.Rows[0]);
                return sp;
            }
            return null; 
        }

        public int UpdateSupplier(int id, string name, string address, string phone, int idSupplierType)
        {
            string query = "USP_UpdateSupplier @id , @name , @address , @phone , @idSupplierType";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {id,  name, address, phone, idSupplierType });

            return result;
        }
    }
}
