using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class ImportGoods
    {
        public ImportGoods(int id, DateTime theday, string namestaff, string supplier, string address, string material, float price, string unit, float weight, int count, float total)
        {
            this.ID = id;
            this.TheDay = theday;
            this.NameStaff = namestaff;
            this.Supplier = supplier;
            this.Address = address;
            this.Material = material;
            this.Price = price;
            this.Unit = unit;
            this.Weight = weight;
            this.Count = count;
            this.Total = total;
        }

        public ImportGoods(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TheDay = (DateTime)row["theday"];
            this.NameStaff = row["namestaff"].ToString();
            this.Supplier = row["supplier"].ToString();
            this.Address = row["address"].ToString();
            this.Material = row["material"].ToString();
            this.Price = float.Parse(row["price"].ToString());
            this.Unit = row["unit"].ToString();
            this.Weight = float.Parse(row["weight"].ToString());
            this.Count = (int)row["count"];
            this.Total = float.Parse(row["total"].ToString());
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private float weight;

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private string material;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        private string supplier;

        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        private string nameStaff;

        public string NameStaff
        {
            get { return nameStaff; }
            set { nameStaff = value; }
        }

        private DateTime theDay;

        public DateTime TheDay
        {
            get { return theDay; }
            set { theDay = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
