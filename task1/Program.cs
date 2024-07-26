// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.



bool Proverka (int m, int n)
{
    if (n < m)
    {
        Console.WriteLine("Число M должно быть больше числа  N");
        return true;
    }
    return false;
}

void NaturalNumbersBetween(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine($" {m}");
        m = m + 1;
        NaturalNumbersBetween(m,n);
    }
}

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());
Proverka(m,n);
NaturalNumbersBetween(m,n);
