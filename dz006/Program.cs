﻿// Принять на вход число и выдать является ли оно четным или нечетным

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
    
if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}