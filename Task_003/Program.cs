Console.WriteLine("Введите первое число:");
string first = Console.ReadLine() ?? "";
int n = Convert.ToInt32(first);
if ((n % 2) == 0) {
    Console.WriteLine("Это четное число");
}
else {
    Console.WriteLine("Это нечетное число");
}