using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите периметр треугольника: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 3;
        double semiPerimeter = perimeter / 2;

        double area = Math.Sqrt(semiPerimeter * Math.Pow(semiPerimeter - side, 3));

        Console.WriteLine("\nСторона\t\tПлощадь");
        Console.WriteLine($"{side:F2}\t\t{area:F2}");
        Console.ReadLine();
    }
}
