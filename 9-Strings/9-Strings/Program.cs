using System;

namespace _9_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Isso pode ser explicado pelo fato de que as strings são imutáveis : elas não podem ser alteradas depois de criadas. 
             Qualquer coisa que pareça modificar uma string, na verdade, retorna um novo string objeto.
             */

            string name1 = "Arthur";
            string name1Ref = name1;
            name1 = "Louis";

            Console.WriteLine(name1);
            Console.WriteLine(name1Ref);

            string a = "a";
            string b = "a";

            Console.WriteLine(a == b);

            Object obj = new Object();
            Object obj2 = new Object();

            Console.WriteLine(obj2 == obj);

           /*
            Console.Write("");
            string text = Console.ReadLine();

            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("String vazia");
            }
            else
            {
                Console.WriteLine($"Conteudo da string: {text}");
            }
            */
            string lyrics =
        "Dollie, Dollie, bo-bollie,\n" +
        "Banana-fana fo-follie\n" +
        "Fee-fi-mo-mollie\n" +
        "Dollie!";

           lyrics = lyrics.Replace("Dollie", "Arthur");

           Console.WriteLine(lyrics);


        }
    }
}
