// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 10);
        Console.Write($"{col[i]} ");
    }
    return col;
}


void ReverseArray(int[] col, int i)
{
    if (i < 0) return;
    Console.Write($"{col[i]} ");
    ReverseArray(col, i - 1);
}

Console.WriteLine("Введите величину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int[] mass = RandomMas(array);
Console.WriteLine();
ReverseArray(mass, mass.Length - 1);




