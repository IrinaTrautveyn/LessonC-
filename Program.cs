﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, a = 2 b = 10 -> max = 10, a = -9 b = -3 -> max = -3

// Определение входного числа 
 Console.Write ("Введите первое число: a = ");
 int a =int.Parse (Console.ReadLine());

 Console.Write ("Введите второе число: b = ");
 int b =int.Parse (Console.ReadLine());

 //Сравнение двух чисел и вывод максимального

if(a > b)
    Console.WriteLine($"max = {a}");
else 

if (b > a)
    Console.WriteLine($"max = {b}");
else
    Console.WriteLine($"Числа равны");
    
