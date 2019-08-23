using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        public string fullName
        {
            get { return $"{firstName} {lastName}"; }
        }

        public virtual ICollection<Book> BooksCreated { get; set; }
        public virtual ICollection<Author> AuthorsCreated { get; set; }
    }
}
