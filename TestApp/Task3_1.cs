using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Task3_1
    {
        public static void Test()
        {
            TestSingleCatArray();
            TestSingleArray();
            TestDeleteInArray();
            TestMultiArray();
            TestJaggedArray();
        }
        private static void TestSingleCatArray()
        {
            Pet cat1 = CatFactory.Mara;
            Pet cat2 = CatFactory.Mammi;
            Pet cat3 = CatFactory.Merly;
            Pet cat4 = CatFactory.Mira;
            Pet doggy1 = DogFactory.Eva;
            Pet doggy2 = DogFactory.Asti;

            // Single-dimensional array
            double[] weightArray = [cat1.Weight, cat2.Weight, cat3.Weight, cat4.Weight];

            // Print the sum of array elements
            Console.WriteLine($"\nThe total weigh of all pets is {weightArray.Sum()} kg");

            // Print elements in reverse order
            Pet[] petsArray = [cat1, cat2, cat3, cat4];
            var orderedByAge = petsArray.OrderByDescending(pet => pet.GetAge()).ToList();
            Pet? maxWeight = petsArray.MaxBy(pet => pet.Weight) ?? petsArray[0];
            Console.WriteLine($"\n The list of the pets order by age: {string.Join(" ", orderedByAge)}");
            orderedByAge.Reverse();
            Console.WriteLine($"\n The list of the pets reverse order by age: {string.Join(" ", orderedByAge)}");

            // Print the max value of array
            Console.WriteLine($"\nThe heaviest pet is {maxWeight.Name}. Her weight is {maxWeight.Weight} kg\n");
        }
        
        private static void TestSingleArray() 
        {
            // array with size [4], fill values 0 and 1, try to get values from 3
            int[] taskArray = new int[4];
            taskArray[0] = 1;
            taskArray[1] = 2;
            Console.WriteLine($"\n3rd element of the array is {taskArray[3]}");
        }

        private static void TestDeleteInArray() 
        {
            int[] taskDeleteInArray = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            // Permanently delete elements [5],[6],[7]
            var arrayAfterDeletion = taskDeleteInArray.Where((val, idx) => idx != 5 && idx != 6 && idx != 7).ToArray();
            Console.WriteLine($"\nCurrent state of the array: {string.Join(" ", arrayAfterDeletion)}");
            Console.WriteLine($"\nCurrent length of the array: {string.Join(" ", arrayAfterDeletion.Length)}");

            // Insert to [4] new element
            var tempList = arrayAfterDeletion.ToList();
            tempList.Insert(4, 9);
            var arrayWIthAddedVal = tempList.ToArray();
            Console.WriteLine($"\nCurrent state of the array: {string.Join(" ", arrayWIthAddedVal)}");
            Console.WriteLine($"\nCurrent length of the array: {string.Join(" ", arrayWIthAddedVal.Length)}");

        }

        private static void TestMultiArray()
        {
            // Multi-dimensional array
            int[,] task2DArray = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // Print the sum of array elements
            int sumOf2DArray = task2DArray.Cast<int>().Sum();
            Console.WriteLine($"\nThe sum of all elements in multi-dimensional array is {sumOf2DArray}");

            // Print elements in reverse order
            var reverseOf2DArray = task2DArray.Cast<int>().Reverse();
            Console.WriteLine($"\nThe reverse view of 2D array {string.Join(" ", reverseOf2DArray)}");

            // Print the max value of array
            var maxOf2DArray = task2DArray.Cast<int>().Max();
            Console.WriteLine($"\nThe max value of 2D array is {maxOf2DArray}");
        }
        private static void TestJaggedArray()
        {
            // Jagged array

        }
    }
}
