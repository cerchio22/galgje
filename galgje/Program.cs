// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace HangmanExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message and instructions
            Console.WriteLine("Welkom bij Galgje!");
            Console.WriteLine("Ik denk aan een woord, kan jij het woord raden?");

            // Word list
            string[] words = { "appel", "banaan", "kersen", "peer", "tomaat", "citroen", "brood" };

            // Choose a random word
            Random random = new Random();
            string word = words[random.Next(0, words.Length)];

            // Create a string to hold the correct letters that have been guessed
            string correctLetters = "";

            // Create a string to hold the incorrect letters that have been guessed
            string incorrectLetters = "";

            // Loop until the player has successfully guessed all of the letters in the word
            while (correctLetters.Length < word.Length)
            {
                // Display the word with the correctly guessed letters revealed
                string displayWord = "";
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];
                    if (correctLetters.Contains(letter))
                    {
                        displayWord += letter;
                    }
                    else
                    {
                        displayWord += "_";
                    }
                }
                Console.WriteLine(displayWord);

                // Get player's guess
                Console.WriteLine("Enter een letter:");
                string input = Console.ReadLine();

                // Convert player's guess to a character
                if (char.TryParse(input, out char guess))
                {
                    // Check if the letter is in the word
                    if (word.Contains(guess))
                    {
                        Console.WriteLine("Juist!");
                        correctLetters += guess;
                    }
                    else
                    {
                        Console.WriteLine("Fout!");
                        incorrectLetters += guess;
                    }
                }
                else
                {
                    Console.WriteLine("Verkeerd. Voer een geldige letter in.");
                }
            }

            // Player has successfully guessed the word
            Console.WriteLine("Gefeliciteerd, je hebt het woord geraden.");
        }
    }
}

