//Задача 1: Напишите программу, которая бесконечно запрашивает 
//целые числа с консоли. Программа завершается при вводе символа 
//‘q’ или при вводе числа, сумма цифр которого четная.

Console.WriteLine("Введите целые числа. Для завершения введите 'q'.");

        while (true)
       {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
        if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }
            int number;
            if (int.TryParse(input, out number))
            {
                if (IsEvenSum(number))
               {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }
            }
           else
            {
               Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
            }
        }

    static bool IsEvenSum(int number)
   {
        int sum = 0;
        while (number != 0)
       {
           sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
   }

//Задача 2: Задайте массив заполненный случайными трёхзначными
// числами. Напишите программу,которая покажет количество чётных
// чисел в массиве.
    
        // Создаем массив случайных трехзначных чисел
        int[] array = GenerateRandomArray(10); // Можно указать любой размер массива

        // Выводим массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Получаем количество чётных чисел в массиве
        int countEven = CountEvenNumbers(array);

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
    // Функция для генерации массива случайных трехзначных чисел
    static int[] GenerateRandomArray(int size)
    {
        Random rnd = new Random();
        int[] array = new int[size];
       for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(100, 1000); // Генерируем случайное трехзначное число
        }
        return array;
    }

    // Функция для подсчета количества чётных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int num in array)
       {
            if (num % 2 == 0) // Проверяем, является ли число чётным
            {
                count++;
            }
        }
        return count;
    }

     Функция для вывода массива на экран
   static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
       }
        Console.WriteLine();
    }

  //Задача 3: Напишите программу, которая перевернёт одномерный массив
 //(первый элемент станет последним, второй – предпоследним и т.д.)

 int[] array = {1,2,3,4,5};
 Console.WriteLine("Исходный массив: ");
 PrintArray(array);
 ReverseArray(array);
 Console.WriteLine("\nПеревёрнутый массив:");
 PrintArray(array);

    // Функция для переворачивания массива
    static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
    }

    // Функция для печати массива
    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine(); // Добавляем пустую строку для читаемости
    }