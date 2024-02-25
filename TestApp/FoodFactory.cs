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
        public static Food Pashtetik => new Food("Pashtetik", 0.2f, 22, 'W', 0.02, new DateTime(2024, 12, 12));
        public static Food Kormik => new Food("Kormik", 1.24f, 1, 'D', 0.03, new DateTime(2026, 1, 1));
        public static Food Smakolyk => new Food("Smakolyk", 0.0632f, 11, 'W', 0.01, new DateTime(2024, 02, 10));
    }
}
