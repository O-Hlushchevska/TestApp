using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Task_1_2
    {
        public static void Test()
        {
            Pet cat1 = CatFactory.Mara;
            Pet cat2 = CatFactory.Mammi;
            Pet cat3 = CatFactory.Merly;
            Pet cat4 = CatFactory.Mira;
            Pet doggy = DogFactory.Eva;
            Pet doggy2 = DogFactory.Asti;

            var food1 = FoodFactory.Pashtetik;
            var food2 = FoodFactory.Kormik;
            var food3 = FoodFactory.Smakolyk;

            void CatKilling()
            {
                Pet cat5 = new Pet("Cat", "deadpet1", new DateTime(1980, 8, 25), "Female", "British", 5.54);
            }

            CatKilling();
            GC.Collect();

            Console.WriteLine($"{cat1.GetInfo()}");
            Console.WriteLine($"{cat2.GetInfo()}");
            Console.WriteLine($"{doggy.GetInfo()}");
            Console.WriteLine($"{cat3.GetInfo()}");
            Console.WriteLine($"{cat4.GetInfo()}");

            //int number = 34;
            //object boxedNumber = number;
            //number = 45;
            //boxedNumber = 20;
            //number = (int) boxedNumber;
            //number = 0;;

            void WriteFoodInfo(Pet pet, Food food1, Food food2, Food food3)
            {
                Console.WriteLine($"\nDaily food portion for {pet.Name} \n\t   is {food1.DailyPortion(pet):f3} grams of {food1.Name}. Expiration date: {food1.GetExpirationDate()}");
                Console.WriteLine($"\tor is {food2.DailyPortion(pet):f3} grams of {food2.Name}. Expiration date: {food2.GetExpirationDate()}");
                Console.WriteLine($"\tor is {food3.DailyPortion(pet):f3} grams of {food3.Name}. Expiration date: {food3.GetExpirationDate()}");
            }

            WriteFoodInfo(cat1, food1, food2, food3);
            WriteFoodInfo(cat2, food1, food2, food3);
            WriteFoodInfo(cat3, food1, food2, food3);  
            WriteFoodInfo(cat4, food1, food2, food3);
        }
    }
}
