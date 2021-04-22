using System;
using System.Collections.Generic;
using System.Linq;

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
        public string Description()
        {
            return $"Name: {Name}, Diet Type: {DietType}, Weight: {Weight}, Enclosure Number: {EnclosureNumber}, Acquired: {WhenAcquired}";
        }



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





            var keepGoing = true;

            // Then we are going to create a boolean statement to run a “While” loop for our program.
            while (keepGoing)


            {
                // Next we're going to be asking the user if they wish to [V]iew, [A]dd, [R]emove, [T]ransfer, Diet [S]ummary, or [Quit] by creating a simple menu prompt.
                Console.WriteLine();
                Console.Write("What do you want to do? [V]iew, [D]escription [A]dd, [R]emove, [T]ransfer, [S]ummary of Diet, or [Q]uit ? ");
                var choice = Console.ReadLine().ToUpper();
                Console.WriteLine();


                // IF QUIT
                if (choice == "Q")
                {
                    keepGoing = false;
                    Console.WriteLine("Exiting Database.... GOODBYE :)");
                }
                // IF REMOVE
                else if (choice == "R")
                {
                    var name = PromptForString("Who do you want to Remove?: ").ToUpper();

                    var foundDino = dinoList.FirstOrDefault(dino => dino.Name == name);

                    if (foundDino == null)
                    {
                        Console.WriteLine("I can't find that Dinosaur to delete!");
                    }
                    else
                    {
                        dinoList.Remove(foundDino);
                        Console.WriteLine($"{name} has been Removed!");
                    }
                }

                // IF TRANSFER
                else if (choice == "T")
                {
                    var name = PromptForString("Which Dinosaur do you wish to Transfer? ").ToUpper();
                    int index = dinoList.FindIndex(dino => name == dino.Name);

                    if (index == -1)
                        Console.WriteLine($"Could not find '{name}' in the records!");
                    else
                    {
                        var newEnclosure = PromptForInteger($"What Enclosure Number do you want to transfer {name} to? ");
                        dinoList[index].EnclosureNumber = newEnclosure;
                        Console.WriteLine($"Transfering {name} to Enclosure Number:{newEnclosure} .... DONE!");
                    }
                }
                // IF DESCRIPTION 

                else if (choice == "D")
                {
                    if (dinoList.Count > 0)
                    {
                        foreach (var dino in dinoList)
                            Console.WriteLine(dino.Description());
                    }
                }

                // IF SUMMARY
                else if (choice == "S")
                {

                    var carns = 0;
                    var herbs = 0;

                    foreach (var dino in dinoList)
                    {
                        if (dino.DietType == "carnivore")
                            carns++;
                        else if (dino.DietType == "herbivore")
                            herbs++;
                    }

                    Console.WriteLine($"There are {carns} Carnivores and {herbs} Herbivores.");
                }

                // IF VIEW
                else if (choice == "V")
                {
                    Console.WriteLine("Would you like to View [A]LL or by [D]ATE added? ");
                    var answer = Console.ReadLine().ToUpper();
                    if (answer == "A")
                    {
                        foreach (var saur in dinoList)
                        {

                            Console.WriteLine(saur.Name);
                        }
                    }
                    else if (answer == "D")
                    {
                        foreach (var saur in dinoList)
                        {
                            var WhenAcquired = dinoList.OrderBy(dinosaur => dinosaur.WhenAcquired);
                            Console.WriteLine(saur.Name);
                            Console.WriteLine(saur.WhenAcquired);
                        }
                    }


                }
                //IF ADD
                else
                {
                    var dino = new Dino();
                    dino.Name = PromptForString("What is the Dinosaur's name? ").ToUpper();
                    dino.DietType = PromptForString("What is the Dinosaur's diet type: [Carnivore/Herbivore]? ").ToUpper();
                    dino.WhenAcquired = DateTime.Now;
                    dino.Weight = PromptForInteger("What is the Dinosaur's weight [in pounds]? ");
                    dino.EnclosureNumber = PromptForInteger("What is the Dinosaur's enclosure number?");

                    Console.WriteLine();
                    Console.WriteLine($"The new Dinosaur -{dino.Name}- will be added to the Database!");
                    Console.WriteLine();



                    dinoList.Add(dino);
                }
            }

        }




    }
}

