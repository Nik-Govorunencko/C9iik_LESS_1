Console.Write("Введите день недели (цифрой): ");
int data = Convert.ToInt32(Console.ReadLine());
if(data > 7)
{
    Console.WriteLine("вы дурачок");
}
if(data < 1)
{
    Console.WriteLine("Введите цифру от 1 до 7");
}
else
{
    if(data == 1)
    {
        Console.WriteLine("Вы указали понедельник");
    }
    else if(data == 2)
    {
        Console.WriteLine("Вы указали вторник");
    }
    else if(data == 3)
    {
        Console.WriteLine("Вы указали среду");
    }
    else if(data == 4)
    {
        Console.WriteLine("Вы указили четверг");
    }
    else if(data == 5)
    {
        Console.WriteLine("Вы указали пятницу");
    }
    else if(data == 6)
    {
        Console.WriteLine("Вы указали субботу");
    }
    else if(data == 7)
    {
        Console.WriteLine("Вы указали воскресенье");
    }
}
