﻿using LMSapplication.Models;
using System.ComponentModel.DataAnnotations;

namespace LMSapplication.Books.ViewModels
{
    public class BookViewModel
        : Book                              // inherits the Model class
    {
        [Display(Name = "Book ID")]
        override public int BookId
        {
            get
            {
                return base.BookId;
            }
            set
            {
                base.BookId = value;
            }
        }

        [Display(Name = "Title of the Book")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MinLength(2, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} can have a maximum of {1} characters")]
        public override string BookTitle
        {
            get => base.BookTitle;
            set => base.BookTitle = value;
        }

       
       

        [Display(Name = "Is Enabled?")]
        public override bool IsEnabled
        {
            get => base.IsEnabled;
            set => base.IsEnabled = value;
        }

        [Display(Name = "Category")]
        public override int CategoryId
        {
            get => base.CategoryId;
            set => base.CategoryId = value;
        }
        [Display(Name ="Image of the Book")]
        public override string imageUrl {
            get => base.imageUrl; 
            set => base.imageUrl = value;
        }
    }
}
