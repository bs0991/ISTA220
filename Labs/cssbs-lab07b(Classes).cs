using System;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point(3, 4);
            Point origin2 = new Point();
            Point orgin3 = new Point(5, 6, 7);
            Point botomRight = new Point(1366, 768);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);
            Point origin4 = new Point(1, 2, 3);
            Console.WriteLine($"Distance between point1 and point2 is: " +
                $"{point1.DistanceTo(point2)}");

            Console.WriteLine($"Distance between point2 and point1 is: " +
                $"{point2.DistanceTo(point1)}");

            Console.WriteLine($"Distance between point1 and point1 is: " +
                $"{point1.DistanceTo(point1)}");

            Console.WriteLine($"The number of points created is: " +
                $"{Point.ObjectCount()}");

            Console.WriteLine($"Distance between origin 3 and origin 4 is: " +
                $"{orgin3.DistanceToTriple(origin4)}");
        }

        // static in this case creates a class member
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
