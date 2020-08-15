using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class ImportGoodsDAO
    {
        private static ImportGoodsDAO instance;

        public static ImportGoodsDAO Instance
        {
            get { if (instance == null) instance = new ImportGoodsDAO(); return ImportGoodsDAO.instance; }
            private set { ImportGoodsDAO.instance = value; }
        }

        private ImportGoodsDAO() { }

        public List<ImportGoods> GetListImport()
        {
            List<ImportGoods> list = new List<ImportGoods>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListImportGoods");

            foreach(DataRow item in data.Rows)
            {
                ImportGoods ig = new ImportGoods(item);
                list.Add(ig);
            }

            return list;
        }

        public int InsertImportGoods(DateTime date, int idPersonnel, int idMaterial, int count)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("USP_ImportGoods @date , @idPersonnel , @idMaterial , @count", new object[] { date, idPersonnel, idMaterial, count });

            return result;
        }
    }
}
