using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1: circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            double area = Math.PI * (intradius * intradius);
            Console.WriteLine($"The circumference is {circumference}");
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2: volume of a hemisphere.");
            double volume = (4 / 3 * Math.PI * (intradius * intradius * intradius)) / 2;
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3: area of a triangle (Heron's Formula).");
            Console.Write("Enter an integer for side a: ");
            string strsidea = Console.ReadLine();
            int intsidea = int.Parse(strsidea);
            Console.Write("Enter an integer for side b: ");
            string strsideb = Console.ReadLine();
            int intsideb = int.Parse(strsideb);
            Console.Write("Enter an integer for side c: ");
            string strsidec = Console.ReadLine();
            int intsidec = int.Parse(strsidec);
            double p = (intsidea + intsideb + intsidec) / 2;
            area = Math.Sqrt(p * (p - intsidea) * (p - intsideb) * (p - intsidec));
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 4: solving a quadratic equation.");
            Console.Write("Enter an integer for coefficient a: ");
            string stra = Console.ReadLine();
            Console.Write("Enter an integer for coefficient b: ");
            string strb = Console.ReadLine();
            Console.Write("Enter an integer for coefficient c: ");
            string strc = Console.ReadLine();
            double dbla = double.Parse(stra);
            double dblb = double.Parse(strb);
            double dblc = double.Parse(strc);
            double sqrtpart = (dblb * dblb) - (4 * dbla * dblc);
            double denominator = 2 * dbla;
            if (sqrtpart > 0)
            {
                double positive_num = (-dblb + Math.Sqrt(sqrtpart));
                double negative_num = (- dblb - Math.Sqrt(sqrtpart));
                Console.WriteLine($"The positive solution is {positive_num / denominator}.");
                Console.WriteLine($"The negative solution is {negative_num / denominator}.");
            }
            else if (sqrtpart < 0)
            {
                Console.WriteLine("Cannot take the square root of a negative number.");
            }
        }
    }
}
