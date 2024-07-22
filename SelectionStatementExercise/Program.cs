﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guess
            var r = new Random();
            //var favNumber = r.Next(1, 10);
            var favNumber = 7;

            Console.WriteLine($"Pick a number from 1-10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("hot diggity dog you got it!");
            }

            //Switch-Case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                    Console.WriteLine("I love science!");
                    break;
                case "pe":
                    Console.WriteLine("PE is the best!");
                    break;
                case "history":
                    Console.WriteLine("History is fun!");
                    break;
                case "english":
                    Console.WriteLine("English is boring!");
                    break;
                    default:
                    Console.WriteLine("I don't know that subject.");
                    break;
            }
        }
    }
}
