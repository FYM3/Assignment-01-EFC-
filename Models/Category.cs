using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Assignment_01_EFC_.Models
{
    internal class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
