using System;

class Program
{
    static void Main(string[] args)
    {
        // First constructor (1/1)
        Fraction fraction1 = new Fraction();

        // Second constructor (6/1)
        Fraction fraction2 = new Fraction(6);

        // Third constructor (6/7)
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine("Fractions created with constructors:");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine();

        // Test getters
        Console.WriteLine("Top: " + fraction3.GetTop());
        Console.WriteLine("Bottom: " + fraction3.GetBottom());

        Console.WriteLine();

        // Test setters
        fraction3.SetTop(3);
        fraction3.SetBottom(4);

        Console.WriteLine("After using setters:");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine("Decimal: " + fraction3.GetDecimalValue());

        Console.WriteLine();

        // This is the assignments examples
        Fraction one = new Fraction();
        Fraction five = new Fraction(5);
        Fraction threeFourths = new Fraction(3, 4);
        Fraction oneThird = new Fraction(1, 3);

        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());

        Console.WriteLine();

        Console.WriteLine(five.GetFractionString());
        Console.WriteLine(five.GetDecimalValue());

        Console.WriteLine();

        Console.WriteLine(threeFourths.GetFractionString());
        Console.WriteLine(threeFourths.GetDecimalValue());

        Console.WriteLine();

        Console.WriteLine(oneThird.GetFractionString());
        Console.WriteLine(oneThird.GetDecimalValue());
    }
}