/* 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
using static System.Console;
Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
//int b = number;
if (number < 100)
{
    WriteLine("Третьей цифры нет ");
};
if (number >= 100 & number <= 999)
{
    Write($"{number % 10}");
};
while (number >= 1000)
{
    number = number / 10;
    if (number < 1000)
    {
        WriteLine($"{number % 10}");
    };

}
