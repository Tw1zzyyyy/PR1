using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод числа a
        Console.WriteLine("Введите число a:");
        int a = Convert.ToInt32(Console.ReadLine());

        // Запрашиваем у пользователя ввод числа b
        Console.WriteLine("Введите число b:");
        int b = Convert.ToInt32(Console.ReadLine());

        // Проверяем, является ли a делителем b или b делителем a
        if (a % b == 0 || b % a == 0)
        {
            // Если одно из чисел делит другое, выводим положительный ответ
            Console.WriteLine("Да, одно из чисел является делителем другого");
        }
        else
        {
            // Если ни одно из чисел не делит другое, выводим отрицательный ответ
            Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
        }
    }
}
