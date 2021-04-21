using System;
using System.Collections.Generic;

namespace JurasicPark
{
    class Dino
    {
        // Then we’re going to create a  Dino Class for pulling information into the list we are going to create that includes: 
        /////////////
        ///////////// Name: 
        ///////////// DietType: 
        ///////////// WhenAcquired: supplied by code (DateTime of DateCreated)
        ///////////// Weight: 
        ///////////// EnclosureNumber:

        public string Name { get; set; }
        public string DietType { get; set; }
        public DateTime WhenAcquired { get; set; } = DateTime.Now;
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }

        //Added a description method
        public string Description { get; set; }


    }
    class Program
    {

        static void Greeting()
        {
            // First we’re creating a greeting/ welcome for “Jurassic Park Database” in code.
            Console.WriteLine();
            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Welcome to the Jurasic Park Database!");
            Console.WriteLine(new String('*', 40));
            Console.WriteLine();
        }


        // code to take user input 
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);
            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                // got this code form the example to make sure inputting something random won't crash program.

                Console.WriteLine("Sorry... what was that?? Uh I'm just gonna use 0 as your answer...");
                return 0;
            }
        }

        static void Main(string[] args)
        {

            Greeting();

            // Next we are going to create a List to store all the Dino information that we are going to obtain from the prompting statements we will be creating later.
            var dinoList = new List<Dino>();


            //Also create prompt lines for the Dino Class that have been listed: Name, DietType, WhenAcquired, Weight, EnclosureNumber.
            var dino = new Dino();

            dino.Name = PromptForString("What is the Dinosaur's name? ").ToUpper();
            dino.DietType = PromptForString("What is the Dinosaur's diet type: [Carnivore/Herbivore]? ").ToUpper();
            dino.WhenAcquired = DateTime.Now;
            dino.Weight = PromptForInteger("What is the Dinosaur's weight [in pounds]? ");
            dino.EnclosureNumber = PromptForInteger("What is the Dinosaur's enclosure number?");

            //Added a description line
            dino.Description = $"Name: {dino.Name}, Diet: {dino.DietType}, Date Acquired: {dino.WhenAcquired}, Weight: {dino.Weight}, Enclosure Number: {dino.EnclosureNumber} ";

            Console.WriteLine();
            Console.WriteLine($"The new Dinosaur -{dino.Name}- will be added to the Database!");
            Console.WriteLine();

            dinoList.Add(dino);

            // Then we are going to create a boolean statement to run a “While” loop for our program.

            var keepGoing = true;

            while (keepGoing)

            {
                // Next we're going to be asking the user if they wish to [V]iew, [A]dd, [R]emove, [T]ransfer, Diet [S]ummary, or [Quit] by creating a simple menu prompt.
                Console.WriteLine();
                Console.Write("What do you want to do? [V]iew, [A]dd, [R]emove, [T]ransfer, Diet [S]ummary, or [Quit] ? ");
                var choice = Console.ReadLine().ToUpper();
                Console.WriteLine();

                // If View

                if (choice == "Q")
                {
                    keepGoing = false;
                }
                else if (choice == "A")
                {
                    dino.Name = PromptForString("What is the Dinosaur's name? ").ToUpper();
                    dino.DietType = PromptForString("What is the Dinosaur's diet type: [Carnivore/Herbivore]? ").ToUpper();
                    dino.WhenAcquired = DateTime.Now;
                    dino.Weight = PromptForInteger("What is the Dinosaur's weight [in pounds]? ");
                    dino.EnclosureNumber = PromptForInteger("What is the Dinosaur's enclosure number?");


                    dinoList.Add(dino);
                }


            }




        }
    }
}
