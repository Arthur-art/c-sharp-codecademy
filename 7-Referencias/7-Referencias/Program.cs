using System;

namespace _7_Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary dy1 = new Diary(16);
            Diary dy2 = dy1;

            dy2.Flip();

            Console.WriteLine(dy1.CurrentPage);
            Console.WriteLine(dy2.CurrentPage);
        }
    }
}
