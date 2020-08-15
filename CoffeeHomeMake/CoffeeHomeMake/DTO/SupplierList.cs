using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class SupplierList
    {
        public SupplierList(int id, string  name, string address, string phone, string group)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Group = group;
        }

        public SupplierList(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Group = row["group"].ToString();
        }

        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
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
