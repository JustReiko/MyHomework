// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

/*
1. Задать массив;
2. Заполнить массив случайными числами;
3. Вывести массив на консоль;
3. Найти нечетные элементы массива;
4. Сложить нечетные элементы массива;
5. Вывести сумму нечетных элементов на экран.
*/

// 1. Задать массив;
// 2. Заполнить массив случайными числами;
int [] InitArray ()
{
    int[] array = new int [5];
    Random rnd = new Random();

    for (int i = 0; i < 5; i++)
    {
        array[i] = rnd.Next(1,999);
    }
    return array;
}

// 3. Вывести массив на консоль;
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");   
    }
    Console.WriteLine();
}

// 3. Найти нечетные элементы массива;
// 4. Сложить нечетные элементы массива;
int EvenNumberCount (int [] array)
{
    int evenCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
            evenCount = evenCount + array[i];
    }

    return evenCount;
}

// 5. Вывести сумму нечетных элементов на экран.
int[] array = InitArray();
PrintArray(array);
int evenNumbers = EvenNumberCount(array);

Console.WriteLine($"Сумма нечетных элементов в массиве:{evenNumbers}");