using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class DogFactory
    {
        public static Pet Eva => new Pet("Dog", "Eva", DateTime.Parse("09/12/2015"), "Female", "doggy", 50.54);
        public static Pet Asti => new Pet("Dog", "Asti", DateTime.Parse("09/08/2021"), "Female", "doggy", 5.54);
    }
}
