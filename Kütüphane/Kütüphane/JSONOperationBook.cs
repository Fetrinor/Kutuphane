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
    class JSONOperationBook
    {
        private static string BookName;
        private static string AuthorName;
        private static string YearOfPublication;
        private static string TypeOfBook;
        private static Book book;

        public static string pathBook = Path.GetFullPath("JsonDatas") + "\\books.json";

        private static string jsonresult;

        public static void CreateJson()
        {
            jsonresult = JsonConvert.SerializeObject(BookList.ListOfBooks);
            FileWriter(jsonresult);
        }

        public static void FileWriter(string jsonresult)
        {
            if (File.Exists(pathBook))
            {
                File.Delete(pathBook);
                using (var tw = new StreamWriter(pathBook, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(pathBook))
            {
                using (var tw = new StreamWriter(pathBook, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    tw.Close();
                }
            }
        }

        public static void DeserializeJson()
        {
            if (System.IO.File.Exists(pathBook))
            {
                string json = System.IO.File.ReadAllText(pathBook);
                int countofbooks = JArray.Parse(json).Count();
                for (int i = 0; i < countofbooks; i++)
                {
                    BookName = JArray.Parse(json).Children()["BookName"].ElementAt(i).ToString();
                    AuthorName = JArray.Parse(json).Children()["AuthorName"].ElementAt(i).ToString();
                    YearOfPublication = JArray.Parse(json).Children()["YearOfPublication"].ElementAt(i).ToString();
                    TypeOfBook = JArray.Parse(json).Children()["TypeOfBook"].ElementAt(i).ToString();
                    if(YearOfPublication == "Bilinmiyor")
                    {
                        book = new Book(BookName, TypeOfBook, AuthorName);
                    }
                    else if (AuthorName == "Bilinmiyor")
                    {
                        book = new Book(BookName, TypeOfBook, Convert.ToInt32(YearOfPublication));
                    }
                    else
                    {
                        book = new Book(BookName, TypeOfBook, AuthorName, Convert.ToInt32(YearOfPublication));
                    }
                    BookList.AddToBookList(book);
                }
            }
            
        }
    }
}
