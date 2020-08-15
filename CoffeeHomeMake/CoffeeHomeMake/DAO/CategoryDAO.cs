using CoffeeHomeMake.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHomeMake.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Category");

            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public DataTable LoadCategory()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from  Category");
            return data;
        }

        public int InsertCategory(string name)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("insert into Category(name) values('" + name + "')");
            return result;
        }

        public int UpdateCategory(string name, int id)
        {
            string query = "update Category set name = '" + name + "' where id =  " + id;

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result;
        }

        public int GetCategoryByIDProduct(int id)
        {
            string query = "select * from Product where id = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                Product pd = new Product(data.Rows[0]);
                return pd.IDCategory;
            }
            return -1;
        }
    }
}
