using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeHomeMake.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int idBill ,int idProduct, int count)
        {
            this.ID = id;
            this.IDBill = idBill;
            this.IDProduct = idProduct;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idBill"];
            this.IDProduct = (int)row["idProduct"];
            this.Count = (int)row["count"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int iDProduct;

        public int IDProduct
        {
            get { return iDProduct; }
            set { iDProduct = value; }
        }

        private int iDBill;

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
