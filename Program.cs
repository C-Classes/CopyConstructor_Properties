using System;

namespace Copy_Props
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            fraction1.Numerator = 10;
            fraction1.Denominator = 0;
            
            Fraction fraction2 = new Fraction(fraction1);

            Console.WriteLine(fraction2.Numerator + "/" + fraction2.Denominator);
        }
    }
}
