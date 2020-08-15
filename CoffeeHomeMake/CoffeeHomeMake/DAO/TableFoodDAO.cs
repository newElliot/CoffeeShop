using CoffeeHomeMake.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHomeMake.DAO
{
    public class TableFoodDAO
    {
        private static TableFoodDAO instance;

        public static TableFoodDAO Instance
        {
            get { if (instance == null) instance = new TableFoodDAO(); return TableFoodDAO.instance; }
            private set { TableFoodDAO.instance = value; }
        }

        private TableFoodDAO() { }

        public List<TableFood> GetListTableFood()
        {
            List<TableFood> list = new List<TableFood>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select * from TableFood");

            foreach (DataRow item in data.Rows)
            {
                TableFood table = new TableFood(item);
                list.Add(table);
            }
            return list;
        }

        public int SwitchTable(int id1, int id2, int idPersonnel)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("USP_SwitchTable @idTable1 , @idTable2 , @idPersonnel", new object[] { id1, id2, idPersonnel });

            return result;
        }

        public int CombineTable(int id1, int id2, int idPersonnel)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("USP_CombineTable @idTable1 , @idTable2 , @idPersonnel", new object[] { id1, id2, idPersonnel });

            return result;
        }
    }
}
