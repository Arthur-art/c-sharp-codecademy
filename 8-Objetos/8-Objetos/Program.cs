using System;

namespace _8_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(12, "Arthur", "BookArthur");
            book.info();

            Vehicle sedan = new Vehicle(4,"Sedan");
            sedan.estoque();

            //Esse códigos não gerará um erro porque cada tipo - em algum ponto - herda de Object:
            Object bookObject = new Book(12, "Arthur", "BookArthur");

            Object[] objectArray = { 1, 2, 3, 4, 5.32, "6", "7", "8", "9" };

            foreach(Object value in objectArray)
            {
                Console.WriteLine(value.GetType());
            }
        }
    }
}
