using BookstoreMVC.Helpers;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookstoreMVC.Models
{

    public class BookModel
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the name of your author")]
        public string Author { get; set; }

        public string Title { get; set; }

        [StringLength(500, MinimumLength = 30)]
        public string Description { get; set; }

        public string Category { get; set; }

        public string Language { get; set; }

        [Display(Name = "Total Pages of Book")]
        [Required(ErrorMessage = "Please enter the total pages")]
        public int? TotalPages { get; set; }

         [Display(Name = "choose the cover photo of your book")]
         [Required]
        public IFormFile CoverPhoto { get; set; }
        
        public string CoverImageUrl { get; set; }

        public IFormFileCollection GalleryFiles { get; set; }

        public List<GalleryModel> Gallery { get; set; }
        [Display(Name = "upload your book in PDF format")]
        [Required]
        public IFormFile BookPdf { get; set; }

        public string BookPdfUrl { get; set; }
    }
}
