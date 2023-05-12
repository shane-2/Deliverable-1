using system;
{ 
    Console.WriteLine("Welcome to the restocking tool.");
    Console.WriteLine("How many Cokes have been sold today? 100 are in stock.");
}

    int a = int.Parse(Console.ReadLine());
    int b = 100;
    int c = b - a;
    if (c > 0 && c < 100)
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

    {
        Console.WriteLine("How many Chips have been sold today? 40 are in stock.");
    }

    int d = int.Parse(Console.ReadLine());
    int e = 40;
    int f = e - d;
    if (f > 0 && f < 40)
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

    Console.WriteLine("How many Candies have been sold today? 60 are in stock.");
    int g = int.Parse(Console.ReadLine());
    int h = 60;
    int i = h - g;
    if (i > 0 && i < 60)
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

    Console.WriteLine("Thank you for using the restocking tool. Here is what needs to be restocked.");
    if (c <= 40)
    {
        Console.WriteLine("Coke will need to be restocked.");
    }

    if (f <= 20)
    {
        Console.WriteLine("Chips will need to be restocked.");
    }

    if (i <= 40)
    {
        Console.WriteLine("Candy will need to be restocked.");
    }

    if (c > 90 && f > 30 && i > 50)
    {
        Console.WriteLine("Customers will need to be restocked.");
    }
