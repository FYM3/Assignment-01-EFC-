using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Assignment_01_EFC_.Models
{
    internal class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Biography { get; set; } = string.Empty;

        public DateTime DateofBirth { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
