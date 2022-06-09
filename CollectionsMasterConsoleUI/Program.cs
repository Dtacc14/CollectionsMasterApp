using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇ 
          
            #region Arrays
            var numberArray = new int[50];//TODO: Create an integer Array of size 50

            Populater(numberArray);//TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Console.WriteLine(numberArray[0]);  //TODO: Print the first number of the array

            Console.WriteLine(numberArray[49]); //TODO: Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            NumberPrinter(numberArray);                  //UNCOMMENT this method to print out your numbers from arrays or lists
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(numberArray);
            NumberPrinter(numberArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");   //TODO: Create a method that will set numbers that are a multiple
            ReverseArray(numberArray);                                   // of 3 to zero then print to the console all numbers
            NumberPrinter(numberArray);
            Console.WriteLine("-------------------");
            Console.WriteLine($"Multiple of three = 0: ");
            ThreeKiller(numberArray);
            NumberPrinter(numberArray);
            Console.WriteLine("-------------------");

            Console.WriteLine("Sorted numbers:");   //TODO: Sort the array in order now
            Array.Sort(numberArray);                //     Hint: Array.____()
            NumberPrinter(numberArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            var listName = new List<int>(); //TODO: Create an integer List

            //TODO: Print the capacity of the list to the console

            Populater(listName);              //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this 
            NumberPrinter(listName);          //TODO: Print the new capacity
            Console.WriteLine($"Capacity = {listName.Capacity}");
            Console.WriteLine("---------------------");

            int number;
            bool success;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                success = int.TryParse(Console.ReadLine(), out number);  //TODO: Create a method that prints if a user number is present in the list
            }                                                            //Remember: What if the user types "abc" accident your app should handle that!
            while (success == false);

            NumberChecker(listName, number);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(listName);                   //UNCOMMENT this method to print out your numbers from arrays or lists
            Console.WriteLine("-------------------");

            Console.WriteLine("Evens Only!!");
            OddKiller(listName);                        //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("------------------");

            Console.WriteLine("Sorted Evens!!");
            listName.Sort();                             //TODO: Sort the list then print results
            NumberPrinter(listName);
            Console.WriteLine("------------------");

            listName.ToArray();                          //TODO: Convert the list to an array and store that into a variable

            listName.Clear();                            //TODO: Clear the list

            #endregion
        }
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = numbers.Length - 1 ; i >= 0 ; i--)
            {
                if (numbers[i] %3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1 ; i >= 0 ; i--)
            {
                if (numberList[i] %2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            NumberPrinter(numberList);
        }
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            Console.WriteLine((numberList.Contains(searchNumber) ? "This number is present!" : "This number is not present.")); 
        }
        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                var num1 = rng.Next(1 , 50);
                numberList.Add(num1);
            }
        }
        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1 , 50);
            }
        }        
        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            foreach (var item in collection)
            {                                 
                Console.WriteLine(item);       //STAY OUT DO NOT MODIFY!!
            }
        }
    }
}
