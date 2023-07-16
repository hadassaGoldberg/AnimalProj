using AnimalTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest.Class
{
    class Frog : Animal, Land, Water
    {
        private int numberOfLegs;
        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set { numberOfLegs= value; }
        }
        public Frog(Boolean Mammals, Boolean carnivorous, int Mood) : base(Mammals, carnivorous, Mood)
        {
        }
        public override void SayHello(int i)
        {
            var active = "";
            active = i > 0 ? active = "quack, quack, quack" : i < 0 ? active = "plop into the water" : "Value not Valid";
            Console.WriteLine(active);
        }
        public bool HasGills() { return true;}
        public bool HasLaysEggs() { return true;}
        public int GetNumberOfLegs() { return this.numberOfLegs; }
    }
}
