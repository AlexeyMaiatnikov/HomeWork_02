﻿/* 
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
using static System.Console;
Clear();
int number = new Random().Next(100, 1000);
WriteLine(number);
WriteLine(number % 100 / 10);