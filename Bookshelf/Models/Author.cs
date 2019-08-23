using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models
{
    public class Author
    {
        [Required]
        [Display(Name = "Author Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Pen Name")]
        public string penName { get; set; }
        [Display(Name = "Preferred Genre")]
        public string preferredGenre { get; set; }
        [Required]
        [Display(Name = "User Creator Id")]
        public int ApplicationUserId { get; set; }
        public ICollection<Book> Books { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Name")]
        public string fullName
        {
            get { return $"{firstName} {lastName}"; }
        }
    }
}