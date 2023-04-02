// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int Perestanovka(int num)
// {
//     int per1 = num / 10000;
//     int per2 = num / 1000 % 10;
//     int per3 = num / 100 % 10;
//     int per4 = num / 10 % 10;
//     int per5 = num % 10;

//     int result  = (per5 * 10000) + (per4 * 1000) + (per3 * 100) + (per2 * 10) + per1;
    
//     System.Console.WriteLine(result);
//     return result;
// }

// //Perestanovka(number);
// if (Perestanovka(number) == number) System.Console.WriteLine("данное число является полиндромом");
// else System.Console.WriteLine("данное число неявляется полиндромом");

Console.Clear();
System.Console.Write("Введите число: ");
string number = (Console.ReadLine());

char[] obrtext = number.ToCharArray();
Array.Reverse(obrtext);
string reversnubmber = new string(obrtext);
if(number == reversnubmber)
{
    System.Console.WriteLine("данное число является полиндромом");
}
else System.Console.WriteLine("данное число неявляется полиндромом");