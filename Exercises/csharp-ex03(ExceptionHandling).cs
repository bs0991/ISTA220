using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ex03_ExceptionHandling_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp exercise 03.");
            exceptionHandling();
        }

        private static double exceptionHandling()
        {
            // Part 1
            {
                var circarea = circumferenceValue();
                Console.WriteLine($"The circumference is {circarea.Item1}");
                Console.WriteLine($"The area is {circarea.Item2}");
            }

            // Part 2
            {
                double volume = volumeValue();
                Console.WriteLine($"The volume is {volume}");
            }

            // Part 3
            {
                double area = areaValue();
                Console.WriteLine($"The area is {area}");
            }

            // Part 4
            {
                var quadratic = quadraticValue();
                Console.WriteLine($"The positive solution is {quadratic.Item1}.");
                Console.WriteLine($"The negative solution is {quadratic.Item2}.");
            }
            return 0;
        }                

        private static Tuple<double,double> circumferenceValue()
        {
            try
            {
                Console.WriteLine("Part 1: Circumference and area of a circle.");
                Console.Write("Enter an integer for the radius: ");
                string strradius = Console.ReadLine();
                int intradius = int.Parse(strradius);
                double circumference = 2 * Math.PI * intradius;
                double area = Math.PI * (intradius * intradius);

                var circarea = Tuple.Create(circumference, area);

                if (intradius > 0)
                {
                    return circarea;
                }

                if (intradius < 0)
                {
                    throw new ArgumentException("Your number is out of range.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your number is out of range.");
            }
            finally
            {
                Console.WriteLine("Okay");
            }
            return circumferenceValue();            
        }

        private static double volumeValue()
        {
            try
            {
                Console.WriteLine("Part 2: Volume of a hemisphere.");
                Console.Write("Enter an integer for the radius: ");
                string strradius = Console.ReadLine();
                int intradius = int.Parse(strradius);
                double volume = (4 / 3 * Math.PI * (intradius * intradius * intradius)) / 2;

                if (intradius > 0)
                {
                    return volume;
                }

                if (intradius < 0)
                {
                    throw new ArgumentException("Your number is out of range.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your number is out of range.");
            }
            finally
            {
                Console.WriteLine("Okay");
            }
            return volumeValue();
        }

        private static double areaValue()
        {
            try
            {
                Console.WriteLine("Part 3: area of a triangle (Heron's Formula).");

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
                double area = 0;
                area = Math.Sqrt(p * (p - intsidea) * (p - intsideb) * (p - intsidec));

                if (intsidea > 0)
                {
                    return intsidea;
                }

                if (intsidea < 0)
                {
                    throw new ArgumentException("Your number is out of range.");
                }

                if (intsideb > 0)
                {
                    return intsideb;
                }

                if (intsideb < 0)
                {
                    throw new ArgumentException("Your number is out of range.");
                }

                if (intsidec > 0)
                {
                    return intsidec;
                }

                if (intsidec < 0)
                {
                    throw new ArgumentException("Your number is out of range.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your number is out of range.");
            }
            finally
            {
                Console.WriteLine("Okay");
            }
            return areaValue();

        }

        private static Tuple<double, double> quadraticValue()
        {
            try
            {
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

                double positive_num = (-dblb + Math.Sqrt(sqrtpart));
                double negative_num = (-dblb - Math.Sqrt(sqrtpart));

                double result1 = positive_num / denominator;
                double result2 = negative_num / denominator;

                var quadratic = Tuple.Create(result1, result2);


                if (sqrtpart < 0)
                {
                    Console.WriteLine("Cannot take the square root of a negative number.");
                }
                else
                    return quadratic;
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Okay");
            }
            return quadraticValue();
        }
    }
}
 
                
   