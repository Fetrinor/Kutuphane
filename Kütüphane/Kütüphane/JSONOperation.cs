using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class JSONOperation
    {
        public static void DeserializeJson()
        {
            if (System.IO.File.Exists(JSONOperationBook.pathBook))
            {
                JSONOperationBook.DeserializeJson();
            }
            if (System.IO.File.Exists(JSONOperationRent.pathRent))
            {
                JSONOperationRent.DeserializeJson();
            }
            if (System.IO.File.Exists(JSONOperationSold.pathSold))
            {
                JSONOperationSold.DeserializeJson();
            }
        }
    }
}
