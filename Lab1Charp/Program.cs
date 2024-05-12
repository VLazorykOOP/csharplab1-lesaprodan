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
//task 3
namespace ConsoleApp 
{
    internal class lab13
    {
    
        private static void Main() 
        {
    
            Console.WriteLine("Введіть x");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть y");
            var y = Convert.ToInt32(Console.ReadLine());

            // Перевірка, чи точка знаходиться всередині області
            if (Math.Abs(x) <= y && x * x + y * y <= 15 * 15) 
            {
                // Перевірка, чи точка знаходиться на межі області
                if (Math.Abs(x) == y || x * x + y * y == 15 * 15) 
                {
                    Console.WriteLine("На межі");
                }
                else 
                {
                    Console.WriteLine("Так");
                }
            }
            else 
            {
                Console.WriteLine("Ні");
            }
    
            Console.ReadKey();
        }
    }
}
