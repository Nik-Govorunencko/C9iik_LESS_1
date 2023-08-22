Random rand = new Random();
int number = rand.Next(10, 100);

int a = number / 10;
int b = number % 10;

if(a > b)
{
    Console.Write("Наибольшее число:" + a + ", наименьшее: " + b);
}
else if(b > a)
{
    Console.Write("Наибольшее число: {0}, наименьшее {1}", b, a);
}
else
{
    Console.Write($"Оба числа одинаковые: {a} = {b}");
}

