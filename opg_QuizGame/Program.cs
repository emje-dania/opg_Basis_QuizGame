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
            // Variable liste
            bool play = true;
            string response;
            int lives = 6;
            string intro = $"Guess the word\nAll words are in English\nPress a letter and then enter\nRemaning lives: {lives}\n\n\n";

            Console.WriteLine(intro);
            
           

            //The Array of 25 words
            string[] wordArray = { "dose", "rack", "budget", "quality", "mill", "neck", "absence", "disagree", "clothes", "ash", "hierarchy", "comfortable", "fever", "formula", "language", "suggest", "decorative", "test", "applaud", "wreck", "explicit", "distributor", "camera", "bench" };


            // The word randomizer. The "string word" calls the wordArray and then in the array pick randomly between the 25 words
            Random randomWord = new Random();
            string word = wordArray[randomWord.Next(0, wordArray.Length)];

            //needs to know how big the word is so we can put in the correct amount of "_"
            int wordLength = word.Length;

            // an empty array for used letters
            List<char> lettersUsed = new List<char>();

            StringBuilder hidden = new StringBuilder();

            for (int i = 0; i<wordLength; i++)
            {
                hidden.Append("_"); //for each character = "_"

               
            }

            while (play) //The game starts
            {

                //The player has 6 lives
                /*int lives = 6;*/

                

                Console.WriteLine(hidden);

                Console.WriteLine(word);


                

                while (lives != 0) //Keeps going until you run out of lives
                {
                    //An empty array where the letters the player type will go in
                    var letters = new List<string>();


                    
                    
                    // check if a typed letter is in the word
                    foreach (var usedLetter in word)
                    {
                        //added ".ToString" the if function could not work with a char.
                        var letter = usedLetter.ToString();

                        if (letters.Contains(letter))
                        {
                            //if the letter was correct: type the letter
                            // show how many lives there are left
                            Console.Write(letter);
                            Console.WriteLine("Lives: " + lives);
                        }
                        else
                        {
                            //if the letter was wrong: type a "_"
                            //show how many lives there are left
                            Console.WriteLine("_");
                            lives--;
                            Console.WriteLine("Lives: " + lives);
                        }
                        Console.ReadLine();
                    }
                   

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
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

        }
    }
}
