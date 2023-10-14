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
                new BookModel() { Id = 1, Title = "MVC", Author = "Gbohunmi",Description="This is the description for MVC",Category="Programming", Language="English",TotalPages=134 },
                new BookModel() { Id = 2, Title = "Go", Author = "Gbohunmi",Description="This is the description for GO",Category="Programming", Language="Yoruba",TotalPages=455 },
                new BookModel() { Id = 3, Title = "C#", Author = "Gbohunmi",Description="This is the description for C#",Category="Programming", Language="Igbo",TotalPages=566 },
                new BookModel() { Id = 4, Title = "Java", Author = "Francis",Description="This is the description for Java",Category="Programming", Language="Hausa",TotalPages=566 },
                new BookModel() { Id = 5, Title = "PHP", Author = "Francis",Description="This is the description for PHP",Category="Programming", Language="Swahili",TotalPages=677 },
                new BookModel() { Id = 6, Title = "How to make money on Fiverr", Author = "Olamoney",Description="This is the description for the book on Fiverr",Category="Selling", Language="English",TotalPages=678 },
            };
                
            }
        }
    }

