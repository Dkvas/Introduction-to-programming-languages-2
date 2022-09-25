// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using static System.Console;
Clear();

WriteLine("Введите трёхзначное число: ");
int number = (Convert.ToInt32(ReadLine()));
int a0 = number%10;
int a1 = number/10;
int a3 = number/100;

int result = number-a3*100-a0;
WriteLine ($"Число в середине {result/10}");