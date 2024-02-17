namespace TestApp
{
    public class Pet
    {
        public static int population = 0;

        private DateTime dateOfBirth;
        private string sex;
        private string breed;
        private string type;

        public double Weight { get; set; }

        public string Name { get; set; }

        public Pet(string type, string name, DateTime dateOfBirth, string sex, string breed, double weight)
        {
            Name = name;
            this.dateOfBirth = dateOfBirth;
            this.sex = sex;
            this.breed = breed;
            Weight = weight;
            this.type = type;
            population++;
            Console.WriteLine($"A new pet has been born. You have {population} pets");
        }

        ~Pet()
        {
            population--;
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
            string type = this.type;
            if (type == "Dog")
            {
                type = "IMPOSTER";
            }

            return $"\n Pets' information:" +
                $"\n 1) Type: {type}" +
                $"\n 2) Name: {Name}" +
                $"\n 3) Sex: {sex}" +
                $"\n 4) Age: {GetAge()} years old" +
                $"\n 5) Weight: {Weight} kg" +
                $"\n 6) Breed: {breed}";
        }

    }
}
