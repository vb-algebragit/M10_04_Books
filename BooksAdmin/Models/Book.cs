using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BooksAdmin.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        [ValidateNever]
        public Author Author { get; set; }

        public int PublisherId { get; set; }

        //[ValidateNever]
        public Publisher? Publisher { get; set; }

        public string UserId { get; set; }

        [ValidateNever]
        public IdentityUser User { get; set; }
    }
}
