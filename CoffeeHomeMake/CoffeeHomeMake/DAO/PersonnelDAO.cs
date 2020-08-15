using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class PersonnelDAO
    {
        private static PersonnelDAO instance;

        public static PersonnelDAO Instance
        {
            get { if (instance == null) instance = new PersonnelDAO(); return PersonnelDAO.instance; }
            private set { PersonnelDAO.instance = value; }
        }

        private PersonnelDAO() { }

        public DataTable GetListStaffOnWork()
        {
            string query = "select * from Personnel where status = N'Đang làm việc'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public DataTable GetListStaffOnWorkAndHaveAccount()
        {
            string query = "select * from Personnel  as p where id not in(select idPersonnel from Account) and  status = N'Đang làm việc'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

        public string GetNamebyIDPersonnel(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Personnel where id = " + id);

            foreach (DataRow item in data.Rows)
            {
                Personnel person = new Personnel(item);
                return person.Name;
            }
            return null;
        }

        public int UpdatePersonnelInfo(int id, string name, string address, DateTime bornDay, int personnelType, int workPlace, float salary, string CMND, DateTime firstDayAtWork, int sex)
        {
            string query = "USP_UpdatePersonnelINfo @id , @name , @address , @sex , @bornDay , @personnelType , @workPlace , @salary , @CMND , @firstDayAtWork";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, name, address, sex, bornDay, personnelType, workPlace, salary, CMND, firstDayAtWork });

            return result;
        }

        public int Fired(int id)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("update Personnel set status = N'Đã nghỉ việc', dateLeave = GETDATE() where id = " + id);

            return result;
        }

        public DataTable ListAdmin()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Personnel where PersonnelType = 1 and status = N'Đang làm việc'");
            return data;
        }

        public DataTable ListCook()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Personnel where PersonnelType = 2 and status = N'Đang làm việc'");
            return data;
        }

        public DataTable ListService()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Personnel where PersonnelType = 3 and status = N'Đang làm việc'");
            return data;
        }

        public DataTable ListSecurity()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Personnel where PersonnelType = 4 and status = N'Đang làm việc'");
            return data;
        }

        public DataTable ListShipper()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Personnel where PersonnelType = 5 and status = N'Đang làm việc'");
            return data;
        }
    }
}
