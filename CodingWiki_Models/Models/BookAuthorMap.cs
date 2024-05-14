﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class BookAuthorMap
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }

    }
}
