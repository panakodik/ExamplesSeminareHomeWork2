// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("По двум заданным числам проверять является ли одно квадратом другого ");
Console.WriteLine("Введите первое число ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double numberB = Convert.ToDouble(Console.ReadLine());

if(numberB * numberB == numberA)
{
    Console.WriteLine($"Первое число *{numberA}* является квадратом второго числа *{numberB}*");
}
else
{
    Console.WriteLine($"Первое число *{numberA}* не является квадратом второго числа *{numberB}*");
}
if (numberA * numberA == numberB)
{
    Console.WriteLine($"Второе число *{numberB}* является квадратом первого числа *{numberA}*");
}
else
{
    Console.WriteLine($"Второе число *{numberB}* не является квадратом первого числа *{numberA}*");
}