// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы


string GetListNums(int n, int m)
{
if (m > n)
{
    Console.Write($"{m} больше ");
    {return Convert.ToString(n);}
}
{
    if (m == n)
    {return Convert.ToString(m);}
    return m + " " + GetListNums(n,m+1);
}
}
Console.Write("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M < N:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Натуральные числа от M до N:");
Console.WriteLine(GetListNums(n, m));
