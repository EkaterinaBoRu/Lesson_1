// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;

if (number > 1)
{
        while (count<= number)
    {
        if (count%2 == 0)
        {
            Console.WriteLine(count);
            count = count + 1;
        }
        else count = count + 1;
    }
}
else if (number ==1)
{
    Console.WriteLine($"Нет четных чисел");
}
else Console.WriteLine($"Число не является натуральным");


