using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uch_practica
{
    public class BookManager
    {
        // свойство класса
        private List<Book> Books {  get; set; }

        // конструктор класса
        public BookManager() 
        {
            Books = new List<Book>();
        }

        // метод добавления книги
        public void AddBook(Book book)
        { 
            if (Books.Any(b => b.Id == book.Id)) 
            {
                throw new InvalidOperationException("Книга с таким Id уже существует."); 
            }
            Books.Add(book);
        }

        // метод удаления книги
        public void RemoveBook(string bookId)
        {
            var book = GetBook(bookId);
            if (book == null)
                throw new KeyNotFoundException("Книга с таким Id не найдена");
            Books.Remove(book);
        }

        // метод получения книги по Id
        public Book GetBook(string bookId)
        {
            return  Books.FirstOrDefault (b=> b.Id == bookId); 
        }

        // метод получения спика всех книг
        List<Book> GetAllBooks() 
        {
            return new List<Book>(Books); 
        }
    }
}
