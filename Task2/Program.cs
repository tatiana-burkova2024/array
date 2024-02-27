//int[] arr = new int[5];
//arr[0] = 5;
//arr[1] = 7;
//arr[2] = 5;
//arr[3] = 4;
//arr[4] = 3;
//Console.WriteLine(arr[0]);
//Console.WriteLine(arr[1]);
//Console.WriteLine(arr[2]);
//Console.WriteLine(arr[3]);
//Console.WriteLine(arr[4]);
//требуется заполнить массив целыми числами от 1 до N, 
//где N – некоторое натуральное число и вывести его на экран.
//int N = 10;
//int[] arr = new int[N];
//int i = 0;
//while (i < N)
//{
 //arr[i] = i + 1;
 //Console.Write($"{arr[i]} "); 
// i = i + 1;  
//}
//Пусть дан массив на некоторое количество целых чисел, например, 
//10 штук.Требуется найти в массиве четные числа и вывести их на экран
int N = 10;
int [] array = {2,5,4,7,8,35,1,3,8,5};
int i = 0;
while (i < N)
{
    if (array[i] % 2 == 0)
    {
       Console.Write($"{array[i]} ");
    }
    i = i + 1;
}