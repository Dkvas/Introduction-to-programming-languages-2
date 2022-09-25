// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = (Convert.ToInt32(ReadLine()));
int a0 = number%10;
int a1 = number/10;
int a3 = number/100;

if (number/100<0)
{
    WriteLine ("Третье число отсутствует.");
}
else
{
    WriteLine (a3);
}
//int result = number-a3*100-a0;
//WriteLine ($"Число в середине {result/10}");