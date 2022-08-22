// !Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Введите трехзначное число а я найду его вторую цифру");
int number= Convert.ToInt32(Console.ReadLine());
if ( number >=100 && number<=999)
{
    int ostatok = (number%100)/10;
    Console.WriteLine("вторая цифра = " + ostatok);
}
else
{
     Console.WriteLine ("Вы ввели не трехзначное число!!!");
}