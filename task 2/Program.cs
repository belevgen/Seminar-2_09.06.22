// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine("Ведите случайное трехзначное число: " + number);

int result = (number/100)*10+number%10;

Console.WriteLine("Число без второй цифры: " + result);  
