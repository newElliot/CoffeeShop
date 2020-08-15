using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class Top10SellDAO
    {
        private static Top10SellDAO instance;

        public static Top10SellDAO Instance
        {
            get { if (instance == null) instance = new Top10SellDAO(); return Top10SellDAO.instance; }
            private set { Top10SellDAO.instance = value; }
        }

        private Top10SellDAO() { }

        public List<Top10Sell> GetListTop5(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            List<Top10Sell> list = new List<Top10Sell>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_TOP10Sell @dateCheckIn , @dateCheckOut", new object[]{dateCheckIn, dateCheckOut});

            foreach(DataRow item in data.Rows)
            {
                Top10Sell sell = new Top10Sell(item);
                list.Add(sell);
            }

            return list;
        }

        public List<DetailTop10> GetListDetailTop10(DateTime dateCheckIn, DateTime dateCheckOut, float prevenue)
        {
            List<DetailTop10> list = new List<DetailTop10>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_DetailTop10 @dateCheckIn , @dateCheckOut , @Prevenue", new object[] { dateCheckIn, dateCheckOut, prevenue });

            foreach (DataRow item in data.Rows)
            {
                DetailTop10 dt = new DetailTop10(item);
                list.Add(dt);
            }

            return list;
        }
    }
}
