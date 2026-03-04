using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab_15
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } // Many-to-many
    }
}
