Console.WriteLine("Введите число, и мы покажим все целые числа между ним и его противоположностью.");
int number_pl = Convert.ToInt32(Console.ReadLine());
int number = number_pl;
int number_min = number_pl * -1;
if(number_pl < 0)
{
    number_pl = number * -1;
}

int count_all = number_pl * 2;
int count = 0;



if(number_pl > 0)
{
    Console.Write(number_pl + ", ");
    while(count < count_all)
    {
        number_pl = number_pl - 1;
        count++;
        Console.Write(number_pl + ", ");
    }
}
else if(number_pl < 0)
{
    Console.Write(number_pl + ", ");
    while(count < count_all)
    {
        number_pl = number_pl + 1;
        count++;
        Console.Write(number_pl + ", ");
    }
}
else if (number_pl == 0)
{
    Console.WriteLine(0);
}