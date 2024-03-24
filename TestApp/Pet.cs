using System.Linq;

namespace TestApp
{
    public class Pet:IDisposable
    {
        public enum PetType
        {
            Cat,
            Dog
        }

        public static bool shouldPrint = true;

        public static int population = 0;

        private DateTime dateOfBirth;
        private string sex;
        private string breed;
        private PetType type;

        public double Weight { get; set; }

        public string Name { get; set; }

        public Pet(PetType type, string name, DateTime dateOfBirth, string sex, string breed, double weight)
        {
            Name = name;
            this.dateOfBirth = dateOfBirth;
            this.sex = sex;
            this.breed = breed;
            Weight = weight;
            this.type = type;
            population++;
            //if (shouldPrint)
            //    Console.WriteLine($"A new pet has been born. You have {population} pets");
        }

        //~Pet()
        //{
        //    population--;
        //    if (shouldPrint)
        //        Console.WriteLine($"Pet {Name} is gone. You have {population} pets left");
        //}

        public void Dispose() 
        {
            population--;
            if (shouldPrint)
                Console.WriteLine($"Pet {Name} is gone. You have {population} pets left");
        }

        public int GetAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        public string GetInfo()
        {
            string type = "Unknown";
            switch (this.type)
            {
                case PetType.Cat:
                    type = "Cat";
                    break;
                case PetType.Dog:
                    type = "IMPOSTER";
                    break;
            };

            return $"\n Pets' information:" +
                $"\n 1) Type: {type}" +
                $"\n 2) Name: {Name}" +
                $"\n 3) Sex: {sex}" +
                $"\n 4) Age: {GetAge()} years old" +
                $"\n 5) Weight: {Weight} kg" +
                $"\n 6) Breed: {breed}";
        }
        public override string ToString()
        {
            return $"{Name}, {GetAge()} years, {Weight} kg";
        }
    }
}