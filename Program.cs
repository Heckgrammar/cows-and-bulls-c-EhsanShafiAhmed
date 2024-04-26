using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
Random random = new Random();
        int[] secretNumber = new int[4];
        int[] guessNumber = new int[4];
        bool found = false;

        // Generate a random 4-digit number without repeating digits
        for (int i = 0; i < secretNumber.Length; i++)
        {
            int randomNumber;
            do
            {
                randomNumber = random.Next(10);
            } while (Array.IndexOf(secretNumber, randomNumber) != -1);

            secretNumber[i] = randomNumber;
        }

        Console.WriteLine("Welcome to Cows and Bulls game!");

        while (!found)
        {
            Console.Write("Enter your guess (4 digits): ");
            string input = Console.ReadLine();

            // Validate input
            if (input.Length != 4 || !int.TryParse(input, out guessNumber[0]))
            {
                Console.WriteLine("Please enter a valid 4-digit number.");
                continue;
            }

            // Convert string input to integer array
            for (int i = 0; i < input.Length; i++)
            {
                guessNumber[i] = input[i] - '0';
            }

            // Check for cows and bulls
            int cows = 0;
            int bulls = 0;

            for (int i = 0; i < guessNumber.Length; i++)
            {
                if (guessNumber[i] == secretNumber[i])
                {
                    bulls++;
                }
                else if (Array.IndexOf(secretNumber, guessNumber[i]) != -1)
                {
                    cows++;
                }
            }

            // Print result
            Console.WriteLine("Cows:" + cows + " Bulls: " + bulls);

            // Check if the guess is correct
            if (bulls == 4)
            {
                Console.WriteLine("Congratulations! You've guessed the correct number!");
                found = true;
			}
    }
 }
