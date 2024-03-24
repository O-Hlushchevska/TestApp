namespace TestApp
{
    public class Food
    {
        public enum TypeOfFood
        {
            Pashtetik,
            Kormik,
            Smakolyk
        }


        public enum FoodSpeciality
        {
            Wet,
            Dry
        }

        private FoodSpeciality speciality;
        private TypeOfFood typeOfFood;
        private DateTime expirationDate;

        public bool IsSpoiled => expirationDate > DateTime.Now;

        public Food(TypeOfFood typeOfFood, FoodSpeciality speciality, DateTime expirationDate)
        {
            this.typeOfFood = typeOfFood;
            this.speciality = speciality;
            this.expirationDate = expirationDate;
        }

        public string GetExpirationDate()
        {
            if (IsSpoiled)
            {
                return "FOOD HAS EXPIRED!";
            }
            else
            {
                return expirationDate.ToShortDateString();
            }
        }
    }
}