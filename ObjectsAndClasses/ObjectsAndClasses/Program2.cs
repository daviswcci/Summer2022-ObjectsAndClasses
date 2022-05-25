// using statements
// imports classes and functionality from other documents in the project
using ObjectsAndClasses;

// STRONGLY typed programming language

// type[] variableName = ...
//                 from 0 to 8
//                 0   to   length - 1   
string[] names = new string[9]; // creates an EMPTY array with 9 slots, can only hold strings (pieces of text)
// names[i] is ACCESSING the value at an index i

// variable has a name and a value, array items have INDEXES and values
//                                0   1   2  3 4 5
List<int> numbers = new List<int> { -47, 2, 3555, 4, 5, 6 }; // creates an list with items already in it, can only hold integers (whole numbers)
Console.WriteLine(numbers.Count);

// example with for loop and aray
// 99.9% of all for loops will look almost identical to this.
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(i);
    Console.WriteLine(names[i]); // this will print every item in the array 
}

numbers.RemoveAt(3); // removes the fourth item in our list

// example with a WHILE loop and a LIST
while (numbers.Count > 0)
{
    Console.WriteLine(numbers[0]); // prints the first item in the list
    numbers.RemoveAt(0); // removes the first item in the list
}
Console.WriteLine(numbers.Count);


string description = "This is cool!";
int age = 24;

// We cannot do these:
//description = 15;
//age = "Hello!";


string str = "string";
//"string" -> 's' 't' 'r' 'i' 'n' 'g'
//str.Length;
char c = str[0];