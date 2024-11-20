using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uch_practica
{
    public class Book
    {
        // свойства книги
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished{ get; private set; }

        //конструктор класса
        public Book (string id, string title, string author, int yearPublished) 
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }
    }
}
