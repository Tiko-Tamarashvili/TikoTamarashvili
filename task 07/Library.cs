using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using books;

namespace Libraries
{
    internal class Library
    {
        private Book[] books = new Book[20];
        private int BookSize = 0;
        public void AddBook(string Title, string Author, int Year) 
            {
                books[BookSize] = new Book(Title, Author, Year);
                BookSize = BookSize + 1;

            }
        public void PrintBook()
            {
                for (int i = 0; i < BookSize; i++)
                {
                    Console.WriteLine(books[i].Title + " " + books[i].Author);
                }
            }

        public int Count() 
            {
                return BookSize;
            }

        public void RemoveBook()
            {
                books = [];
                BookSize = 0;
            }

        public void FindBook(string Title)
            {
                for (int i = 0; i < BookSize; i++)
                {
                    if(books[i].Title == Title)
                    {
                        Console.WriteLine(books[i].Title + " " + books[i].Author);
                    }
                }
            }
    }

}
