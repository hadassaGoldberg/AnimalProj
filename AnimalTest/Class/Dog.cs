using AnimalTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest.Class
{
    class Dog : Animal, Land
    {
        private int numberOfLegs;
        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set { numberOfLegs = value; }
        }
        public Dog(Boolean Mammals, Boolean carnivorous, int Mood) : base(Mammals, carnivorous, Mood)
        {
        }
        public override void SayHello() { Console.WriteLine("wagging their tails") ; }
        public override void SayHello(int i)
        {
            string active = "";
            if (i > 0)
                active = "bark loudly";
            else if (i < 0)
                active = "whooping";
            else
                SayHello();
            Console.WriteLine(active);
        }
        public int GetNumberOfLegs() { return this.NumberOfLegs; }
    }
}
