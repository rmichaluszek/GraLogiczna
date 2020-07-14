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
            int lettersToGuessLeft = 5;
            String word = "domek";
            String guessedLetters = "";

            while(triesLeft>0)
            {
                draw(triesLeft, word, guessedLetters);

                char letter = Console.ReadKey().KeyChar;
                if(Char.IsLetter(letter))
                {
                    if(!guessedLetters.Contains(letter))
                    {
                        guessedLetters += letter;
                        if(word.Contains(letter))
                        {
                            lettersToGuessLeft--;
                        }
                    }
                    
                    if(lettersToGuessLeft<=0)
                    {
                        Console.Clear();
                        Console.WriteLine("Gratulacje! Słowo to: " + word);
                        Console.WriteLine("Nacisnij dowolny przycisk aby zagrać ponownie.");
                        Console.ReadKey();
                        break;
                    }
                }
                else
                {
                    triesLeft++;
                    //nie podano litery wiec nie zabiera tury
                }
                triesLeft--;
                if(triesLeft<=0)
                {
                    Console.Clear();
                    Console.WriteLine("Przykro mi, nie udało ci się. Szukane słowo to: " + word);
                    Console.WriteLine("Nacisnij dowolny przycisk aby zagrać ponownie.");
                    Console.ReadKey();
                }
            }

            game();
           
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
