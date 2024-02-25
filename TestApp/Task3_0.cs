using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Task3_0
    {
        public static void Test()
        {
            Pet cat1 = CatFactory.Mara;
            Pet cat2 = CatFactory.Mammi;
            Pet cat3 = CatFactory.Merly;
            Pet cat4 = CatFactory.Mira;
            Pet doggy = DogFactory.Eva;
            Pet doggy2 = DogFactory.Asti; 

            double[] weightArray = [cat1.Weight, cat2.Weight, cat3.Weight, cat4.Weight];
            Console.WriteLine($"\nThe total weigh of all pets is {weightArray.Sum()} kg");

            Pet[] petsArray = [cat1, cat2, cat3, cat4];
            var orderedByAge = petsArray.OrderByDescending(pet => pet.GetAge()).ToList();
            Pet? maxWeight = petsArray.MaxBy(pet => pet.Weight) ?? petsArray[0];
            Console.WriteLine($"\n The list of the pets order by age: {string.Join(" ", orderedByAge)}");
            orderedByAge.Reverse();
            Console.WriteLine($"\n The list of the pets reverse order by age: {string.Join(" ", orderedByAge)}");
            Console.WriteLine($"\nThe heaviest pet is {maxWeight.Name}. Her weight is {maxWeight.Weight} kg\n");

            List<Pet> pets = orderedByAge.ToList();
            Console.WriteLine(string.Join(", ", pets));
            pets.Add(doggy);
            Console.WriteLine(string.Join(", ", pets));

            pets.Remove(pets[3]);
            pets.Remove(pets[0]);
            pets.Remove(pets[2]);
            Console.WriteLine(string.Join(", ", pets));
            pets.Add(doggy);

            var petsFind = pets.Find(pet => pet.Name.Contains("Mammi"));
            Console.WriteLine(string.Join(", ", petsFind));

            if (pets.Contains(doggy))
            {
                Console.WriteLine("There is a doggy");
            }
            else
            {
                Console.WriteLine("There is no doggy");
            }


            pets.Remove(doggy);
            if (pets.Contains(doggy))
            {
                Console.WriteLine("There is a doggy");
            }
            else
            {
                Console.WriteLine("There is no doggy");
            }

            pets.Add(cat4);
            pets[2] = doggy;
            Console.WriteLine(string.Join(", ", pets));

            pets.Clear();
            Console.WriteLine(string.Join(", ", pets));
        }
    }
}
