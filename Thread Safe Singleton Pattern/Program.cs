using System;
using System.Threading.Tasks;
namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Factory.StartNew(() => {
                        Counter obj1 =  Counter.GetInstance();
                        obj1.AddOne();
                        Console.WriteLine("counter 1 value is : {0}", obj1.count);

                    }
                    );

            Task task2 = Task.Factory.StartNew(() => {
                            Counter obj2 =Counter.GetInstance();
                            obj2.AddOne();
                            Console.WriteLine("counter 2 value is : {0}", obj2.count);
                            Console.WriteLine();
                      }
                    );

         
            Console.ReadKey();

            
        }
    }
}
