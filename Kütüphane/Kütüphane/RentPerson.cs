using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class RentPerson
    {
        public string RentedBookName;
        public string PersonName;
        public string PersonPhoneNo;
        public string RentDate;
        public string RentalPeriod;
        

        public RentPerson(string RentedBookName, string PersonName, string PersonPhoneNo, string RentalPeriod)
        {
            this.RentedBookName = RentedBookName;
            this.PersonName = PersonName;
            this.PersonPhoneNo = PersonPhoneNo;
            this.RentalPeriod = RentalPeriod;
            this.RentDate = DateTime.Now.ToShortDateString();
        }
        public RentPerson(string RentedBookName, string PersonName, string PersonPhoneNo, string RentDate, string RentalPeriod)
        {
            this.RentedBookName = RentedBookName;
            this.PersonName = PersonName;
            this.PersonPhoneNo = PersonPhoneNo;
            this.RentalPeriod = RentalPeriod;
            this.RentDate = RentDate;
        }
    }
}
