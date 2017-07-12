using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    Console.WriteLine(number);

            //}
            ////gives size of list
            //Console.WriteLine(favNumbers.Count);





            //List<string> books = new List<string> { "Cat in the hat", "Dark Tower", "Black House" };
            //Console.WriteLine(books[0]);
            ////inserts at the current index moving the previous element down one
            //books.Insert(0, "It");
            //Console.WriteLine(books[0]);




            // create a list and add 5 animals using the.Add()
            //print each animal in the list

            // List<string> animals = new List<string>();
            //animals.Add("bear");
            //animals.Add("lion");
            //animals.Add("zebra");
            //animals.Add("gorilla");
            //animals.Add("tiger");

            // foreach (string animal in animals)
            // {
            //     Console.WriteLine(animal);

            // }




            //Create the following list:
            //a bool list {true, false, false, true, false}
            //loop through each value
            //if the value is true print "Better bring an umbrella"
            //if the value is false print "No rain today enjoy the sun"

            //List<bool> raining = new List<bool> { true, false, false, true, false };

            //foreach (bool rain in raining)
            //{
            //    if (rain == true)
            //    {
            //        Console.WriteLine("Better grab an umbrella!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today!");
            //    }
            //}

            //List<string> favFoods = new List<string>() { "Steak", "Fish", "Chicken", "Candy", "Greens" };

            //  if (favFoods.Contains("Fish")) 
            //  {
            //      Console.WriteLine("I hate fish!");
            //  }            


            //create a list with the following numbers:1 23 9 77 922 6 32 63 14 5
            //use the contains method with the following values:23 77 15
            //remove these elements:23 77 32 and 6(look up the remove() method)
            //use contains() again on these values

            //List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));            

            //numbers.Remove(23);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);

            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //ask the user for a movie
            //if movie is not in list add it
            //inform user that the movie has been added
            //if the user enters quit the program will terminate andshow list of movies they ordered
            //the user should be able to add as many movies as they want
            //if movie is in list let user know it has been sent

            List<string> movies = new List<string>() { "The Fellowship Of The Ring", "The Two Towers", "The Return Of The King", "A New Hope", "Empire Strikes Back", "Return Of The Jedi", "The Phantom Menace" };
            Console.WriteLine("Please select a movie for rental! If movie is not in list it will be added for  you!");
            string pickedMovie;
            pickedMovie = Console.ReadLine();

                if (movies.Contains(pickedMovie))
                
            {
                Console.WriteLine( );
            }






        }
    }
}
