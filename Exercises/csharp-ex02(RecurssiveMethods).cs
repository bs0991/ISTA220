using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 (sum of 10 numbers)
            Console.WriteLine("Part 1, sum 10 numbers.");
            int sum = SumTenInts(0, 1);
            char letterGrade = 'X';
            Console.WriteLine($"The sum is {sum}");
            
            // Part 2 (avg 10 scores)
            Console.WriteLine("Part 2, average 10 numbers.");
            double avg = AvgTenInts(0, 1);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            // Part 3, average user predetermined number of scores
            Console.WriteLine("Part 3, average user predetermined number of scores.");
            Console.Write("How many scores do you wish to enter? ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 1, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            // Part 4, average non-predetermined number of scores
            Console.WriteLine("Part 4, average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 1);
            letterGrade = ConvertNumericToLetterGrade(avg2); 
            Console.WriteLine($"The average of the integers is {avg2} and the letter grade is {letterGrade}");
        }

        private static char ConvertNumericToLetterGrade(double grade)
        {
            if (grade >= 90)
                return 'A';
            else if (grade >= 80 && grade < 90)
                return 'B';
            else if (grade >= 70 && grade < 80)
                return 'C';
            else if (grade >= 60 && grade < 70)
                return 'D';
            else
                return 'F';
        }

        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10)
                return SumTenInts(sum, count + 1);
            else
                return sum;
        }

        private static double AvgTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10)
                return AvgTenInts(sum, count + 1);
            else
                return sum / count;
        }

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < numScores)
                return AvgUnkInts(sum, count + 1, numScores);
            else
                return sum / count;
        }
        private static double AvgAnyInts(int sum, int count)
        {
            Console.Write("Enter a score (enter Quit when complete): ");
            string input = Console.ReadLine();
            if (input == "Quit")
                return sum / --count;
            else
                sum += int.Parse(input);
            if (count > 0)
                return AvgAnyInts(sum, count + 1);
            else
                return sum / --count;
        }
    }
}
