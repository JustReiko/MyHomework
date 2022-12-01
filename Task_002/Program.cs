Console.WriteLine("Введите первое число:");
string first = Console.ReadLine() ?? "";
int n = Convert.ToInt32(first);
Console.WriteLine("Введите второе число:");
string second = Console.ReadLine() ?? "";
int m = Convert.ToInt32(second);
Console.WriteLine("Введите третье число:");
string third = Console.ReadLine() ?? "";
int o = Convert.ToInt32(third);
int max = 0;
if (n > max) {
    max = n;
}

if (o > max) {

    max = o;
}

if (m > max) {
    max = m;

}
Console.WriteLine($"Большее число {max}");