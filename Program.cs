

//sem 4


// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Stepen (int a, int b)
// {
//     int result = 1;
//     for (int num = 1; num <= b; num++)
//     {
//         result *= a;
//     }
// Console.WriteLine($"Число {a} в степени {b} = {result}");
// }

// Console.Write("Введите число A: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// Stepen (num_A, num_B);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigit(int N)
// {
//     if (N < 0) N = -N;

//     int SumDigit = 0;
//     int digit = 0;
//             // int count = 0;               // для определения разрядности чисоа
//     for (int num = N; num >= 1; num /= 10)
//     {
//             // count++;                     // реализация задачи по определению
//             // Console.WriteLine(count);    // разрядности числа через for
//         digit = num % 10;
//         SumDigit = SumDigit + digit;
//     }
//     return SumDigit;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Сумма цифр --> {SumDigit(number)}");


// Задача 29: Напишите программу, которая создает массив заданного пользователем размера,
// заполняет массив элементами от 1 до 99 и выводит их на экран.
// */
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int length)   // Метод - заполнение массива заданной длины
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)        // Метод - вывода массива на экран
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine("\b\b]");
// }

// Console.Write("Введите длину нового массива: ");
// int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
// // int[] NewArr = CreateArray(LenghtOfArray);
// // Console.Write("Создан массив и записан в переменную NewArr");
// // PrintArray(NewArr);       // Для проверки вывода через промежуточную переменную
// Console.Write("Создан новый массив ");
// PrintArray(CreateArray(LenghtOfArray));     // Для проверки вывода "слёту"












// SEM5

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// 

// int[] CreateArray(int length)   // Метод - заполнение массива заданной длины
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)        // Метод - вывода массива на экран
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine("\b\b]");
// }

// void CountEvenNumbers(int[] array)  // Счётчик чётных чисел
// {
//     int CountEvNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) CountEvNum++;
//     }
//     Console.WriteLine($"Чётных чисел в массиве -> {CountEvNum}");
// }

// Console.Write("Введите длину нового массива: ");
// int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(LenghtOfArray);
// PrintArray(array);
// CountEvenNumbers(array);

// 


// Задача 36: Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateArray(int length)   // Метод - заполнение массива заданной длины
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
void PrintArray(int[] array)        // Метод - вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}
void SumNumOnOddPositions (int [] array)
{
    int SumNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) SumNum += array[i];
    }
    Console.Write($"Сумма элементов на нечетных позициях = {SumNum}");
}
Console.Write("Введите длину нового массива: ");
int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(LenghtOfArray);
PrintArray(array);
SumNumOnOddPositions (array);
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateArray(int length)   // Метод - заполнение массива заданной длины
// {
//     double[] array = new double[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(-99, 100) + Math.Round(new Random().NextDouble(), 2);
//     }
//     return array;
// }
// void PrintArray(double[] array)        // Метод - вывода массива на экран
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine("\b]");
// }
// void DifferenceMaxMin(double[] array)   // Метод нахождения мин,макс и рассчёта (макс-мин)
// {
//     int max_i = 0;
//     int min_i = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > array[max_i]) max_i = i;
//         else
//         {
//             if (array[i] < array[min_i]) min_i = i;
//         }
//     }
//     Console.Write($"Max = {array[max_i]}  Min = {array[min_i]}. ");
//     Console.WriteLine($"Разница (Max - Min) = {Math.Round(array[max_i] - array[min_i], 2)}");
// }
// Console.Write("Введите длину нового массива: ");
// int LenghtOfArray = Convert.ToInt32(Console.ReadLine());
// double[] array = CreateArray(LenghtOfArray);
// PrintArray(array);
// DifferenceMaxMin(array);









//SEM 6

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 - тут в примере ошибка (реально 4)

// void PrintArray(int[] array)        // Метод - вывода массива на экран
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int CreateArrVarLengthPositiveNumber()
// {
//     int count = 1;
//     int[] arr = new int[count];
//     string stop = " Довольно";
//     int PositiveNumber = 0;
//     while (stop.ToLower() != "довольно")
//     {
//         Console.Write($"Укажи число: ");
//         arr[count - 1] = Convert.ToInt32(Console.ReadLine());
//         if (arr[count - 1] > 0) PositiveNumber++;
//         Console.Write($"Ты устал? {stop.ToUpper() + "?"} - ");
//         stop = Console.ReadLine();

//         if (stop.ToLower() != "довольно")
//         {
//             count++;
//             int[] temp = new int[count];
//             for (int i = 0; i < count - 1; i++)
//             {
//                 temp[i] = arr[i];
//             }
//             arr = temp;
//         }
//     }
//     Console.Write("Введен массив чисел -> ");
//     PrintArray(arr);
//     return PositiveNumber;
// }
// Console.WriteLine($"Положительных чисел в массиве всего: {CreateArrVarLengthPositiveNumber()}");


//  // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// void CrossPoint(double k1, double b1, double k2, double b2)
// {
//     double x = (b2 - b1) / (k1 - k2), y = k1 * x + b1; // y2 = k2 * x + b2; - для проверки
//     Console.WriteLine($"Координаты точки пересечения: x = {Math.Round(x, 2)}, y = {Math.Round(y, 2)}");
// }
// Console.Write("Внесите k1 - ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Внесите b1 - ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Внесите k2 - ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Внесите b2 - ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// while (k2 == k1)
// {
//     Console.WriteLine($"При равных k1, k2 линии не пересекаются! Введите разные коеффициенты");
//     Console.Write("Внесите новый k1 - ");
//     k1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Внесите новый k2 - ");
//     k2 = Convert.ToDouble(Console.ReadLine());
// }
// CrossPoint(k1, b1, k2, b2);
