using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class FoodFactory
    {
        public static Food Pashtetik => new Food(Food.TypeOfFood.Pashtetik, Food.FoodSpeciality.Wet, new DateTime(2024, 12, 12));
        public static Food Kormik => new Food(Food.TypeOfFood.Pashtetik, Food.FoodSpeciality.Dry, new DateTime(2026, 1, 1));
        public static Food Smakolyk => new Food(Food.TypeOfFood.Smakolyk, Food.FoodSpeciality.Wet, new DateTime(2024, 02, 10));
    }
}