// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число:");
string first = Console.ReadLine() ?? "";
int n = Convert.ToInt32(first);
string stringNumber = Convert.ToString(n);
Console.WriteLine("Вторая цифра данного числа -> "+stringNumber[1]);
