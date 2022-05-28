using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class RentList
    {
        public static List<RentPerson> ListOfRent { get; set; }
        private static int clickTimes = 0;

        public static void AddToRentList(RentPerson person)
        {
            clickTimes = clickTimes + 1;
            if (clickTimes == 1)
            {
                ListOfRent = new List<RentPerson> { };
                ListOfRent.Add(person);
            }
            else
            {
                ListOfRent.Add(person);
            }
        }
    }
}
