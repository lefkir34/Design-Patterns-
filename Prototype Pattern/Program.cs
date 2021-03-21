using System;

namespace Prototype_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            RegularEmployee emp1 = new RegularEmployee{
                Id=1,
                Name = "emp 1",
                age = 35,
                Address = new Address{
                   
                    City = "City 1",
                    Building = "Building 1",
                    Street="Street 1"
                }
            };
            Console.WriteLine( emp1.ToString());
            Console.WriteLine();
            RegularEmployee emp2 = emp1.ShallowCopy();

             Console.WriteLine( emp2.ToString());
             Console.WriteLine();


            RegularEmployee emp3 = emp1.DeepCopy();

             Console.WriteLine( emp3.ToString());
             Console.WriteLine();
        }
    }
}
