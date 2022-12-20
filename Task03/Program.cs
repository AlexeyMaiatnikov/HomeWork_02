/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
using static System.Console;
Clear();
WriteLine("Введите число от 1 до 7: ");
int day_number = Convert.ToInt32(ReadLine());
if (day_number <= 7 && day_number >= 1)
{
    if (day_number >= 6)
    {
        WriteLine("Да");
    }
    if (day_number <= 5)
    {
        WriteLine("Нет");
    }
}
else
{
    WriteLine("Недопустимое число");
}