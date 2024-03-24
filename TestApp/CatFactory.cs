using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class CatFactory
    {
        public static Pet Mara => new Pet(Pet.PetType.Cat, "Mara", DateTime.Parse("25/08/2016"), "Female", "British", 5.54);
        public static Pet Mammi => new Pet(Pet.PetType.Cat, "Mammi", DateTime.Parse("12/07/2020"), "Female", "British", 6.94);
        public static Pet Merly => new Pet(Pet.PetType.Cat, "Merly", DateTime.Parse("11/03/2018"), "Female", "British", 3.56);
        public static Pet Mira => new Pet(Pet.PetType.Cat, "Mira", DateTime.Parse("01/08/2023"), "Female", "British", 1.69);
    }
}