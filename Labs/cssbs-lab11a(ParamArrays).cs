using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Util.Sum(null));
            //Console.WriteLine(Util.Sum());
            Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(Util.Sum(5));
            Console.WriteLine(Util.Sum(2, 36));
            Console.WriteLine(Util.Sum(1,5,9));
            Console.WriteLine(Util.Sum(74,63,2,8));
            Console.WriteLine(Util.Sum(23,24,25,26,27));
            Console.WriteLine(Util.Sum(54,1,74,3,8,6));

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
