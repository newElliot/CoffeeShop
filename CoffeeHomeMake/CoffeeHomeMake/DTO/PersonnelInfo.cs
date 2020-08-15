using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CoffeeHomeMake.DTO
{
    public class PersonnelInfo
    {
        public PersonnelInfo(int id, string name, string address, DateTime bornDay, int sex, string cmnd, DateTime dateAtWork, float salaryperhours, string workPlace, string location, string position, string status, DateTime? dateLeave)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.BornDay = bornDay;
            this.Sex = sex;
            this.CMND = cmnd;
            this.DateAtWork = dateAtWork;
            this.SalaryPerHours = salaryperhours;
            this.WorkPlace = workPlace;
            this.Location = location;
            this.Position = position;
            this.Status = status;
            this.DateLeave = dateLeave;
        }

        public PersonnelInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.BornDay = (DateTime)row["bornDay"];
            this.Sex = (int)row["sex"];
            this.CMND = row["cmnd"].ToString();
            this.DateAtWork = (DateTime)row["dateAtWork"];
            this.SalaryPerHours = float.Parse(row["SalaryperHours"].ToString());
            this.WorkPlace = row["workPlace"].ToString();
            this.Location = row["location"].ToString();
            this.Position = row["position"].ToString();
            this.Status = row["status"].ToString();

            var dateLeaveTemp = row["dateLeave"];
            if (dateLeaveTemp.ToString() != "")
                this.DateLeave = (DateTime?)dateLeaveTemp;
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

        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        private string workPlace;

        public string WorkPlace
        {
            get { return workPlace; }
            set { workPlace = value; }
        }

        private float salaryPerHours;

        public float SalaryPerHours
        {
            get { return salaryPerHours; }
            set { salaryPerHours = value; }
        }

        private DateTime dateAtWork;

        public DateTime DateAtWork
        {
            get { return dateAtWork; }
            set { dateAtWork = value; }
        }

        private string cMND;

        public string CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }

        private int sex;

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private DateTime bornDay;

        public DateTime BornDay
        {
            get { return bornDay; }
            set { bornDay = value; }
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
