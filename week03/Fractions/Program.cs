using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Test the Fraction class with different constructors
        Fraction fraction1 = new Fraction(); 
        Fraction fraction2 = new Fraction(5); 
        Fraction fraction3 = new Fraction(3, 4); 

        // Display the fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString()); 
        Console.WriteLine(fraction1.GetDecimalValue());   

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());  

        Console.WriteLine(fraction3.GetFractionString()); 
        Console.WriteLine(fraction3.GetDecimalValue());  

        // Test getters and setters
        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());   
    }
}