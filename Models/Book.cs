using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_01_EFC_.Models
{
    internal class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int NumberofPages { get; set; }

        public int PublishedYear { get; set; }

        public bool Instock { get; set; }

        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

    }
}
