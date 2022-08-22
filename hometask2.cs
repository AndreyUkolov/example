using System;
// !Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.WriteLine ("Введите трехзначное число а я найду его вторую цифру");
// int number= Convert.ToInt32(Console.ReadLine());
// if ( number >=100 && number<=999)
// {
//     int ostatok = (number%100)/10;
//     Console.WriteLine("вторая цифра = " + ostatok);
// }
// else
// {
//      Console.WriteLine ("Вы ввели не трехзначное число!!!");
// }
//______________________________________________________________________________
//!Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите число а я найду его третью цифру");
int number= Convert.ToInt32(Console.ReadLine());
if (number>=100 || number<=-100)
{
    int pochti_otvet = (number % 1000)/100;
    int otvet = Math.Abs(pochti_otvet);
    Console.WriteLine("третья цифра = " + otvet);
}
else
{
    Console.WriteLine ("третьей цифры нет");
}