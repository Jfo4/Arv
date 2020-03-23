using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal djur = new Animal
            //{
            //    Name = "Brunte",
            //    Age = 15,
            //    Weight = 95.5
            //};
            List<Animal> Animals = new List<Animal>()
            {
                // Lista med "Animals" kan lagra alla typer av djur
                new Horse("Brunte", 94.4, 14, 1.001),
                new Dog("Fido", 3.7, 2, false),
                new Dog("Karo", 1.3, 2, true),
                new Pelican("Pippi", 1.4, 3, 1.1, 2.1),
                new Dog("Woof", 4.4, 5, true)
            };
            List<Dog> Dogs = new List<Dog>()
            {
                new Dog("Lassie", 8.3, 8, false),
                //new Horse("Agnes", 89.4, 18, 0.995)
                // Sista "fältet" för Horse har annat format
                // Funkar det om de har samma format, men från olika klasser?
                new Dog("CatKiller", 12.4, 7, true),
                new Dog("Kaka", 24, 22, false)
            };

            Console.WriteLine($"Antal djur i listan Animals: {Animals.Count}");
            Console.WriteLine($"Antal djur i listan Dogs: {Dogs.Count}");
            Console.WriteLine();

            foreach (var animal in Animals)
            {
                if(animal is Dog hund)
                Console.WriteLine($"{hund.Name}, Stat = {hund.Stats()}, {hund.Sleep()}");
                // Sleep finns inte i Animal
            }

            Console.WriteLine("\nAnimal stats:");

            // Skriver ut Stats från respektive Animal-klass
            foreach (var animal in Animals)
            {
                // Substring för att ta bort "Arv." i animal
                Console.WriteLine($"{animal.ToString().Substring(4)}-stats: {animal.Stats()}");
            }
            Console.ReadLine();
            Console.Clear();

            // *************
            // Error handler
            // *************
            List<UserError> userErrors = new List<UserError>()
            {
                new TextInputError("Ogiltigt fel"),
                new NumericInputError(1),
                new NumericInputError(42),
                new TextInputError("Division med 0"),
                new TextInputError("Negativ addition")
            };
            foreach (var err in userErrors)
            {
                Console.WriteLine($"{err.UEMessage()}");
            }
            Console.ReadLine();

            //if (animal is Dog hund)
            //{
            //    Console.WriteLine($"Stats: {hund.Stats()}");
            //    Console.Write($"Vikt: {hund.Weight}");
            //}
            //Console.Write("\nSummering:");
            //Console.WriteLine($"{animal}-stats: {animal.Stats()}");
            //if(animal is Horse horse)
            //{
            //    Console.WriteLine("\nHästar:");
            //    Console.WriteLine($"Stats: {animal.Stats()}");
            //    Console.Write($"Vikt: {horse.Weight}");
            //}
            //List<Animal> djur = new List<Animal>()
            //{
            //    new Horse()
            //};
        }
    }
}
