using TestApp;

Pet cat1 = new Pet("Mara", new DateTime(2016, 8, 25), "Female", "British", 5.54);

Console.WriteLine($"Cat {cat1.GetName()} is {cat1.GetAge()} years old");
Console.WriteLine(cat1.GetInfo());