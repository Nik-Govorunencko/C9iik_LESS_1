Console.WriteLine("Введите трёхзначное число, и мы покажем вам еденицы этого числа");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0)
{
    number = number * -1;
}

if(number < 1000)
{
    if(number > 99)
    {
        number = number % 10;
        Console.WriteLine(number + " - еденицы");
    }
    else
    {
        Console.WriteLine("Укажите трехзначное число!");
    }
}
else
{
    Console.WriteLine("Укажите трехзначное число!");
}


