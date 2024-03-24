using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Task1_2
    {
        public static void TestClasses()
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
                Pet cat5 = new Pet(Pet.PetType.Cat, "deadpet1", new DateTime(1980, 8, 25), "Female", "British", 5.54);
                cat5.Dispose();
            }

            CatKilling();
            //GC.Collect();

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
        }
    }
}
