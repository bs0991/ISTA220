using System;

namespace BisectionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = 7;
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("Guessing Game");
                Console.WriteLine("-----------------------------------------------------------");


                Console.WriteLine("I have a number in my head. Please guess a number 1-10.");
                GuessingGame(value, numbers);

                Console.WriteLine("-----------------------------------------------------------");

                Random random = new Random();
                int humanGame = random.Next(0, 1001);

                Console.WriteLine("This time I have a number in my head between 1-1000! Try to guess that number.");
                HumanGuess(humanGame);

                Console.WriteLine("-----------------------------------------------------------");

                int num = 100;
                int min = 1;
                int max = num + 1;

                int[] values = new int[num];
                for(int i = 0; i < num; i++)
                {
                    values[i] = i + 1;
                }

                Console.WriteLine("It's my turn! Let me guess a random number between 1-100 that you decide! Unless you're scared I'll beat you..#computers > humans");
                ComputerGuess(values);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private static void GuessingGame(int answer, int [] array)
        {
            int guess = int.Parse(Console.ReadLine());

            if (guess > 10 || guess < 1)
            {
                Console.WriteLine("Write a valid number between 1 and 10.");
            }

            if (guess < answer)
            {
                Console.WriteLine($"The value is greater than {guess}");
                GuessingGame(answer, array);
            }
            else if (guess > answer)
            {
                Console.WriteLine($"The value is less than {guess}");
                GuessingGame(answer, array);
            }
            else
            {
                Console.WriteLine($"The value is equal to {answer}. You have found the correct answer...but that was too easy. Lets try a harder one.");
            }

        }
        private static void HumanGuess(int answer)
        {
            int guess = int.Parse(Console.ReadLine());

            if (guess > 1000 || guess < 1)
            {
                Console.WriteLine("Stupid human...You must write a valid number between 1-1000!");
            }
            if (guess < answer)
            {
                Console.WriteLine($"The value is greater than {guess}");
                HumanGuess(answer);
            }
            else if (guess > answer)
            {
                Console.WriteLine($"The value is less than {guess}");
                HumanGuess(answer);
            }
            else
            {
                Console.WriteLine($"The value is equal to {answer}. How did you find the right answer! That's impossible..you must have cheated!");
            }
        }

        private static void ComputerGuess(int[] array)
        {
            int computerGuess = array[(array.Length - 1) / 2];
            Console.WriteLine($"I guess {computerGuess}");
            Console.WriteLine("Press 1 if I'm too high.\n" + "Press 2 if I'm too low.\n" + "Press 3 if I'm right.\n");
            int response = int.Parse(Console.ReadLine());
            
            if (response == 1)
            {
                TooHigh(array);
            }
            else if (response == 2)
            {
                TooLow(array);
            }
            else if (response == 3)
            {
                Console.WriteLine("I told you I would get it right! Computers rule and humans drool!");
            }
        }
        private static void TooHigh(int[] array)
        {
            if (array.Length % 2 == 0)
            {
                int len = (array.Length - 1) / 2;
                int[] rtrn = new int[len];
                Array.Copy(array, 0, rtrn, 0, len);
                ComputerGuess(rtrn);
            }
            else
            {
                int len = array.Length / 2;
                int[] rtrn = new int[len];
                Array.Copy(array, 0, rtrn, 0, len);
                ComputerGuess(rtrn);
            }
        }
        private static void TooLow(int[] array)
        {
            if (array.Length % 2 == 0)
            {
                int len = array.Length / 2;
                int[] rtrn = new int[len];
                Array.Copy(array, len, rtrn, 0, len);
                ComputerGuess(rtrn);
            }
            else
            {
                int len = array.Length / 2;
                int[] rtrn = new int[len];
                Array.Copy(array, len + 1, rtrn, 0, len);
                ComputerGuess(rtrn);
            }
        }
    }
}
