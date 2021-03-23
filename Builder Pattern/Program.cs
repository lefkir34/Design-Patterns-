using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("***Builder Pattern***",ConsoleColor.Yellow);
            Director director = new Director();
            IBuilder carBuilder = new Car("Jeep");
            IBuilder motorCycleBuilder = new MotorCycle("Honda");
            
            // Making Car
            director.Construct(carBuilder);
            Product car = carBuilder.GetVehicle();
            Console.WriteLine($"Car {car.Show()}");
            
            //Making MotorCycle
            director.Construct(motorCycleBuilder);
            Product motorCycle = motorCycleBuilder.GetVehicle();
            Console.WriteLine($"MotorCycle {motorCycle.Show()}");
        }
    }
}
