﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class Fluent_BookAuthorMap
    {
        //[ForeignKey("Book")]
        public int BookId { get; set; }
        //[ForeignKey("Author")]
        public int AuthorId { get; set; }

        //public Fluent_Author Author { get; set; }
        //public Fluent_Book Book { get; set; }

    }
}
