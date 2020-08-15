using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeHomeMake.DTO;
using System.Data;

namespace CoffeeHomeMake.DAO
{
    public class ProlemProductDAO
    {
        private static ProlemProductDAO instance;

        public static ProlemProductDAO Instance
        {
            get { if (instance == null) instance = new ProlemProductDAO(); return ProlemProductDAO.instance; }
            private set { ProlemProductDAO.instance = value; }
        }
        private ProlemProductDAO() { }

        public List<ProlemProductList> GetListProductProlem(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            List<ProlemProductList> list = new List<ProlemProductList>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_ProlemProduct @dateCheckIn , @dateCheckOut", new object[] { dateCheckIn, dateCheckOut });

            foreach (DataRow item in data.Rows)
            {
                ProlemProductList pp = new ProlemProductList(item);
                list.Add(pp);
            }
            return list;
        }
    }
}
