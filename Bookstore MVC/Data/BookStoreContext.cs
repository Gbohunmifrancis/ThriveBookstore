using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookstoreMVC.Data;
namespace BookstoreMVC.Data
{
    public class BookStoreContext : DbContext
    {
        public  BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
            
        }
        public DbSet<Books> Books { get; set; }
        // public DbSet<Language> Language { get; set; }
    }    
}