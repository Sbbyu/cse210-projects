using System;

class Program
{
    static void Main(string[] args)
    {
        //Asks user for first name and stores it as a string varible
        Console.WriteLine("What is your first name? ");
        string firstname = Console.ReadLine();

        //Asks user for last name and stores it as a string varible
        Console.WriteLine("What is your last name? ");
        string lastname = Console.ReadLine();


        //prints the users name in a message
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");




    }
}