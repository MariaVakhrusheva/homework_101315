﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine($"Третья цифра числа {number} -> " + numberText[2]);
}
else 
{
  Console.WriteLine($"В числе *{number}* нет третьей цифры");
}
