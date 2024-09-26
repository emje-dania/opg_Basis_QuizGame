using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace opg_QuizGame
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 6;
            bool play = true;
            string response;


            //The Array of 25 words
            string[] wordArray = { "dose", "rack", "budget", "quality", "mill", "neck", "absence", "disagree", "clothes", "ash", "hierarchy", "comfortable", "fever", "formula", "language", "suggest", "decorative", "test", "applaud", "wreck", "explicit", "distributor", "camera", "bench" };
            // The word randomizer. The string word calls the wordArray and then in the array pick randomly between the 25 words
            Random randomWord = new Random();
            string word = wordArray[randomWord.Next(0, wordArray.Length)];

            

            //intro
            Console.WriteLine("Guess the word!");
            Console.WriteLine("All words are in English");
            Console.WriteLine("Press a letter and then enter");

            


            //The game starts
            while (play)
            {
                //Here '_' get put in for however long the word is
                string wordCompletion = new string('_', word.Length);

                //TEST SKAL SLETTES
                Console.WriteLine(wordCompletion);
                Console.WriteLine(word);

                //Keeps going until you run out of lives
                while (lives != 0)
                {

                }

                //ask the player if they want to play again. if yes (Y) then play stay true, but if no (N) then play turn false
                Console.WriteLine("Play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    play = true;
                }
                else
                {
                    play = false;
                }


            }
            Console.WriteLine("Thanks for playing");
            Console.ReadLine();
        }
    }
}
