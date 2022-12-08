
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - это число Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - это число НЕ Палиндром");
    }
}
else
{
    Console.WriteLine($" {number}  - это не пятизначное число");
}


