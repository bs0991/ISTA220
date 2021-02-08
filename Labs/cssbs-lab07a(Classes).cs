
using System;

namespace Classes
{
    class Point
    {
        // These are instance fields, which means each instance of the class has its own copy of this field (or variable or attribute)
        private int _x = 0;
        private int _y = 0;
        private int _z = 0;
        private int serialnum;

        // Static means that it can only be called from within the class and not the object
        // objectCount is a class field
        private static int objectCount = 0;

        public static int ObjectCount()
        {
            return objectCount;
        }
        public Point()
        {
            _x = -1;
            _y = -1;
            objectCount++;
            serialnum = objectCount;
            Console.WriteLine($"Default constructor called, point number {serialnum}");
        }
        // This is a constructor (Same name as class with no output type)
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            objectCount++;
            serialnum = objectCount;
            Console.WriteLine($"x:{x}, y:{y}, point number {serialnum}");
        }
        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
            objectCount++;
            serialnum = objectCount;
            Console.WriteLine($"x:{_x}, y:{_y}, z:{_z}, point number {serialnum}");
        }
        // In this case Point is a type and other is an object
        public double DistanceTo(Point other)
        {
            int xDiff = _x  - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public double DistanceToTriple(Point other2)
        {
            int xDiff = _x - other2._x;
            int yDiff = _y - other2._y;
            int zDiff = _z - other2._z;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff) + (zDiff * zDiff));
            return distance;
        }
    }
}
