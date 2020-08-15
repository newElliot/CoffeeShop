using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class PersonnelInfoDAO
    {
        private static PersonnelInfoDAO instance;

        public static PersonnelInfoDAO Instance
        {
            get { if (instance == null) instance = new PersonnelInfoDAO(); return PersonnelInfoDAO.instance; }
            private set { PersonnelInfoDAO.instance = value; }
        }

        private PersonnelInfoDAO() { }

        public List<PersonnelInfo> GetListStaff()
        {
            List<PersonnelInfo> list = new List<PersonnelInfo>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListStaff");

            foreach(DataRow item in  data.Rows)
            {
                PersonnelInfo pi = new PersonnelInfo(item);
                list.Add(pi);
            }
            return list;
        }

        public int InsertNewStaff(string name ,string address, int sex, DateTime bornday, int idPersonnelType, int idWorkPlace, float salary, string CMND, DateTime firstday)
        {
            string query = "USP_InsertNewPersonnel @name , @address , @sex , @bornDay , @idPersonnelType , @idWorkPlace , @salary , @CMND , @firstDateAtWork";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, address, sex, bornday, idPersonnelType, idWorkPlace, salary, CMND, firstday });

            return result;
        }

        public PersonnelInfo GetInfoPersonnel(int id)
        {
            string query = "USP_GetInfoPersonnel @id";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                PersonnelInfo per = new PersonnelInfo(item);
                return per;
            }
            return null;
        }

        public List<PersonnelInfo> GetListFiredStaff()
        {
            List<PersonnelInfo> list = new List<PersonnelInfo>();

            string query = "USP_GetListStaffFired";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PersonnelInfo per = new PersonnelInfo(item);
                list.Add(per);
            }
            return list;
        }
    }
}
