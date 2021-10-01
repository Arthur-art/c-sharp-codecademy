using System;

namespace ArraysAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            int[] arrayNumber;

            arrayNumber = new int[] { 1, 2, 3, 4, 5 };

            string[] arrayString = {"Banana","Maca","Laranja","Pera" };

            Console.WriteLine(string.Join(",", arrayNumber));

            Console.WriteLine(string.Join(",", arrayString));

            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};

            static void checkMusic(string[] music)
            {

                if (music.Length == 8)
                {
                    Console.WriteLine("SummerStrut Playlist está pronta para ir!");
                }
                else if (music.Length > 8)
                {
                    Console.WriteLine("Muitas canções!");
                }
                else if (music.Length < 8)
                {
                    Console.WriteLine("Adicione algumas músicas!");
                }
            };

            checkMusic(summerStrut);

            summerStrut[7] = "Vermillion";


            Console.WriteLine(string.Join(",",summerStrut));

            // IndexOf

            Console.WriteLine(Array.IndexOf(summerStrut, "Vermillion"));

            string[] arrayCopy = new string[summerStrut.Length];

            Array.Copy(summerStrut, arrayCopy,  summerStrut.Length);

            Console.WriteLine(string.Join(",",arrayCopy));

            foreach(string value in arrayCopy)
            {
                Console.WriteLine(value);
            }


        }
    }
}
