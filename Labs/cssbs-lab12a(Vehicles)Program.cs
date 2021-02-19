using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Test Vehicle");
            Vehicle w = new Vehicle();
            w.StartEngine("vroom vroom");
            w.Drive();
            w.StopEngine("putt putt putt");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("\nTesting polymorphism");
            w.Drive();
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Journey by motorcycle");
            Motorcycle ducati = new Motorcycle();
            ducati.StartEngine("whoom whoom");
            ducati.Accelerate();
            ducati.Drive();
            ducati.Brake();
            ducati.StopEngine("clunk");
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
