using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_QuizGame
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            //The Array of 25 words
            string[] wordArray = { "Dose", "Rack", "Budget", "Quality", "Mill", "Neck", "Absence", "Disagree", "Clothes", "Ash", "Hierarchy", "Comfortable", "Fever", "Formula", "Language", "Suggest", "Decorative", "Test", "Applaud", "Wreck", "Explicit", "Distributor", "Camera", "Bench" };
            // The word randomizer. The string word calls the wordArray and then in the array pick randomly between the 25 words
            Random randomWord = new Random();
            string word = wordArray[randomWord.Next(0, wordArray.Length)];


        }
    }
}
