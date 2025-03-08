using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got a D!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }


        Console.WriteLine($"Your grade is {grade}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }
}