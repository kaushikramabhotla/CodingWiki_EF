﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class Fluent_Book
    {
        //[Key]
        public int BookId { get; set; }
        public string Title { get; set; }

        [MaxLength(20)]
        public string ISBN { get; set; }

        public decimal Price{ get; set; }

        [NotMapped]
        public string priceRange { get; set; }

        //public Fluent_BookDetail BookDetail { get; set; }

        //[ForeignKey(nameof(Publisher))]
        //public int Publisher_Id { get; set; }

        //public Fluent_Publisher Publisher { get; set; }

        //public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
    }
}
