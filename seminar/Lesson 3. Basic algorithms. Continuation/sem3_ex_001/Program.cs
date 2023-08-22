Console.WriteLine("Ведите координаты точки, y и x. Мы укажем в какой из 4 проскостей находиться данная точка. Не вводите 0!");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 || y == 0)
{
    Console.WriteLine("Не вводите нули!");
}
else if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находиться в первой плоскости!");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находиться в третьей плоскости!");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находиться в четвёртой плоскости!");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находиться во второй плоскости!");
}