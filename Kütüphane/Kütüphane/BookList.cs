using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class BookList
    {
        public static List<Book> ListOfBooks { get; set; }
        private static int clickTimes = 0;

        public static void AddToBookList(Book book)
        {
            clickTimes = clickTimes + 1;
            if (clickTimes == 1)
            {
                ListOfBooks = new List<Book> { };
                ListOfBooks.Add(book);
            }
            else
            {
                ListOfBooks.Add(book);
            }
        }
    }
}
