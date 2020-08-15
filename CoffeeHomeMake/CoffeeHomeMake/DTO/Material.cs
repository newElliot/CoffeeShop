using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class Material
    {
        public Material(int id, string name, string unit, float weight, float price, string supplier)
        {
            this.ID = id;
            this.Name = name;
            this.Unit = unit;
            this.Weight = weight;
            this.Price = price;
            this.Supplier = supplier;
        }

        public Material(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Unit = row["unit"].ToString();
            this.Weight = float.Parse(row["weight"].ToString());
            this.Price = float.Parse(row["price"].ToString());
            this.Supplier = row["Supplier"].ToString();
        }

        private string supplier;

        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
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
