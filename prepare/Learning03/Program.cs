using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstConstructor  = new Fraction();
        int numerator = firstConstructor.GetTop();
        int denominator = firstConstructor.GetBottom();
        // numerator = firstConstructor.SetTop(4);
        // denominator = firstConstructor.SetBottom(2);
        Console.WriteLine(firstConstructor.GetFractionString());
        Console.WriteLine(firstConstructor.GetDecimalValue());

        Fraction secondConstructor = new Fraction(5);
        int c2Numerator = secondConstructor.GetTop();
        int c2Denominator = secondConstructor.GetBottom();
        // c2Numerator = secondConstructor.SetTop(8);
        // c2Denominator = secondConstructor.SetBottom(4);
        Console.WriteLine(secondConstructor.GetFractionString());
        Console.WriteLine(secondConstructor.GetDecimalValue());

        Fraction thirdConstructor = new Fraction(1,3);
        int c3Numerator = thirdConstructor.GetTop();
        int c3Denominator = thirdConstructor.GetBottom();
        // c3Numerator = thirdConstructor.SetTop(6);
        // c3Denominator = thirdConstructor.SetBottom(2);
        Console.WriteLine(thirdConstructor.GetFractionString());
        Console.WriteLine(thirdConstructor.GetDecimalValue());


        
    }
}