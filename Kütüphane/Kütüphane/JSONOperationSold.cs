using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Kütüphane
{
    class JSONOperationSold
    {
        private static SellPerson sellPerson;
        private static string SoldBookName;
        private static string PersonName;
        private static string PersonPhoneNo;
        private static string SaleDate;
        private static string SalePrice;

        public static string pathSold = Path.GetFullPath("JsonDatas") + "\\sold.json";

        private static string jsonresult;

        public static void CreateJson()
        {
            jsonresult = JsonConvert.SerializeObject(SellList.ListOfSold);
            FileWriter(jsonresult);
        }

        public static void FileWriter(string jsonresult)
        {
            if (File.Exists(pathSold))
            {
                File.Delete(pathSold);
                using (var tw = new StreamWriter(pathSold, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(pathSold))
            {
                using (var tw = new StreamWriter(pathSold, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    tw.Close();
                }
            }
        }

        public static void DeserializeJson()
        {
            if (System.IO.File.Exists(pathSold))
            {
                string json = System.IO.File.ReadAllText(pathSold);
                int countofsold = JArray.Parse(json).Count();
                for (int i = 0; i < countofsold; i++)
                {
                    SoldBookName = JArray.Parse(json).Children()["SoldBookName"].ElementAt(i).ToString();
                    PersonName = JArray.Parse(json).Children()["PersonName"].ElementAt(i).ToString();
                    PersonPhoneNo = JArray.Parse(json).Children()["PersonPhoneNo"].ElementAt(i).ToString();
                    SaleDate = JArray.Parse(json).Children()["SaleDate"].ElementAt(i).ToString();
                    SalePrice = JArray.Parse(json).Children()["SalePrice"].ElementAt(i).ToString();

                    sellPerson = new SellPerson(SoldBookName, PersonName, PersonPhoneNo, SaleDate, SalePrice);

                    SellList.AddToSoldList(sellPerson);
                }
            }
        }
    }
}
