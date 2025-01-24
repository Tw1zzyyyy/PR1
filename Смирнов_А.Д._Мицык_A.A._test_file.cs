using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число b:");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Да, одно из чисел является делителем другого");
        }
        else
        {
            Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
        }
    }
}