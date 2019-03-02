using System;

namespace ClassesExamples
{
    class Program
    {
        //Public can be accessed from anywhere, Private can't be accessed from anywhere. Kinda like global and local variables.

        //string _myData = "this is just for me to use"; //This is a field and it is kinda like a private state
        //public int Number { get; set; } //This is a property and it is kinda like a public state

        //public void DoTheThing()
        //{
        //Number = 1; //set Number
        //var x = Number; //get Number
        //}


        static void Main(string[] args) //The static method is also private
        {
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10);
            taffy.SetRating(5, "kinda liked it");

            Console.WriteLine(taffy);
 
        }
        
    }
}
