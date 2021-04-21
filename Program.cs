using System;

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

            //Also create prompt lines for the Dino Class that have been listed: Name, DietType, WhenAcquired, Weight, EnclosureNumber.
            var dino = new Dino();

            dino.Name = PromptForString("What is the Dinosaur's name? ").ToUpper();
            dino.DietType = PromptForString("What is the Dinosaur's diet type: [Carnivore/Herbivore]? ").ToUpper();
            dino.WhenAcquired = DateTime.Now;
            dino.Weight = PromptForInteger("What is the Dinosaur's weight [in pounds]? ");
            dino.EnclosureNumber = PromptForInteger("What is the Dinosaur's enclosure number?");

            Console.WriteLine($"The new Dinosaur -{dino.Name}- will be added to the Database!");



            // Then we are going to create a boolean statement to run a “While” loop for our program.

            var keepGoing = true;

            while (keepGoing)

            {

            }




        }
    }
}
