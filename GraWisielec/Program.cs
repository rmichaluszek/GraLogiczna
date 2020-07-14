using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWisielec
{
    class Program
    {
        static Dictionary<int, string> dictOfWords = new Dictionary<int, string>();

        static void Main(string[] args)
        {

            createDictOfWords();
            Console.WriteLine("Witaj w grze wisielec, naciśnij dowolny przycisk aby rozpocząć.");
            Console.ReadKey();

            game();
        }

        static void createDictOfWords()
        {
            dictOfWords.Add(1, "jezdnia");
            dictOfWords.Add(2, "rowerzysta");
            dictOfWords.Add(3, "komputer");
            dictOfWords.Add(4, "drukarka");
            dictOfWords.Add(5, "poduszka");
            dictOfWords.Add(6, "domek");
        }
        static void game()
        {
            int triesLeft = 11;
            Random rnd = new Random();
            String word = dictOfWords[rnd.Next(1, 7)];
            int lettersToGuessLeft = word.Length;
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
                            triesLeft++;
                        }
                    } else
                    {
                        triesLeft++;
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

            for(int i = 0; i < word.Length;i++)
            {
                if (guessedLetters.Contains(word[i]))
                {
                    Console.Write(word[i]);
                } else
                {
                    Console.Write("_");
                }
            }

            Console.WriteLine();
        }
    }
}
