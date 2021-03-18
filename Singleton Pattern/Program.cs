using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Counter obj1 =  Counter.GetInstance();
            obj1.AddOne();
            Counter obj2 =Counter.GetInstance();
            obj2.AddOne();
            Console.WriteLine("counter value is : {0}", obj1.count);
        }
    }
}
