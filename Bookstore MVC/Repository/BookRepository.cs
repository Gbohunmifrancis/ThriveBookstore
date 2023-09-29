using BookstoreMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookstoreMVC.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource(); 
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id ==id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Gbohunmi" },
                new BookModel() { Id = 2, Title = "Go", Author = "Gbohunmi" },
                new BookModel() { Id = 3, Title = "C#", Author = "Gbohunmi" },
                new BookModel() { Id = 4, Title = "Java", Author = "Francis" },
                new BookModel() { Id = 5, Title = "PHP", Author = "Francis" },
            };
                
            }
        }
    }

