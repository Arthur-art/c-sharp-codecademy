using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Referencias
{
    class Book
    {
        public string Author { get; private set; }
        public string Title { get; private set; }

        public Book(string author = "Unknown", string title="Untitled")
        {
            Author = author;
            Title = title;
        }

        public virtual string Stringfy()
        {
            return $"livro: {Title}, Autor: {Author}";
        }
    }
}
