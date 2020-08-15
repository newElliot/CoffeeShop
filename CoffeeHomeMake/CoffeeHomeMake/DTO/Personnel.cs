using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class Personnel
    {
        public Personnel(int id, string name, string address, DateTime? bornday, int personneltype, int workplace, int sex, float salary, string cmnd, DateTime? firstDayAtWork, string status, DateTime? dateLeave)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.BornDay = bornday;
            this.PersonnelType = personneltype;
            this.WorkPlace = workplace;
            this.Sex = sex;
            this.Salary = salary;
            this.CMND = cmnd;
            this.FirstDayAtWork = firstDayAtWork;
            this.Status = status;
            this.DateLeave = dateLeave;
        }

        public Personnel(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.BornDay = (DateTime?)row["bornday"];
            this.PersonnelType = (int)row["personneltype"];
            this.WorkPlace = (int)row["workplace"];
            this.Sex = (int)row["sex"];
            this.Salary = float.Parse(row["salary"].ToString());
            this.CMND = row["cmnd"].ToString();
            this.FirstDayAtWork = (DateTime)row["firstDateAtWork"];
            this.Status = row["status"].ToString();

            var TempDateLeave = row["dateLeave"];
            if(TempDateLeave.ToString() != "")
            {
                this.DateLeave = (DateTime?)TempDateLeave;
            }
        }

        private DateTime? dateLeave;

        public DateTime? DateLeave
        {
            get { return dateLeave; }
            set { dateLeave = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime? firstDayAtWork;

        public DateTime? FirstDayAtWork
        {
            get { return firstDayAtWork; }
            set { firstDayAtWork = value; }
        }

        private string cMND;

        public string CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }

        private float salary;

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private int workPlace;

        public int WorkPlace
        {
            get { return workPlace; }
            set { workPlace = value; }
        }

        private int personnelType;

        public int PersonnelType
        {
            get { return personnelType; }
            set { personnelType = value; }
        }

        private DateTime? bornDay;

        public DateTime? BornDay
        {
            get { return bornDay; }
            set { bornDay = value; }
        }

        private int sex;

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
