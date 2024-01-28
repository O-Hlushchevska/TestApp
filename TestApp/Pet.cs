namespace TestApp
{
    public class Pet
    {
        private string name;
        private DateTime dateOfBirth;
        private string sex;
        private string breed;
        private double weight;

        public Pet() { }

        public Pet(string name, DateTime dateOfBirth, string sex, string breed, double weight)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.sex = sex;
            this.breed = breed;
            this.weight = weight;
        }

       public int GetAge() {

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


        public string GetInfo() {

            return ToString();

        }
    }
}
