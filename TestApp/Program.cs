using TestApp;

Pet cat1 = new Pet("Cat", "Mara", new DateTime(2016, 8, 25), "Female", "British", 5.54);
Pet cat2 = new Pet("Cat", "Mammi", new DateTime(2020, 7, 12), "Female", "British", 6.94);
Pet cat3 = new Pet("Cat", "Merly", new DateTime(2018, 11, 03), "Female", "British", 3.56);
Pet cat4 = new Pet("Cat", "Mira", new DateTime(2023, 8, 01), "Female", "British", 1.69);
Pet doggy = new Pet("Dog", "Eva", new DateTime(2015, 12, 09), "Female", "British", 50.54);

Console.WriteLine(cat1.GetInfo()+ "\n");
Console.WriteLine(cat2.GetInfo() + "\n");
Console.WriteLine(doggy.GetInfo() + "\n");
Console.WriteLine(cat3.GetInfo() + "\n");
Console.WriteLine(cat4.GetInfo() + "\n");