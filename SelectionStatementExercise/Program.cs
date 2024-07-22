﻿using static System.Collections.Specialized.BitVector32;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guess
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine($"Pick a number from 1-1000");
            var userInput= int.Parse( Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{favNumber} is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{favNumber} is too high");
            }
            else
            {
                Console.WriteLine("hot diggity dog you got it!");
            }
        }
    }
}
