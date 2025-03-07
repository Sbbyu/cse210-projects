using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int userScore = int.Parse(Console.ReadLine());
        
        string letter = "empty";

        if (userScore >= 90)
        {
            letter = "A";
           
        }

        else if (90 > userScore && userScore >= 80)
        {
            letter = "B";
           
        }  

        else if (80 > userScore && userScore >= 70)
        {
            letter = "C";
           
        }    

        else if (70 > userScore && userScore >= 60)
        {
            letter = "D";
            
        }  

        else if (userScore < 60)
        {
            letter = "F";
            
        }

        else
        {
            Console.WriteLine("Error");
        }

        Console.WriteLine($"Your grade is {letter}");

        if (userScore >= 70)
        {
            Console.WriteLine("Yay you passed!!!");
        }
        else
        {
            Console.WriteLine("You did not pass, You can try again!");
        }

    }
}