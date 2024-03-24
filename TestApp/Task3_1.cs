using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Task3_1
    {
        public static void TestArrays()
        {
            TestSingleCatArray();
            TestSingleArray();
            TestDeleteInArray();
            TestMultiArray();
            TestMultiCatArray();
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
            Console.WriteLine($"\nThe total weight of all pets is {weightArray.Sum()} kg");

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
            Console.WriteLine($"\n3rd element of the int array is {taskArray[3]}");

            object[] objectArray = new object[4];
            objectArray[0] = "Object";
            objectArray[1] = CatFactory.Mara;
            Console.WriteLine($"\n3rd element of the object array is {objectArray[3]}");

            float[] floatArray = new float[4];
            floatArray[0] = 34535.45f;
            floatArray[1] = 656579.53435674f;
            Console.WriteLine($"\n3rd element of the float array is {floatArray[3]}");

            long[] longArray = new long[4];
            longArray[0] = 922337203;
            longArray[1] = 6854775807;
            Console.WriteLine($"\n3rd element of the long array is {longArray[3]}");

            string[] stringArray = new string[4];
            stringArray[0] = "Mango";
            stringArray[1] = "Banana";
            Console.WriteLine($"\n3rd element of the string array is {stringArray[3]}");
        }

        private static void TestDeleteInArray() 
        {
            int[] taskDeleteInIntArray = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            object[] taskDeleteInObjectArray = ["Mango", CatFactory.Mara, "Banana", 922337203, CatFactory.Merly, 656579.53435674f, "Apple", CatFactory.Mammi, CatFactory.Mira, 90];
            float[] taskDeleteInFloatArray = [13.17263f, 84.83026f, 30.99372f, 59.6616f, 61.46767f, 45.17126f, 61.95522f, 93.7445f, 46.02798f, 14.73467f];
            long[] taskDeleteInLongArray = [317949394, 814426843, 450488525, 261198928, 167526774, 353225171, 752564584, 727744147, 394885515, 707128204];
            string[] taskDeleteInStringArray = ["1WStS2R7Y", "2cFmNcdw2", "3wzqzZGEl", "4bXn0bF1w", "5vhNmqgP", "6IAt5vR3m", "7ZtBbqKc2", "8sK2QexWg", "9tlzq0bPy", "10KYsEfyj"];


            // Permanently delete elements [5],[6],[7]
            var arrayAfterDeletionInt = taskDeleteInIntArray.Where((val, idx) => idx != 5 && idx != 6 && idx != 7).ToArray();
            Console.WriteLine($"\nInitial state of the int array: {string.Join(" ", taskDeleteInIntArray)}");
            Console.WriteLine($"\nInitial length of the int array: {string.Join(" ", taskDeleteInIntArray.Length)}");
            Console.WriteLine($"\nCurrent state of the int array: {string.Join(" ", arrayAfterDeletionInt)}");
            Console.WriteLine($"\nCurrent length of the int array: {string.Join(" ", arrayAfterDeletionInt.Length)}");

            var arrayAfterDeletionObject = taskDeleteInObjectArray.Where((val, idx) => idx != 5 && idx != 6 && idx != 7).ToArray();
            Console.WriteLine($"\nInitial state of the object array: {string.Join(" ", taskDeleteInObjectArray)}");
            Console.WriteLine($"\nInitial length of the object array: {string.Join(" ", taskDeleteInObjectArray.Length)}");
            Console.WriteLine($"\nCurrent state of the object array: {string.Join(" ", arrayAfterDeletionObject)}");
            Console.WriteLine($"\nCurrent length of the object array: {string.Join(" ", arrayAfterDeletionObject.Length)}");

            var arrayAfterDeletionFloat = taskDeleteInFloatArray.Where((val, idx) => idx != 5 && idx != 6 && idx != 7).ToArray();
            Console.WriteLine($"\nInitial state of the float array: {string.Join(" ", taskDeleteInFloatArray)}");
            Console.WriteLine($"\nInitial length of the float array: {string.Join(" ", taskDeleteInFloatArray.Length)}");
            Console.WriteLine($"\nCurrent state of the float array: {string.Join(" ", arrayAfterDeletionFloat)}");
            Console.WriteLine($"\nCurrent length of the float array: {string.Join(" ", arrayAfterDeletionFloat.Length)}");

            var arrayAfterDeletionLong = taskDeleteInLongArray.Where((val, idx) => idx != 5 && idx != 6 && idx != 7).ToArray();
            Console.WriteLine($"\nInitial state of the long array: {string.Join(" ", taskDeleteInLongArray)}");
            Console.WriteLine($"\nInitial length of the long array: {string.Join(" ", taskDeleteInLongArray.Length)}");
            Console.WriteLine($"\nCurrent state of the long array: {string.Join(" ", arrayAfterDeletionLong)}");
            Console.WriteLine($"\nCurrent length of the long array: {string.Join(" ", arrayAfterDeletionLong.Length)}");

            var arrayAfterDeletionString = taskDeleteInStringArray.Where((val, idx) => idx != 5 && idx != 6 && idx != 7).ToArray();
            Console.WriteLine($"\nInitial state of the string array: {string.Join(" ", taskDeleteInStringArray)}");
            Console.WriteLine($"\nInitial length of the string array: {string.Join(" ", taskDeleteInStringArray.Length)}");
            Console.WriteLine($"\nCurrent state of the string array: {string.Join(" ", arrayAfterDeletionString)}");
            Console.WriteLine($"\nCurrent length of the string array: {string.Join(" ", arrayAfterDeletionString.Length)}");

            // Insert to [4] new element

            //var tempList = arrayAfterDeletionInt.ToList();
            //tempList.Insert(4, 9);
            //var arrayWIthAddedVal = tempList.ToArray();


             

            int indexToInsert = 4;
            int elementToInsert = 444;
            Array.Resize(ref arrayAfterDeletionInt, arrayAfterDeletionInt.Length + 1);
            for (int i = arrayAfterDeletionInt.Length - 1; i > indexToInsert; i--)
            {
                arrayAfterDeletionInt[i] = arrayAfterDeletionInt[i - 1];
            }
            arrayAfterDeletionInt[indexToInsert] = elementToInsert;
            Console.WriteLine($"\nCurrent state of the array: {string.Join(" ", arrayAfterDeletionInt)}");
            Console.WriteLine($"\nCurrent length of the array: {string.Join(" ", arrayAfterDeletionInt.Length)}");
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

        private static void TestMultiCatArray()
        {
            // Multi-dimensional array of custom `Pet` type
            Pet[,] taskCatMultiArray = { { CatFactory.Mara, CatFactory.Mira }, { CatFactory.Merly, CatFactory.Mammi } };

            // Print the sum of cat's weight
            var sumOfCatMultiArray = taskCatMultiArray.Cast<Pet>().Select(pet => pet.Weight).Sum();
            Console.WriteLine($"\n The sum of cat's weight is {sumOfCatMultiArray}");

            // Print cat's weight in reverse order
            var reverseOfCatMultiArray = taskCatMultiArray.Cast<Pet>().Select(pet => pet.Weight).Reverse();
            Console.WriteLine($"\n The reverse view of cat's weight {string.Join(" ", reverseOfCatMultiArray)}");

            // Print the max value of cat's weight
            var maxOfCatMultiArray = taskCatMultiArray.Cast<Pet>().Select(pet => pet.Weight).Max();
            Console.WriteLine($"\n The max value of cat's weight is {maxOfCatMultiArray}");
        }

        private static void TestJaggedArray()
        {
            // Jagged array
            int[][,] jaggedArray =
                [
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
                ];

            // Print the sum of array elements
            var sumOfJaggedArray = jaggedArray.SelectMany(item => item.Cast<int>()).Sum();
            Console.WriteLine($"\nThe sum of all elements in jagged array is {sumOfJaggedArray}");

            // Print elements in reverse order
            var reverseOfJaggedArray = jaggedArray.SelectMany(item => item.Cast<int>()).Reverse();
            Console.WriteLine($"\nThe reverse view of jagged array {string.Join(" ", reverseOfJaggedArray)}");

            // Print the max value of array
            var maxOfJaggedArray = jaggedArray.SelectMany(item => item.Cast<int>()).Max();
            Console.WriteLine($"\nThe max value of jagged array is {maxOfJaggedArray}");
        }
    }
}