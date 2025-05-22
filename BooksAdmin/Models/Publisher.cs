﻿namespace BooksAdmin.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
