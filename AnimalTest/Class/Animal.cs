
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest.Class
{
    abstract class Animal
    {
        private int moodScare;
        private int moodHappy;
        public  Boolean Mammals { get; set; }
        public Boolean Carnivorous { get; set; }
        public int MoodScare 
        {
            get { return moodScare; }
            set { if (value < 0) moodScare = value ; }
        }
        public int MoodHappy
        {
            get { return moodHappy; }
            set { if (value > 0) moodHappy = value; }
        }
        public int Mood { get; set ; }
        public Animal(Boolean Mammals, Boolean carnivorous, int Mood)
        {
            this.Mammals = Mammals;
            this.Carnivorous = carnivorous;
            this.Mood = Mood;
        }
        public virtual void SayHello() { }
        public abstract void SayHello(int i);
        public Boolean IsMammals() { return Mammals; }
        public void SetMammals(Boolean Mammals) { this.Mammals = Mammals; }
        public Boolean IsCarnivorous() { return Carnivorous; }
        public void SetCarnivorous(Boolean carnivorous) { this.Carnivorous = carnivorous; }
    }
}
