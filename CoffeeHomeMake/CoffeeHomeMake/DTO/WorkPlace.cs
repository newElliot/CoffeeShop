using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class WorkPlace
    {
        public WorkPlace(int id, string name, string address)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
        }

        public WorkPlace(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
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
