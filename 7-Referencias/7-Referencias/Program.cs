using System;

namespace _7_Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary dy1 = new Diary(16);
            Diary dy2 = dy1;
            Diary dy3 = new Diary(16);

            dy2.Flip();

            Console.WriteLine(dy1 == dy2);
            Console.WriteLine(dy1 == dy3);

            Book bookLocation = new Book("Arthur","BookArthur");
            Book sameBookLocation = bookLocation;

            Console.WriteLine(bookLocation.Stringfy());
            Console.WriteLine(sameBookLocation.Stringfy());

            // Matriz de referencias

            Book book1 = new Book("Harry","Harry Potter");
            Book book2 = new Book("Aquiles","TROIA");
            Book book3 = new Book("Thomas", "Blinder");

            Book[] books = new Book[]
            {
                book1,
                book2,
                book3
            };

            foreach(Book valueBook in books)
            {
                Console.WriteLine(valueBook.Stringfy());
            }
                
        }
    }
}
