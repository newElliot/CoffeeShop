using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class WorkPlaceDAO
    {
        private static WorkPlaceDAO instance;

        public static WorkPlaceDAO Instance
        {
            get { if (instance == null) instance = new WorkPlaceDAO(); return WorkPlaceDAO.instance; }
            private set { WorkPlaceDAO.instance = value; }
        }

        private WorkPlaceDAO() { }

        public List<WorkPlace> GetListWorkPlace()
        {
            List<WorkPlace> list = new List<WorkPlace>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select * from WorkPlace");

            foreach(DataRow item in data.Rows)
            {
                WorkPlace wp = new WorkPlace(item);
                list.Add(wp);
            }

            return list;
        }

        public WorkPlace GetWorkPlaceByIdPersonnel(int id)
        {
            string query = "select w.id, w.name, w.address from Personnel as p, WorkPlace as w where p.workPlace = w.id and p.id = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                WorkPlace wp = new WorkPlace(data.Rows[0]);
                return wp;
            }
            return null;
        }
    }
}
