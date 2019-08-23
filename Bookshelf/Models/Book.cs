using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models
{
    public class Book
    {
        [Required]
        [Display(Name = "Book Id")]
        public int Id { get; set; }
        [Required]
        public decimal ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Date Published")]
        public DateTime PublishDate { get; set; }
        [Required]
        [Display(Name = "Author Id")]
        public int AuthorId { get; set; }
        [Required]
        [Display(Name = "User Creator Id")]
        public int ApplicationUserId { get; set; }

        public Author Author { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
