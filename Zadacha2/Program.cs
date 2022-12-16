// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine()!);

if (number_1 > number_2)
{
    Console.WriteLine($"Большее число: {number_1}, меньшее число: {number_2}");
}
else if (number_2 > number_1)
{
    Console.WriteLine($"Большее число: {number_2}, меньшее число: {number_1}");
}
else Console.WriteLine($"Числа равны");