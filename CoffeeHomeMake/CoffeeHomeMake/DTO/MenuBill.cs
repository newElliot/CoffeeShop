using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class MenuBill
    {
        public MenuBill(int idproduct ,string name, float price, int count, float total)
        {
            this.IDProduct = idproduct;
            this.Name = name;
            this.Price = price;
            this.Count = count;
            this.Total = total;
        }

        public MenuBill(DataRow row)
        {
            this.IDProduct = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Count = (int)row["count"];
            this.Total = (float)Convert.ToDouble(row["total"].ToString());
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

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iDProduct;

        public int IDProduct
        {
            get { return iDProduct; }
            set { iDProduct = value; }
        }
    }
}
