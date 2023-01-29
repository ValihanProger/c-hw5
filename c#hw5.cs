// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int b = new Random().Next(3, 9);
int[] numbers = new int[b];
Console.Write("[ ");
for (int i = 0; i < numbers.Length; i++)
{
    int a = new Random().Next(100,1000);
    numbers[i] = a;
    Console.Write($"{numbers[i]} ");
}

int min = numbers.Min();
int max = numbers.Max();

Console.Write($"] -> {max-min}");
