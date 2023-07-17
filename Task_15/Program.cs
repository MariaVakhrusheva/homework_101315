/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Задача №15 ");

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 8)
{
    if(number > 5 && number < 8)
    {
        Console.WriteLine(number + " -> выходной день");
    }
    else
    {
        Console.WriteLine(number + " -> не выходной день");
    }
}

else
{
    Console.WriteLine("Это вообще не день недели..");
}