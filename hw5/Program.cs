using System;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. FizzBuzz Game");
                Console.WriteLine("2. Detect Byte Overflow");
                Console.WriteLine("3. Print a Pyramid");
                Console.WriteLine("4. Guess the Number");
                Console.WriteLine("5. Calculate Days Old and Next Anniversary");
                Console.WriteLine("6. Greet Based on Time of Day");
                Console.WriteLine("7. Count to 24 with Increments");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        RunFizzBuzz();
                        break;
                    case "2":
                        CheckByteOverflow();
                        break;
                    case "3":
                        PrintPyramid();
                        break;
                    case "4":
                        GuessTheNumber();
                        break;
                    case "5":
                        CalculateDaysOldAndNextAnniversary();
                        break;
                    case "6":
                        GreetBasedOnTimeOfDay();
                        break;
                    case "7":
                        CountTo24WithIncrements();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        static void RunFizzBuzz()
        {
            Console.Clear();
            Console.WriteLine("FizzBuzz Game:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void CheckByteOverflow()
        {
            Console.Clear();
            Console.WriteLine("Byte Overflow Check:");
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                if (i == byte.MaxValue)
                {
                    Console.WriteLine("Warning: Byte overflow about to occur!");
                }
                Console.WriteLine(i);
            }
        }

        static void PrintPyramid()
        {
            Console.Clear();
            Console.WriteLine("Print a Pyramid:");
            int levels = 5;
            for (int i = 1; i <= levels; i++)
            {
                for (int j = levels - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void GuessTheNumber()
        {
            Console.Clear();
            int correctNumber = new Random().Next(1, 4);
            Console.WriteLine("Guess the number between 1 and 3:");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is out of the valid range.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        static void CalculateDaysOldAndNextAnniversary()
        {
            Console.Clear();
            Console.Write("Enter your birth date (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int daysOld = (today - birthDate).Days;
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
            Console.WriteLine($"You are {daysOld} days old.");
            Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversary.ToShortDateString()}.");
        }

        static void GreetBasedOnTimeOfDay()
        {
            Console.Clear();
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (hour >= 18 && hour < 21)
            {
                Console.WriteLine("Good Evening");
            }
            if (hour >= 21 || hour < 5)
            {
                Console.WriteLine("Good Night");
            }
        }

        static void CountTo24WithIncrements()
        {
            Console.Clear();
            for (int outer = 1; outer <= 4; outer++)
            {
                for (int inner = 0; inner <= 24; inner += outer)
                {
                    Console.Write(inner + (inner < 24 ? "," : ""));
                }
                Console.WriteLine();
            }
        }
    }
}
