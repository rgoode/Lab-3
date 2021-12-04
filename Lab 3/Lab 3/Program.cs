// See https://aka.ms/new-console-template for more information

using System;

       
           
            
            Console.WriteLine("Hello friend, What is your name?");
            string summonBy = Console.ReadLine();
            string insert_again;

do
{
    Console.WriteLine($"{summonBy} Please provide a number between 1 and 100.");
    string number = Console.ReadLine();
    int i = int.Parse(number);


    if (i <= 0 || i > 100)
    {
        Console.WriteLine($"Hey {summonBy}, stay within the range!");
    }

    else if (i % 2 != 0)
    {

        if (i > 60)
        {
            Console.WriteLine($"{summonBy} {i} is odd (and greater than 60).");
        }
        else
        {
            Console.WriteLine($"{summonBy} {i} is an odd number.");
        }

    }

    else if (i % 2 == 0)
    {
        if (i < 25)
        {
            Console.WriteLine($"{summonBy} {i} is an even number and less than 25.");
        }

        else if (i >= 26 && i <= 60)
        {
            Console.WriteLine($"{summonBy} {i} is even (between 26 and 60).");
        }

        else if (i > 60)
        {
            Console.WriteLine($"{summonBy} {i} is even (and greater than 60).");
        }

    }
    Console.WriteLine($"{summonBy} Would you like to continue?");
    insert_again = Console.ReadLine();

} while (insert_again == "y");


Console.WriteLine("Have a nice day, friend!");






























