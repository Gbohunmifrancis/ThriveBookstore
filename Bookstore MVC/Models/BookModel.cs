using BookstoreMVC.Enums;
using System.ComponentModel.DataAnnotations;

namespace BookstoreMVC.Models
{
    
    public class BookModel
    {

        public int Id { get; set; }
        [StringLength(100,MinimumLength = 5)]
        [Required(ErrorMessage="Please enter the name of your author")]
        public string Author { get; set; }
        [Required(ErrorMessage="Please enter the title of your book")]
        public string Title { get; set; }
         [StringLength(500,MinimumLength = 30)]
        public string Description { get; set; }

        public string Category { get; set; }

        // public int LanguageId { get; set; }
        public string Language { get; set; }
        //public LanguageEnum LanguageEnum { get; set; }

        [Display(Name ="Total Pages of Book")]
        [Required(ErrorMessage="Please enter the total pages")]
        public int? TotalPages { get; set; }
    }
}
