

namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Book
    {
        [Required(ErrorMessage = "You must enter books ID")]
        [Display(Name = "Book ID:")]
        public int Book_ID { get; set; }

        [Required(ErrorMessage = "You must enter books Title")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Title:")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You must enter books Author")]
        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Author:")]
        public string Author { get; set; }

        [Required(ErrorMessage = "You must enter bPublished year")]
        [Display(Name = "Published Year")]
        public Nullable<int> Year { get; set; }

        [Required(ErrorMessage = "You must enter books publisher")]
        [StringLength(60, MinimumLength = 1)]
        [Display(Name = "Publisher:")]
        public string Publisher { get; set; }
    }
}
