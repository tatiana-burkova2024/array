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

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n. 


Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n:  ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);
Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");

int AckermannFunction(int m, int n)
{
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

Random random = new Random();

    int[] FillRandomArray(int size)
    {
        int[] arr = new int[size];
        FillArray(arr, size - 1); // Начинаем с последнего индекса
        return arr;
    }

    void FillArray(int[] arr, int index)
    {
        if (index < 0)
            return;

        arr[index] = random.Next(0, 1000);
        FillArray(arr, index - 1); // Рекурсивный вызов для следующего индекса
    }

    void PrintArrayReversed(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.Write(arr[index] + " ");
        PrintArrayReversed(arr, index - 1); // Рекурсивный вызов для предыдущего индекса
    }

 
        Console.WriteLine("Введите размерность одномерного массива: ");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] arr = FillRandomArray(length);

        Console.WriteLine("Массив (в обратном порядке):");
        PrintArrayReversed(arr, length - 1); // Начинаем с последнего индекса
    