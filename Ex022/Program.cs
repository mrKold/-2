﻿//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
    Console.WriteLine(i * i + " "); // Или (&"{i * i} ");
