// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");
Console.WriteLine("Введите 2 для 2D пространства или 3 для 3D пространства");
int var = int.Parse(Console.ReadLine()!);
if (var == 2)
{
    Console.WriteLine("Выбрано пространство 2D");
    Console.WriteLine("Введите координаты первой точки пространства X1, Y1");
    Console.Write("X1 = ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Y1 = ");
    int y1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координаты втрой точки пространства X2, Y2");
    Console.Write("X2 = ");
    int x2 = int.Parse(Console.ReadLine()!);
    Console.Write("Y2 = ");
    int y2 = int.Parse(Console.ReadLine()!);
    double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    Console.WriteLine("Расстояние между заданными точками равно " + AB);
}
else if (var == 3)
{
    Console.WriteLine("Выбрано пространство 3D");
    Console.WriteLine("Введите координаты первой точки пространства X1, Y1, Z1");
    Console.Write("X1 = ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Y1 = ");
    int y1 = int.Parse(Console.ReadLine()!);
    Console.Write("Z1 = ");
    int z1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координаты втрой точки пространства X2, Y2, Z1");
    Console.Write("X2 = ");
    int x2 = int.Parse(Console.ReadLine()!);
    Console.Write("Y2 = ");
    int y2 = int.Parse(Console.ReadLine()!);
    Console.Write("Z1 = ");
    int z2 = int.Parse(Console.ReadLine()!);
    double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine("Расстояние между заданными точками равно " + AB);
}
else
{
    Console.WriteLine("Вы ввели цифру не соответствующую ни одному заданному пространству. Запустите программу заново.");
}