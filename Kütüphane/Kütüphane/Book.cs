using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    class Book
    {   
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string YearOfPublication { get; set; }
        public string TypeOfBook { get; set; }

        public Book(string BookName, string TypeOfBook, string AuthorName, int YearOfPublication)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
            this.YearOfPublication = YearOfPublication.ToString();
            this.TypeOfBook = TypeOfBook;
        }
        // Author unknow
        public Book(string BookName, string TypeOfBook, int YearOfPublication)
        {
            this.BookName = BookName;
            this.TypeOfBook = TypeOfBook;
            this.YearOfPublication = YearOfPublication.ToString();
            this.AuthorName = "Bilinmiyor";
        }
        // Year of publication unknow
        public Book(string BookName, string TypeOfBook, string AuthorName)
        {
            this.BookName = BookName;
            this.TypeOfBook = TypeOfBook;
            this.AuthorName = AuthorName;
            this.YearOfPublication = "Bilinmiyor";
        }
        
        
    }
}
