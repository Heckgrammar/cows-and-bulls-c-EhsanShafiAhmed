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
            Console.WriteLine("Welcome to the Cows and Bulls Game!"); 
        Console.WriteLine("Try to guess the secret 4-digit number."); 
  
        // Generate a random 4-digit number 
        Random random = new Random(); 
        int[] secretNumber = new int[4]; 
        for (int i = 0; i < 4; i++) 
        { 
            secretNumber[i] = random.Next(0, 10); 
        } 
  
        int attempts = 0; 
        int cows, bulls; 
        do 
        { 
            // Ask for user input 
            Console.Write("Enter your guess (4 digits): "); 
            string guessStr = Console.ReadLine(); 
  
            // Convert user input to array 
            int[] guess = new int[4]; 
            for (int i = 0; i < 4; i++) 
            { 
                guess[i] = int.Parse(guessStr[i].ToString()); 
            } 
  
            // Check for cows and bulls 
            cows = 0; 
            bulls = 0; 
            for (int i = 0; i < 4; i++) 
            { 
                if (guess[i] == secretNumber[i]) 
                { 
                    bulls++; 
                } 
                else 
                { 
                    for (int j = 0; j < 4; j++) 
                    { 
                        if (guess[i] == secretNumber[j]) 
                        { 
                            cows++; 
                            break; 
                        } 
                    } 
                } 
            } 
  
            // Display result 
            Console.WriteLine("Cows: " + cows +  Bulls: " +  bulls); 
            attempts++; 
  
        } while (bulls < 4); 
  
        Console.WriteLine("Congratulations! You guessed the number in" + attempts +  "attempts."); 

            
        }
    }
}
