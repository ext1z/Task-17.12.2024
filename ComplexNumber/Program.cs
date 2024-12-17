

// Fail
// Formulasiga tushunish qiyin boldi

using System;

struct ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Метод сложения двух комплексных чисел
    public ComplexNumber Add(ComplexNumber other)  //  other = 4, 5
    {
        return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
        //Real = 2, Imagenary = 3
    }

    // Метод умножения двух комплексных чисел
    public ComplexNumber Multiply(ComplexNumber other)
    {
        double realPart = Real * other.Real - Imaginary * other.Imaginary;
        double imaginaryPart = Real * other.Imaginary + Imaginary * other.Real;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(2, 3);
        ComplexNumber c2 = new ComplexNumber(4, 5);

        ComplexNumber sum = c1.Add(c2);             // c1 2  3 = c2  4  5     2 + 4 =
        ComplexNumber product = c1.Multiply(c2);

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
    }
}

