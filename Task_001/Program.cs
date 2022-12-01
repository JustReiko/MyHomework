Console.WriteLine("Введите первое число:");
string first = Console.ReadLine() ?? "";
int n = Convert.ToInt32(first);
Console.WriteLine("Введите второе число:");
string second = Console.ReadLine() ?? "";
int m = Convert.ToInt32(second);
if (n > m) {
    Console.WriteLine($"Большее число {n}");
}
else {
    Console.WriteLine($"Большее число {m}");

}