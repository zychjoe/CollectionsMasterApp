using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] numbers = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //Print the first number of the array
            Console.WriteLine($"The first number in the array is {numbers[0]}");

            //Print the last number of the array            
            Console.WriteLine($"The last number is {numbers[49]}");


            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            static void NumberPrinter(int[] numList)
            {
                foreach (int num in numList)
                {
                    Console.WriteLine($"{num}");
                }
            }

            NumberPrinter(numbers);



            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("And now to reverse them back --- ON MY OWN:");

            ReverseArray(numbers);

            NumberPrinter(numbers);

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numbers);
            
            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion
            
            #region Lists
            Console.WriteLine("************Start Lists**************");

            //Set Up   
            //Create an integer List
            List<int> intList = new List<int>();

            //Print the capacity of the list to the console

            Console.WriteLine("First capacity:");
            Console.WriteLine(intList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList);

            //Print the new capacity
            Console.WriteLine("Capacity after adding 50 elements:");
            Console.WriteLine(intList.Capacity);


            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            string userInput = Console.ReadLine();
            int inputInt;
            if (int.TryParse(userInput, out inputInt))
            {
                NumberChecker(intList, inputInt);
            }
            else
            {
                Console.WriteLine($"Woah, buddy! I said a NUMBER! not {userInput}!");
            }
            
                        Console.WriteLine("All Numbers:");

                        NumberPrinter<List<int>>(intList);
            
                        //Create a method that will remove all odd numbers from the list then print results
                        Console.WriteLine("Evens Only!!");

                        OddKiller(intList);
                        NumberPrinter<List<int>>(intList);
            
                        //Sort the list then print results
                        Console.WriteLine("Sorted Evens!!");
                        intList.Sort();
                        NumberPrinter<List<int>>(intList);

                        //Convert the list to an array and store that into a variable

                        int[] intArray = intList.ToArray();
                        //Clear the list

                        intList.Clear();
            #endregion
        }
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            List<int> odds = new List<int>();
            foreach (int num in numberList)
            {
                if(num % 2 != 0)
                {
                    odds.Add(num);
                }
            }

            foreach( int num in odds)
            {
                if (numberList.Contains(num))
                {
                    numberList.Remove(num);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes! {searchNumber}'s here!");
            }
            else
            {
                Console.WriteLine($"Nah, no {searchNumber} here...");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int[] revArray = new int[50];
            for (int i = array.Length; i > 0; i--)
            {
                revArray[50 - i] = array[i - 1];
            }
            array = revArray;
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
