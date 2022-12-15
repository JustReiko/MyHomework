// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

/*
1. Задать массив;
2. Заполнить массив случайными вещественными числами;
3. Вывести массив на консоль;
4. Найти максимальный элемент массива;
4. Найти минимальный элемент массива;
4. Вычесть минимальный элемент из максимального;
5. Вывести результат вычитания на экран.
*/

// 1. Задать массив;
// 2. Заполнить массив случайными числами;
int [] InitArray ()
{
    int[] array = new int [10];
    Random rnd = new Random();

    for (int i = 0; i < 10; i++)
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

// 4. Найти максимальный элемент массива;
// 4. Найти минимальный элемент массива;

int MaxFinder (int [] array)
{
    int max = 0;
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];

    }
        
    return max;
}

int MinFinder (int [] array)
{
    int min = array[0];
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];

    }
        
    return min;
}

int Dif (int [] array)
{
    int dif = MaxFinder(array) - MinFinder(array);
    return dif;
}

int[] array = InitArray();
PrintArray(array);
int max = MaxFinder(array);
Console.WriteLine($"Максимальное число в массиве:{max}");
int min = MinFinder(array);
Console.WriteLine($"Минимальное число в массиве:{min}");
int dif = Dif(array);
Console.WriteLine($"Разница максимального и минимального числа в массиве:{dif}");