using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWisielec
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj w grze wisielec, naciśnij dowolny przycisk aby rozpocząć.");

            Console.ReadKey();

            game();
        }

        static void game()
        {
            int triesLeft = 11;
            String word = "domek";

            while(triesLeft>0)
            {
                draw(triesLeft, word, "S");

                Console.ReadLine();
                triesLeft--;
            }
           
        }

        static void draw(int triesLeft, String word, String guessedLetters)
        {
            Console.Clear();
            Console.Write("Próby: ");
            for(int i =0; i< 11; i++)
            {
                if(i+1 > 11-triesLeft)
                {
                    Console.Write("[ ]");
                } else
                {
                    Console.Write("[X]");
                }
            }
            Console.WriteLine();
            Console.Write("Słowo: ");


            Console.WriteLine();
        }
    }
}
