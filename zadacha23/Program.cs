// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
System.Console.WriteLine("Введите число до которого все числа необходимо возвести в куб :");
int num = int.Parse(Console.ReadLine());
int i = 0;

while (i <= num)
{
    Console.Write($"{Math.Pow(i, 3)} ");
    i++;
}


// почему-то не работает через for
// for (int i = 1; i<=num; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)} ");
// }

