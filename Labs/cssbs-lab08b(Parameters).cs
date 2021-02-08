#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int lori = 0;
            Console.WriteLine(lori);
            Pass.Value(lori);
            Console.WriteLine(lori);
            lori = Pass.setLori();
            Console.WriteLine(lori);
            Console.ReadKey();

            Console.WriteLine("--------");

            int i = 0;
            Console.WriteLine($"i is {i}");
            Console.WriteLine(i);
            Pass.Value2(ref i);
            Console.WriteLine(i);
            Console.ReadKey();


            Console.WriteLine("--------");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            Console.ReadKey();

            Console.WriteLine(wi.Harvey);
            Pass.Reference2(wi);
            Console.WriteLine(wi.Harvey);

            Console.WriteLine(wi.isTrue);
            Pass.Reference3(wi);
            Console.WriteLine(wi.isTrue);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
