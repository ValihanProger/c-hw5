// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int b = new Random().Next(3, 9);
int[] numbers = new int[b];
int ans = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int a = new Random().Next(100,1000);
    numbers[i] = a;
    Console.Write($"{numbers[i]}, ");
    if (numbers[i] % 2 != 0)
    {
        ans = ans + numbers[i];
    }
    else
    {
        continue;
    } 
}
Console.WriteLine($"Сумма нечетных чисел = {ans}"); 

