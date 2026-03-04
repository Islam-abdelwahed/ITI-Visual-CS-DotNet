using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab_15
{
    public class PriceOffer
    {
        [Key]
        public int PriceOfferId { get; set; }

        public decimal NewPrice { get; set; }

        [MaxLength(200)]
        public string PromotionalText { get; set; }

        
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
