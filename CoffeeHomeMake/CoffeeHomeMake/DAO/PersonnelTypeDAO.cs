using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeHomeMake.DTO;

namespace CoffeeHomeMake.DAO
{
    public class PersonnelTypeDAO
    {
        private static PersonnelTypeDAO instance;

        public static PersonnelTypeDAO Instance
        {
            get { if (instance == null) instance = new PersonnelTypeDAO(); return PersonnelTypeDAO.instance; }
            private set { PersonnelTypeDAO.instance = value; }
        }

        private PersonnelTypeDAO() { }

        public List<PersonnelType> GetListPersonnelType()
        {
            List<PersonnelType> list = new List<PersonnelType>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select * from PersonnelType");

            foreach(DataRow item in data.Rows)
            {
                PersonnelType pt = new PersonnelType(item);
                list.Add(pt);
            }

            return list;
        }

        public PersonnelType GetTypeByIdPersonnel(int id)
        {
            string query = "select pt.id, pt.name from PersonnelType as pt, Personnel as p where p.personnelType = pt.id and p.id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if(data.Rows.Count > 0)
            {
                PersonnelType pt = new PersonnelType(data.Rows[0]);
                return pt;
            }
            return null;
        }
    }
}
