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
//task 2
class lab12
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть двозначне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Визначаємо першу і другу цифри числа
        int firstDigit = number / 10; // отримуємо цифру десятків шляхом ділення на 10
        int secondDigit = number % 10; // отримуємо цифру одиниць за допомогою операції взяття остачі від ділення на 10

        // Порівнюємо першу і другу цифри числа
        if (firstDigit > secondDigit)
        {
            Console.WriteLine("Перша цифра більша за другу.");
        }
        else if (firstDigit < secondDigit)
        {
            Console.WriteLine("Друга цифра більша за першу.");
        }
        else
        {
            Console.WriteLine("Обидві цифри рівні.");
        }
    }
}
