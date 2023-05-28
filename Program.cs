// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// __________________Домашняя работа 10________________
// Console.WriteLine("Введите число");
// int a=Convert.ToInt32(Console.ReadLine());
// // // Задача 10: Напишите программу, которая принимает 
// // на вход трёхзначное число и на выходе показывает 
// // вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1
// int b = a/10;
// int c = b%10;
// Console.WriteLine($"two number={c}");

// __________________Домашняя работа 13________________
// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что
//  третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 1234 -> 3
// Console.WriteLine("Введите число");
// int a=Convert.ToInt32(Console.ReadLine());
// if (a / 100 < 1)
// {
//     Console.WriteLine("no thrid number");
// }
// else 
// {
//     int temp = a;
//     int k = 0;
//     while (temp > 0)
//     {
//         temp = temp/10;
//         k = k + 1;
//     }  
//     Console.WriteLine(k);
//     int b = a / Convert.ToInt32(Math.Pow(10,k-3));
//     int c = b % 10;
//     Console.WriteLine($"Третье число равно переменной {c}");
// }

// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// if (num == 6 || num == 7)
// {
//     Console.WriteLine("да");
// }
// else 
// {
//     Console.WriteLine("нет");
// }