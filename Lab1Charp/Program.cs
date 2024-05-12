using System;

class lab11
{
static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("Введіть довжину сторони трикутника (a):");
        double a = Convert.ToDouble(Console.ReadLine());

         Обчислення радіуса вписаного кола в рівносторонній трикутник
        double radius = (a / (2 * Math.Sqrt(3)));

        // Виведення результату
        Console.WriteLine($"Радіус вписаного кола: {radius}");
    }
}
