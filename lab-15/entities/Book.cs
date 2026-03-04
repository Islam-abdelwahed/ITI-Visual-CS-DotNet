using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab_15
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublishedOn { get; set; }

        [MaxLength(100)]
        public string Publisher { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }


        public ICollection<BookAuthor> BookAuthors { get; set; } // Many-to-many 

        public ICollection<Tag> Tags { get; set; }  // Many-to-many auto via EF Core

        public PriceOffer PriceOffer { get; set; } // One-to-one

        public ICollection<Review> Reviews { get; set; } // One-to-many
    }   
}
