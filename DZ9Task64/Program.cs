﻿//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
