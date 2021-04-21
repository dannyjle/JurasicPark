using System;

namespace JurasicPark
{
    class Dino
    {
        // Then we’re going to create a  Dino Class for pulling information into the list we are going to create that includes 
        /////////////
        ///////////// Name: 
        ///////////// DietType: 
        ///////////// WhenAcquired: supplied by code (DateTime of DateCreated)
        ///////////// Weight: 
        ///////////// EnclosureNumber:

        public string Name { get; set; }
        public string DietType { get; set; }
        public string WhenAcquired { get; set; }
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

        static void Main(string[] args)
        {

            Greeting();







        }
    }
}
