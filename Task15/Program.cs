// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using static System.Console;
Clear();

WriteLine("Введите число дня недели: ");
int number = (Convert.ToInt32(ReadLine()));
if (number>7)
{
    WriteLine("В Земной неделе только 7 дней.");
    return;
}

if(number>=6)
{
    WriteLine ("Выходной.");
}

else
{
    WriteLine ("Рабочий день");
}

