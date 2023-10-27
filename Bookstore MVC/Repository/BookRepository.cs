using BookstoreMVC.Data;
using BookstoreMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BookstoreMVC.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }


        public async Task<int> AddNewBook(BookModel model)
        {

            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages.HasValue ? model.TotalPages.Value : 0,
                UpdatedOn = DateTime.UtcNow
            };

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allbooks = await _context.Books.ToListAsync();
            if (allbooks?.Any() == true)
            {
                foreach (var book in allbooks)
                {
                    books.Add(new BookModel()
                    {
                        Author = book.Author,
                        Description = book.Description,
                        Title = book.Title,
                        Id = book.Id,
                        TotalPages = book.TotalPages


                    });
                }
            }
            return books;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            return await _context.Books.Where(x => x.Id == id)
                .Select(book => new BookModel()
                {
                    Author = book.Author,
                    Description = book.Description,
                    Title = book.Title,
                    Id = book.Id,
                    TotalPages = book.TotalPages
                }).FirstOrDefaultAsync();
        }
                
           
         

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;
        }
        
    }
}
       


