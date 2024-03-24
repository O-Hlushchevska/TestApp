using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class DogFactory
    {
        public static Pet Eva => new Pet(Pet.PetType.Dog, "Eva", DateTime.Parse("09/12/2015"), "Female", "Doggy", 50.54);
        public static Pet Asti => new Pet(Pet.PetType.Dog, "Asti", DateTime.Parse("09/08/2021"), "Female", "Doggy", 5.54);
    }
}
