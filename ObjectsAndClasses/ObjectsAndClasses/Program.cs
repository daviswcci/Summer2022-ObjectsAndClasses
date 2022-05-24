// using statements
// imports classes and functionality from other documents in the project
using ObjectsAndClasses;

// Main Method
Console.WriteLine("Hello, World!");
int num = 15;
num++;
Console.WriteLine(num);

// this is where we provide specifics to our food.
// instance of the food class
// instantiation -> we CREATE food object
// instance is an example of a food objet
Food garfield = new Food();
Console.WriteLine(garfield.Name);


Console.WriteLine("What are you eating today?");
string input = Console.ReadLine();
Food davis = new Food(input, "salty", "soft", true, 7, 2, 200, new List<string>{"rice", "seaweed", "fish"});
Console.WriteLine(davis.Portions);
davis.Eat(2);
Console.WriteLine(davis.Portions);

Console.WriteLine(Food.DisplayMessage());
Console.WriteLine(davis.IsFoodTasty());
