Console.WriteLine("Введите два числа и мы покажем является ли первое число кратным второму.");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 % number2 == 0)
{
    Console.Write("Первое число является кратным второму");
}
else
{
    Console.Write("Первое число не является кратным второму");
}
