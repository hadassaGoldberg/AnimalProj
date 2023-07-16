using AnimalTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest.Class
{
    class Cat : Animal, Land
    {
        private int numberOfLegs;
        public int NumberOfLegs 
        { 
            get { return numberOfLegs; }  
            set { numberOfLegs = value; } 
        }
        public  Cat(Boolean Mammals, Boolean carnivorous, int Mood) : base(Mammals, carnivorous, Mood) 
        {
        } 
        public override void SayHello() { Console.WriteLine("meow~"); }
        public override void SayHello(int i)
        {
            var active = "";
            if (i > 0)
                active = "purr, purr";
            else if (i < 0)
                active = "hiss";
            else
                SayHello();

            Console.WriteLine(active);
        }
        public int GetNumberOfLegs() { return NumberOfLegs; }
    }
}
