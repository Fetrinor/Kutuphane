using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class SellList
    {
        public static List<SellPerson> ListOfSold { get; set; }
        private static int clickTimes = 0;

        public static void AddToSoldList(SellPerson person)
        {
            clickTimes = clickTimes + 1;
            if (clickTimes == 1)
            {
                ListOfSold = new List<SellPerson> { };
                ListOfSold.Add(person);
            }
            else
            {
                ListOfSold.Add(person);
            }
        }
    }
}
