// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the restocking tool.");
//coke starts here
int b = 100;
{
    Console.WriteLine("How many Cokes have been sold today? " + b + " are in stock.");
}
int a = int.Parse(Console.ReadLine());
int c = b - a;

if (c >= 0 && c <= b)
{
    Console.WriteLine("There are " + c + " Cokes left.");
}
else if (c < 0)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else if (c > 100)
{
    Console.WriteLine("You're supposed to sell the Cokes");
}
//Chips starts here
int e = 40;
{
    Console.WriteLine("How many Chips have been sold today? " + e + " are in stock.");
}
int d = int.Parse(Console.ReadLine());
int f = e - d;

if (f >= 0 && f <= e)
{
    Console.WriteLine("There are " + f + " Chips left.");
}
else if (f < 0)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else if (f > 40)
{
    Console.WriteLine("Where are you hiding these extra Chips");
}
//Candy starts here
int h = 60;
{ 
Console.WriteLine("How many Candies have been sold today? " + h + " are in stock.");
}
int g = int.Parse(Console.ReadLine());
int i = h - g;

if (i >= 0 && i <= 60)
{
    Console.WriteLine("There are " + i + " Candies left.");
}
else if (i < 0)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else if (i > 60)
{
    Console.WriteLine("I quit.");
}
//restock variables
int x = 40;
int y = 20;
int z = 40;
Console.WriteLine("Thank you for using the restocking tool. Here is what needs to be restocked.");

if (c <= x)
{
    Console.WriteLine("Coke will need to be restocked.");
}

if (f <= y)
{
    Console.WriteLine("Chips will need to be restocked.");
}

if (i <= z)
{
    Console.WriteLine("Candy will need to be restocked.");
}

if (c > 90 && f > 30 && i > 50)
{
    Console.WriteLine("Customers will need to be restocked.");
}