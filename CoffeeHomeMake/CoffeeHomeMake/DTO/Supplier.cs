using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class Supplier
    {
        public Supplier(int id, string name, string address,string phone, int type)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Type = type;
        }

        public Supplier(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Type = (int)row["type"];
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
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
