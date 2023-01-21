// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти от 1 до 4 ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Диапазоны возможных координат: X > 0, Y > 0");
}
else if(number == 2)
{
    Console.WriteLine("Диапазоны возможных координат: X < 0, Y > 0");
}
else if(number == 3)
{
    Console.WriteLine("Диапазоны возможных координат: X < 0, Y < 0");
}
else if(number == 4)
{
    Console.WriteLine("Диапазоны возможных координат: X > 0, Y < 0");
}
else
{
    Console.WriteLine("Введеное число не соответствует ни одной из четвертей");
}