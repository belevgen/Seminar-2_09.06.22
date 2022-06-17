// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Ведите трехзначное число: ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

if (paramInt < 100 || paramInt > 999) Console.WriteLine("Ввели неверное число");
else Console.Write("Вторая цифра числа - " + (paramInt % 100)/10);
