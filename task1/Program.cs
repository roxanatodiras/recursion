// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNatural(int first, int last)
{
    if (first <= last)
    {
        PrintNatural(first, last -1);
        Console.Write($"{last} ");
    }

}

void PrintNatural2(int first, int last)
{
    if (first <= last)
    {
        Console.Write($"{first} ");        
        PrintNatural(first +1, last);
    }

}




Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
PrintNatural(n, m);
PrintNatural2(n, m);
