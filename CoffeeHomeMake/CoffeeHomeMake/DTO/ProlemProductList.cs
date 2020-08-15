using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class ProlemProductList
    {
        public ProlemProductList(string name, float price, int totalCount, float totalPrice)
        {
            this.Name = name;
            this.Price = price;
            this.TotalCount = totalCount;
            this.TotalPrice = totalPrice;
        }

        public ProlemProductList(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Price = float.Parse(row["price"].ToString());
            this.TotalCount = (int)row["totalCount"];
            this.TotalPrice = float.Parse(row["totalPrice"].ToString());
        }

        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private int totalCount;

        public int TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
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
    }
}
