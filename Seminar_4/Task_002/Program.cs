﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());

  int SumNum(int numN)
  {
    int counter = Convert.ToString(numN).Length;
    int adv = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      adv = numN - numN % 10;
      result = result + (numN - adv);
      numN = numN / 10;
    }
   return result;
  }
  
int sumNum = SumNum(numN);
Console.WriteLine("Сумма цифр в числе: " + sumNum);