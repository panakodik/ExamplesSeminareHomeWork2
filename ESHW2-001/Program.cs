﻿// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели ");
int day = int.Parse(Console.ReadLine());

if(day == 1) 
{
    Console.WriteLine("Понедельник");
}
else if(day == 2) 
{
    Console.WriteLine("Вторник");
}
else if(day == 3) 
{
    Console.WriteLine("Среда");
}
else if(day == 4) 
{
    Console.WriteLine("Четверг");
}
else if(day == 5) 
{
    Console.WriteLine("Пятница");
}
else if(day == 6) 
{
    Console.WriteLine("Суббота");
    //Console.WriteLine("Выходной день");
}
else if(day == 7) 
{
    Console.WriteLine("Воскресенье");
    //Console.WriteLine("Выходной день");
}
else Console.WriteLine("Такого дня недели не существует");
if (day > 5 && day < 8)
{
    Console.WriteLine("Выходной день");
}