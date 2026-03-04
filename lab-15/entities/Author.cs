using System;
using System.Collections.Generic;
using System.Text;

namespace lab_15
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

    
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
