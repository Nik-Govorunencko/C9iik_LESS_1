int number = new Random().Next(100, 1000);

int a = number / 100;
int b = number % 10;

Console.Write("Число: {0}{1}", a, b);

