Console.WriteLine("Введите номер четверти (от 1 до 4) и мы покажем вам возможные координаты точек в этой четвирти.");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 4 || number < 1)
{
    Console.WriteLine("Введите цифру от 1 до 4!");
}
else if(number == 1)
{
    Console.WriteLine("Это первая четверть. Возможные координаты: x > 0, y > 0");
}
else if(number == 3)
{
    Console.WriteLine("Это третья четверть. Возможные координаты: x < 0, y < 0");
}
else if(number == 2)
{
    Console.WriteLine("Это вторая четверть. Возможные координаты: x < 0, y > 0");
}
else
{
    Console.WriteLine("Это четвёртая четверть. Возможные координаты: x > 0, y < 0");
}