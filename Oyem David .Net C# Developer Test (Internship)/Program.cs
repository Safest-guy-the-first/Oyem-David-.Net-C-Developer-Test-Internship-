//Task 1
using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

string name = "Joh Doe";
int age = 25;
bool isAdmin = true;
Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(isAdmin);

//Task 2
Console.Write("Enter a number: ");
int userInput = Convert.ToInt32(Console.ReadLine());  
if (userInput %2 == 0)
{
    Console.WriteLine("Even");
}
else { Console.WriteLine("Odd"); }

//Task 3
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//Task 4
int[] myArray = new int[5] {2,4,6,8,10};
foreach(int i in myArray)
{
    int sum = 0;
    sum = sum+i;
}

//Task 5
/*Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.
The method should print "Hello, !" to the console.
Call the Greet method from the Main method with the argument "Alice".
*/

void Greet(string name)
{ 
    Console.WriteLine($"Hello, {name}!");
}
Greet("Alice");