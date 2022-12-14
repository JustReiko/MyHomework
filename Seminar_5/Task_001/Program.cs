// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int [] InitArray ()
{
    int[] array = new int [10];
    Random rnd = new Random();

    for (int i = 0; i < 10; i++)
    {
        array[i] = rnd.Next (100, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");   
    }
    Console.WriteLine();
}

int EvenNumberCount (int [] array)
{
    int evenCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            evenCount += 1;
    }

    return evenCount;
}


int[] array = InitArray();
PrintArray(array);
int evenNumbers = EvenNumberCount(array);

Console.WriteLine($"Количество четных чисел в массиве:{evenNumbers}");