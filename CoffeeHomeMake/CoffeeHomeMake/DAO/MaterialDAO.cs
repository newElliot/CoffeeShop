using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class MaterialDAO
    {
        private static MaterialDAO instance;

        public static MaterialDAO Instance
        {
            get { if (instance == null) instance = new MaterialDAO(); return MaterialDAO.instance; }
            private set { MaterialDAO.instance = value; }
        }

        private MaterialDAO() { }


        public List<Material> GetListMaterial()
        {
            List<Material> list = new List<Material>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListMaterial");
            foreach(DataRow item in data.Rows)
            {
                Material mt = new Material(item);
                list.Add(mt);
            }

            return list;
        }

        public int AddnewMaterial(string name, string unit, float weight, float price, int idSupplier)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("USP_AddNewMaterial @name , @unit , @weight , @price , @idSupplier", new object[] { name, unit, weight, price, idSupplier });

            return result;
        }

        public Material DetailMaterial(int id)
        {
           
            string query = "select m.id , m.name  , m.unit , m.price , m.weight , s.name as N'Supplier' from Supplier as s, Material as m where s.id = m.idSupplier and m.id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                Material mt = new Material(data.Rows[0]);
                return mt;
            }
            return null;
        }

        public int UpdateMaterial(int id, string name, string unit, float weight, float price, int idSupplier)
        {
            string query = "USP_UpdateMaterial @id , @name , @unit , @weight , @price , @idSupplier";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, name, unit, weight, price, idSupplier });

            return result;
        }

        public List<Material> GetListMaterialBelongToSupplier(int id)
        {
            List<Material> list = new List<Material>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetMaterialbelongSupplier @idSupplier", new object[] { id });

            foreach(DataRow item in data.Rows)
            {
                Material sp = new Material(item);
                list.Add(sp);
            }
            return list;
        }
    }
}
