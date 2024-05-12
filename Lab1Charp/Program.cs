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
// task 4
using System;

namespace ConsoleApp 
{
    internal class lab14 
    {
        private static void Main() 
        {
    
            Console.WriteLine("Введіть кількість пройдених місяців з 1 січня 1990 року:");
            int m = Convert.ToInt32(Console.ReadLine());

            // Визначення поточного місяця
            int currentMonth = (m + 1) % 12; // Починаємо з січня 1990 року, тому додаємо 1
            string monthName = GetMonthName(currentMonth);

            // Виведення результату
            Console.WriteLine($"Поточний місяць: {monthName}");

            Console.ReadKey();
        }

        // Метод для отримання назви місяця за його номером
        private static string GetMonthName(int monthNumber) 
        {
            switch (monthNumber) 
            {
                case 1:  return "Січень";
                case 2:  return "Лютий";
                case 3:  return "Березень";
                case 4:  return "Квітень";
                case 5:  return "Травень";
                case 6:  return "Червень";
                case 7:  return "Липень";
                case 8:  return "Серпень";
                case 9:  return "Вересень";
                case 10: return "Жовтень";
                case 11: return "Листопад";
                case 12: return "Грудень";
                default: return "Невідомий"; 
            }
        }
    }
}
