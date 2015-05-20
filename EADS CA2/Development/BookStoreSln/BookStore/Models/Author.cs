

namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Author
    {
        [Required(ErrorMessage = "You must enter AuthorID")]
        [Display(Name = "AuthorID:")]
        public int AuthorID { get; set; }

        [Required(ErrorMessage = "You must enter FirstName")]
        [StringLength(30,MinimumLength = 1)]
        [Display(Name = "FirstName:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter LastName")]
        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "LastName:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter Country")]
        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "Country:")]
        public string Country { get; set; }

        [Required(ErrorMessage = "You must enter Language")]
        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "Language:")]
        public string Language { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
