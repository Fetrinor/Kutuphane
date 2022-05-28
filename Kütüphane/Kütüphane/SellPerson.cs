using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class SellPerson
    {
        public string SoldBookName;
        public string PersonName;
        public string PersonPhoneNo;
        public string SaleDate;
        public string SalePrice;

        public SellPerson(string SoldBookName, string PersonName, string PersonPhoneNo, string SellPrice)
        {
            this.PersonName = PersonName;
            this.PersonPhoneNo = PersonPhoneNo;
            this.SalePrice = SellPrice;
            this.SoldBookName = SoldBookName;
            this.SaleDate = DateTime.Now.ToShortDateString();
        }
        public SellPerson(string SoldBookName, string PersonName, string PersonPhoneNo, string SaleDate, string SellPrice)
        {
            this.PersonName = PersonName;
            this.PersonPhoneNo = PersonPhoneNo;
            this.SalePrice = SellPrice;
            this.SoldBookName = SoldBookName;
            this.SaleDate = SaleDate;
        }
    }
}
