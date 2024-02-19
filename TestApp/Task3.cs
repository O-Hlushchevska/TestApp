using System.Collections;
using TestApp;

Pet cat1 = new Pet("Cat", "Mara", DateTime.Parse("25/08/2016"), "Female", "British", 5.54);
Pet cat2 = new Pet("Cat", "Mammi", DateTime.Parse("12/07/2020"), "Female", "British", 6.94);
Pet cat3 = new Pet("Cat", "Merly", DateTime.Parse("11/03/2018"), "Female", "British", 3.56);
Pet cat4 = new Pet("Cat", "Mira", DateTime.Parse("01/08/2023"), "Female", "British", 1.69);
Pet doggy = new Pet("Dog", "Eva", DateTime.Parse("09/12/2015"), "Female", "British", 50.54);

var food1 = new Food("Pashtetik", 0.2f, 22, 'W', 0.02, new DateTime (2024, 12, 12));
var food2 = new Food("Kormik", 1.24f, 1, 'D', 0.03, new DateTime(2026, 1, 1));
var food3 = new Food("Smakolyk", 0.0632f, 11, 'W', 0.01, new DateTime (2024, 02, 10));

void CatKilling()
{
    Pet cat5 = new Pet("Cat", "deadpet1", new DateTime(1980, 8, 25), "Female", "British", 5.54);
}

CatKilling(); 
GC.Collect();

Console.WriteLine($"{cat1.GetInfo()}");
//Console.WriteLine($"{cat2.GetInfo()}");
Console.WriteLine($"{doggy.GetInfo()}");
//Console.WriteLine($"{cat3.GetInfo()}");
//Console.WriteLine($"{cat4.GetInfo()}");

//int number = 34;
//object boxedNumber = number;
//number = 45;
//boxedNumber = 20;
//number = (int) boxedNumber;
//number = 0;

void WriteFoodInfo(Pet pet, Food food1, Food food2, Food food3)
{
    Console.WriteLine($"\nDaily food portion for {pet.Name} \n\t   is {food1.DailyPortion(pet):f3} grams of {food1.Name}. Expiration date: {food1.GetExpirationDate()}");
    Console.WriteLine($"\tor is {food2.DailyPortion(pet):f3} grams of {food2.Name}. Expiration date: {food2.GetExpirationDate()}");
    Console.WriteLine($"\tor is {food3.DailyPortion(pet):f3} grams of {food3.Name}. Expiration date: {food3.GetExpirationDate()}");
}

WriteFoodInfo(cat1, food1, food2, food3);
//WriteFoodInfo(cat2, food1, food2, food3);
//WriteFoodInfo(cat3, food1, food2, food3);  
//WriteFoodInfo(cat4, food1, food2, food3);

double[] weightArray = [cat1.Weight, cat2.Weight, cat3.Weight, cat4.Weight];
Console.WriteLine($"\nThe total weigh of all pets is {weightArray.Sum()} kg");

Pet[] petsArray = [cat1, cat2, cat3, cat4];
var orderedByAge = petsArray.OrderByDescending(pet => pet.GetAge()).ToList();
Pet? maxWeight = petsArray.MaxBy(pet => pet.Weight);
Console.WriteLine($"\n The list of the pets order by age: {string.Join(" ",  orderedByAge)}");
orderedByAge.Reverse();
Console.WriteLine($"\n The list of the pets reverse order by age: {string.Join(" ",  orderedByAge)}");
Console.WriteLine($"\nThe heaviest pet is {maxWeight.Name}. Her weight is {maxWeight.Weight} kg\n");

List<Pet> pets = orderedByAge.ToList();
Console.WriteLine(string.Join(", ", pets));
pets.Add(doggy);
Console.WriteLine(string.Join(", ", pets));

pets.Remove(pets[3]);
pets.Remove(pets[0]);
pets.Remove(pets[2]);
Console.WriteLine(string.Join(", ", pets));
pets.Add(doggy);

var petsFind = pets.Find(pet => pet.Name.Contains("Mammi"));
Console.WriteLine(string.Join(", ", petsFind));

if (pets.Contains(doggy)) 
{
    Console.WriteLine("There is a doggy"); 
}
else
{
    Console.WriteLine("There is no doggy");
}


pets.Remove(doggy);
if (pets.Contains(doggy))
{
    Console.WriteLine("There is a doggy");
}
else
{
    Console.WriteLine("There is no doggy");
}

pets.Add(cat4);
pets[2] = doggy;
Console.WriteLine(string.Join(", ", pets));

pets.Clear();
Console.WriteLine(string.Join(", ", pets));