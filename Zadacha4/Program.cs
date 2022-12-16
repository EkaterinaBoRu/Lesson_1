// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 3: ");
int number_3 = int.Parse(Console.ReadLine()!);

if (number_1 >= number_2)
{
    if (number_1 >= number_3)
    {
        Console.WriteLine($"Наибольшее число: {number_1}");
    }
    else Console.WriteLine($"Наибольшее число: {number_3}");
}
else if (number_2 >= number_3)
    {
        Console.WriteLine($"Наибольшее число: {number_2}");
    }   
else Console.WriteLine($"Наибольшее число: {number_3}");

