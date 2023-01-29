// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int b = new Random().Next(3, 9);
int[] numbers = new int[b];
int ans = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int a = new Random().Next(100,1000);
    numbers[i] = a;
    Console.Write($"{numbers[i]}, ");
    if (numbers[i] % 2 == 0)
    {
        ans = ans + 1;
    }
    else
    {
        continue;
    } 
}
Console.WriteLine($"Количество четных чисел = {ans}"); 


// int target = 4;
// int[] numbers = {4, 7, 19, 15, 345};
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] != target){
//         continue;
//     }
//     else if (numbers[i] == target)
//     {
//         Console.WriteLine("Да");
//         break;
//     }
    
// }
// Console.WriteLine("Нет");




// int Count(int number)
// {
//     int count = 0;
//     if (number == 0)
//     {
//         count = 1;
//     }
//     else
//     {
//         while (number != 0)
//         {
//             number = number / 10;
//             count = count + 1;
//         }
//     }

//     return count;
// }



// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{A} -> {Count(A)}");