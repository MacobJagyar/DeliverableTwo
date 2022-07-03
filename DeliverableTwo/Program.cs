 Console.WriteLine("Hi. Welcome to our Buffet." + 
    " All you can eat for $9.99! We only charge extra for coffee.");
Console.WriteLine();
Console.WriteLine("How many people are in your group? Please, parties of 6 or lower.");

int input = int.Parse(Console.ReadLine());

if (input > 6)
{
    Console.WriteLine("\nOh sorry, can only seat parties up to 6. Have a nice day.");
}

while (input < 7)
{
    Console.WriteLine("\nA table for " + input + "! Please follow me and take a seat.");
    Console.WriteLine("\nLet's get everyone started with some drinks. We've got water or coffee.");

    string choices = " ";
    int coffee = 0;
    int water = 0;

    for (int i = 1; i <= input; i++)
    {
        Console.WriteLine("\nAlright person " + i + ", water or coffee?");
        choices = Console.ReadLine();
        string lower = choices.ToLower();
        if (lower == "coffee")
        {
            Console.WriteLine("Coffee, okay!");
            coffee++;
        }
        else if (lower == "water")
        {
            Console.WriteLine("Water, okay!");
            water++;
        }
        else
        {
            Console.WriteLine("We don't have that drink, sorry! We'll give you water!");
            water++;
        }
    }

    Console.WriteLine("\nAlright, so that's " + coffee + " coffees and " + water + " waters!" +
        " I'll be right back. Feel free to grab your food!");

    double peopleTotal = input * 9.99;
    double coffeeTotal = coffee * 2;
    double total = peopleTotal + coffeeTotal;

    Console.WriteLine("\nHere's your bill! Total price: " + total);

    Console.WriteLine("\n\nBill breakdown - ");
    Console.WriteLine(input + " buffets = " + input + " x 9.99 = " + peopleTotal);
    Console.WriteLine(coffee + " coffees = " + coffee + " x 2.00 = " + coffeeTotal);
    Console.WriteLine(water + " waters = free");
    Console.WriteLine("Total = " + total);
    break;
} 

Console.ReadKey();
