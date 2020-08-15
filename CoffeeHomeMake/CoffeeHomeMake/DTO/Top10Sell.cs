using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class Top10Sell
    {
        public Top10Sell(string name, int totalCount)
        {
            this.Name = name;
            this.TotalCount = totalCount;
        }

        public Top10Sell(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.TotalCount = (int)row["totalCount"];
        }

        private int totalCount;

        public int TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
