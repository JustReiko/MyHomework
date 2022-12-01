Console.WriteLine("Введите число:");
string first = Console.ReadLine() ?? "";
int n = Convert.ToInt32(first);

for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }