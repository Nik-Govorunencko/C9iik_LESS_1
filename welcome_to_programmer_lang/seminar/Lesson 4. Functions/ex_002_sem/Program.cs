string text = "Введите число (x) и мы покажем вам количество цифр в нём.";

int parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Count_numb(int number)
{
    int count = 0;
    if(number < 0)
    {
        number = number * -1;
    }
    if(number == 0)
    {
        count++;
    }
    else
    {
        while(number > 0)
        {
            number = number / 10;
            count++;
        } 
    }
    return count;
}

int number = parse(text);
int count = Count_numb(number);

Console.WriteLine($"Количество цифр в числе: {count}");
