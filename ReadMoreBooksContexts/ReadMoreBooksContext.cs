using Assignment_01_EFC_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01_EFC_.DbContexts
{
    internal class ReadMoreBooksContext : DbContext
    {

        public DbSet<Book> Books { get; set; } = null!;

        public DbSet<Author> Authors { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;
    }
}
