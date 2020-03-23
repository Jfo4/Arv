using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Animal
    {
        public string Name;
        public double Weight;
        public int Age;
        //Nytt attribut för alla djur skrivs här

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual string Stats()
        {
            return "Name, Weight, Age";
        }
    }

    class Horse : Animal
    {
        public double HorsePower { get; set; }

        public Horse(string name, double weight, int age, double horsePower) : base(name, weight, age)
        {
            HorsePower = horsePower;
        }

        public override string Stats()
        {
            return "Name, Weight, Age, Horsepower";
        }
    }
    class Dog : Animal
    {
        public bool Bites { get; set; }
        public Dog(string name, double weight, int age, bool bites) : base(name, weight, age)
        {
            Bites = bites;
        }
        public override string Stats()
        {
            return "Name, Weight, Age, Bites";
        }
        public string Sleep() => "Zzzzzzzzzzz";
    }
    class Hedgehog : Animal
        {
        public int Spikes { get; set; }
        public Hedgehog(string name, double weight, int age, int spikes) : base(name, weight, age)
        {
            Spikes = spikes;
            }
        public override string Stats()
        {
            return "Name, Weight, Age, Spikes";
        }
    }
    class Worm : Animal
    {
        public int Length { get; set; }
        public Worm(string name, double weight, int age, int length) : base(name, weight, age)
        {
            Length = length;
        }
    }
    class Bird : Animal
    {
        public double WingSpan { get; set; }
        //lägg till attribut som gäller för alla fåglar här.

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }
    }
    class Pelican : Bird
    {
        public double Beak { get; set; }
        public Pelican(string name, double weight, int age, double wingSpan, double beak) : base(name, weight, age, wingSpan)
        {
            Beak = beak;
        }
    }
    class Flamingo : Bird
    {
        public double Color { get; set; }
        public Flamingo(string name, double weight, int age, double wingSpan, double color) : base(name, weight, age, wingSpan)
        {
            Color = color;
        }
    }
    class Swan : Bird
    {
        public bool Song { get; set; }
        public Swan(string name, double weight, int age, double wingSpan, bool song) : base(name, weight, age, wingSpan)
        {
            Song = song;
        }
    }
}
