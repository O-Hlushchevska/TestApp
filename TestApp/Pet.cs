namespace TestApp
{
    public class Pet
    {
        private string name;
        private DateTime dateOfBirth;
        private string sex;
        private string breed;
        private double weight;
        private string type;

        public Pet(string type, string name, DateTime dateOfBirth, string sex, string breed, double weight)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.sex = sex;
            this.breed = breed;
            this.weight = weight;
            this.type = type;
        }

        public Pet(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
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

        public string GetName()
        {
            return name;
        }

        public string GetType()
        {
            return type;
        }

        public string GetSex()
        {
            return sex;
        }

        public double GetWeight()
        {
            return weight;
        }

        public string GetBreed()
        {
            return breed;
        }

        public string GetInfo()
        {
            string type = GetType();
            if (type == "Dog")
            {
                type = "IMPOSTER";
            }

            return $"Pets' information:" +
                $"\n 1) Type: {type}" +
                $"\n 2) Name: {name}" +
                $"\n 3) Sex: {GetSex()}" +
                $"\n 4) Age: {GetAge()} years old" +
                $"\n 5) Weight: {GetWeight()} kg" +
                $"\n 6) Breed: {breed}";
        }

    }
}
