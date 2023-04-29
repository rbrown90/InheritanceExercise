using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.DoesFly = true;// TODO Be sure to follow best practice when creating your classes
            myBird.Has2Legs = true;
            myBird.HasWings = 2;
            myBird.HasBeak = true;

            var snake = new Reptile()
            {
                ColdBlooded = "yes",
                IsATetrapod = true,
                CoveredInScales = true,
                IsAnAmphibion = "no"
            };

            var myAnimals = new Animal[] {myBird, snake};

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"NeedsToSleep: {animal.NeedsToSleep}");
                Console.WriteLine($"NeedsToEat: {animal.NeedsToEat}");
                Console.WriteLine($"Animal does has cells: {animal.HasCells}");
                Console.WriteLine($"Animal has {animal.HasLegs}) legs.");
            }
            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
