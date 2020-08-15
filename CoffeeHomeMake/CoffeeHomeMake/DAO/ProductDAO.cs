using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        /// <summary>
        /// Lấy danh sách menu thức ăn nước uống dựa vào IDCategory
        /// </summary>
        public List<Product> GetListProductbyIdCategory(int idCategory)
        {
            List<Product> list = new List<Product>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListProductByIdCategory @id", new object[] { idCategory });

            foreach (DataRow item in data.Rows)
            {
                Product pd = new Product(item);
                list.Add(pd);
            }
            return list;
        }

        public DataTable GetListProductByPageNumber(int pageNumber)
        {
            string query = "USP_GetListProductByPageNumber @pageNumber";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { pageNumber });

            return data;
        }

        public int GetNumberTotalProduct()
        {
            string query = "select Count(*) from Product as p, Category as c where p.idCategory = c.id";
            return (int)DataProvider.Instance.ExcuteScalar(query);
        }

        public int AddProduct(string name, float price, int idCategory)
        {
            string query = "insert into Product(name, price, idCategory) values(N'" + name + "', " + price + ", " + idCategory + ")";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result;
        }

        public int UpdateProduct(int id, string name, float price, int idCategory)
        {
            string query = "update Product set name = N'" + name + "', price = '" + price + "', idCategory = " + idCategory + " where id = " + id;

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result;
        }

        public DataTable FindSomeThings(string name)
        {
            string query = string.Format("SELECT * FROM dbo.Product WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        public int DeleteProduct(int id)
        {
            BillInfoDAO.Instance.DeleteIDProduct(id);

            string query = "delete Product where id = " + id;

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result;
        }

        public DataTable SortProductByCategory(int id)
        {
            string query = "select p.id as N'STT', p.name as N'Tên SP', p.price as N'Đơn giá', c.name as N'Nhóm' from Product as p, Category as c where p.idCategory = c.id and c.id = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
    }
}
