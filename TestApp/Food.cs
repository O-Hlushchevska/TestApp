namespace TestApp
{
    public class Food
    {
        private float unitWeight;
        private int quantity;
        private double packageWeight;
        private char typeOfFood;
        private DateTime expirationDate;
        private double nutrition;

        public string Name { get; set; }

        public bool IsSpoiled => expirationDate > DateTime.Now;

        public Food(string name, float unitWeight, int quantity, char typeOfFood, double nutrition, DateTime expirationDate)
        {
            Name = name;
            this.unitWeight = unitWeight;
            this.quantity = quantity;
            packageWeight = Convert.ToDouble(quantity) * Convert.ToDouble(unitWeight);
            this.typeOfFood = typeOfFood;
            this.nutrition = nutrition;
            this.expirationDate = expirationDate;
        }

        public double DailyPortion(Pet eater)
        {
            double requiredFoodWeight = eater.Weight * nutrition;
            return requiredFoodWeight / Convert.ToDouble(unitWeight);
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