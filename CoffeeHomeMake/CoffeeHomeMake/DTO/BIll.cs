using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CoffeeHomeMake.DTO
{
    public class Bill
    {
        public Bill(int id, int idTableFood, int idPersonnel, DateTime? dateCheckIn, int discount, float realPay, int checkOut, DateTime? dateCheckOut)
        {
            this.ID = id;
            this.IDTableFood = idTableFood;
            this.IDPersonnel = idPersonnel;
            this.DateCheckIn = dateCheckIn;
            this.Discount = discount;
            this.RealPay = realPay;
            this.CheckOut = checkOut;
            this.DateCheckOut = dateCheckOut;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDTableFood = (int)row["idTableFood"];
            this.IDPersonnel = (int)row["idPersonnel"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            this.Discount = (int)row["discount"];
            this.RealPay = (float)Convert.ToDouble(row["realPay"].ToString());
            this.CheckOut = (int)row["checkOut"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if(dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
        }

        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private int checkOut;

        public int CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        private float realPay;

        public float RealPay
        {
            get { return realPay; }
            set { realPay = value; }
        }

        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private int iDPersonnel;

        public int IDPersonnel
        {
            get { return iDPersonnel; }
            set { iDPersonnel = value; }
        }

        private int iDTableFood;

        public int IDTableFood
        {
            get { return iDTableFood; }
            set { iDTableFood = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
