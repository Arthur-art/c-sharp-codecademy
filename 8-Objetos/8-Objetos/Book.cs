using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Objetos
{
    class Book
    {
        public Book(int pagina, string autor, string title)
        {
            Pagina = pagina;
            Autor = autor;
            Title = title;
        }

        public int Pagina { get; set; }
        public string Autor { get; set; }
        public string Title { get; set; }

        public void info()
        {
            Console.WriteLine($"Este livro {Title}, foi escrito por {Autor}, e possui {Pagina} paginas ");
        }

        public override string ToString()
        {
            return $"Alterando o metodo ToString";
        }
    }
}
