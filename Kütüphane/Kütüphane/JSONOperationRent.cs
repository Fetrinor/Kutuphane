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
    class JSONOperationRent
    {
        private static RentPerson rentPerson;
        private static string RentedBookName;
        private static string PersonName;
        private static string PersonPhoneNo;
        private static string RentDate;
        private static string RentalPeriod;

        public static string pathRent = Path.GetFullPath("JsonDatas") + "\\rented.json";

        private static string jsonresult;

        public static void CreateJson()
        {
            jsonresult = JsonConvert.SerializeObject(RentList.ListOfRent);
            FileWriter(jsonresult);
        }

        public static void FileWriter(string jsonresult)
        {
            if (File.Exists(pathRent))
            {
                File.Delete(pathRent);
                using (var tw = new StreamWriter(pathRent, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(pathRent))
            {
                using (var tw = new StreamWriter(pathRent, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    tw.Close();
                }
            }
        }
        public static void DeserializeJson()
        {
            if (System.IO.File.Exists(pathRent))
            {
                string json = System.IO.File.ReadAllText(pathRent);
                int countofrents = JArray.Parse(json).Count();
                for (int i = 0; i < countofrents; i++)
                {
                    RentedBookName = JArray.Parse(json).Children()["RentedBookName"].ElementAt(i).ToString();
                    PersonName = JArray.Parse(json).Children()["PersonName"].ElementAt(i).ToString();
                    PersonPhoneNo = JArray.Parse(json).Children()["PersonPhoneNo"].ElementAt(i).ToString();
                    RentDate = JArray.Parse(json).Children()["RentDate"].ElementAt(i).ToString();
                    RentalPeriod = JArray.Parse(json).Children()["RentalPeriod"].ElementAt(i).ToString();

                    rentPerson = new RentPerson(RentedBookName, PersonName, PersonPhoneNo, RentDate, RentalPeriod);

                    RentList.AddToRentList(rentPerson);
                }
            }
        }
    }
}
