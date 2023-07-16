using AnimalTest.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat(true, true, 1) { };
            c.NumberOfLegs = 4;
            c.SayHello();
            c.SayHello(1);
            c.SayHello(-1);
            c.SayHello(0);
            Console.WriteLine(c.GetNumberOfLegs());

            Dog d = new Dog(true, true, 1) { };
            d.NumberOfLegs = 4;
            d.SayHello();
            d.SayHello(1);
            d.SayHello(-1);
            d.SayHello(0);
            Console.WriteLine(c.GetNumberOfLegs());

            Frog f = new Frog(false, false, 1) { };
            f.NumberOfLegs = 4;
            f.SayHello();
            f.SayHello(-1);
            f.SayHello(0);
            Console.WriteLine(f.GetNumberOfLegs());
            Console.WriteLine(f.HasLaysEggs());
            Console.WriteLine(f.HasGills());

            Console.ReadLine();

           }
    }
}
