string text = "Введите число (x) и мы покажем вам сумму всех чисел от 1 до x.";

int parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int number)
{
    int sum = 0;
    for(int i = 0; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int number = parse(text);
int sum = Sum(number);

Console.WriteLine($"Сумма всех чисел от 1 до x: {sum}");

