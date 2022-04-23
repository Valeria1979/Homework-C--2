//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int namber = int.Parse(Console.ReadLine());
Console.WriteLine(namber / 10 % 10);