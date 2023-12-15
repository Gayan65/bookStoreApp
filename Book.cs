using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Book
    {
        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public List<Book> BuyABook(List<Book> choice, string bookName)
        {
            int nuOfBooks = choice.Count();
            List<Book> selectedBooks = new List<Book>();
            for (int i = 0; i < nuOfBooks; i++)
            {
                if (choice[i].Name.Contains(bookName, StringComparison.OrdinalIgnoreCase))
                    selectedBooks.Add(choice[i]);
            }
            
            return selectedBooks;
        }

        public double CalcTotalPrice(List<Book> chosen)
        {
            double sum = 0;
            int numOfBooksPurchased = chosen.Count();
            for (int i = 0; i < numOfBooksPurchased; i++)
            {
               sum += chosen[i].Price;
            }
            
            return sum;
        }
    }
}
