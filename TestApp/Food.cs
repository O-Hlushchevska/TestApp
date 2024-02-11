namespace TestApp
{
    public class Food
    {
        private string name;
        private float unitWeight;
        private int quantity;
        private double packageWeight;
        private char typeOfFood;
        private dynamic expirationDate;
        private double nutrition;

        public string Name 
        { 
            get 
            { 
                return name; 
            } 
        }

        public Food(string name, float unitWeight, int quantity, char typeOfFood, double nutrition, DateTime expirationDate)
        {
            this.name = name;
            this.unitWeight = unitWeight;
            this.quantity = quantity;
            this.packageWeight = Convert.ToDouble(quantity) * Convert.ToDouble(unitWeight);
            this.typeOfFood = typeOfFood;
            this.nutrition = nutrition;
            if (expirationDate > DateTime.Now)
            {
                this.expirationDate = expirationDate;
            }
            else 
            {
                this.expirationDate = "FOOD HAS EXPIRED!";
            }
        }

        public double DailyPortion(Pet eater)
        {
           double requiredFoodWeight = eater.Weight * nutrition;
           return requiredFoodWeight / Convert.ToDouble(unitWeight);
        }
        public string GetExpirationDate()
        { 
            return expirationDate.ToString(); 
        }

    }
    
}
