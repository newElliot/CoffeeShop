using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class DetailTop10
    {
        public DetailTop10(string name, int count, float total, float percent)
        {
            this.Name = name;
            this.Count = count;
            this.Total = total;
            this.Percent = percent;
        }

        public DetailTop10(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Count = (int)row["totalCount"];
            this.Total = float.Parse(row["total"].ToString());
            this.Percent = float.Parse(row["percent"].ToString());
        }

        private float percent;

        public float Percent
        {
            get { return percent; }
            set { percent = value; }
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

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
