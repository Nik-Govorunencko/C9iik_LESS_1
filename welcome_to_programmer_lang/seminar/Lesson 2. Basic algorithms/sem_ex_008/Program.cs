Console.WriteLine("Введите два числа, и мы покажем является ли одно число квадратом другого.");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 * number1 == number2)
{
    Console.Write("Число {0} является квадратом числа {1}.", number1, number2);
}
else if(number2 * number2 == number1)
{
    Console.Write("Число {0} является квадратом числа {1}.", number2, number1);
}
else
{
    Console.Write("Ни одно число не является квадратом другого.");
}
// но также можно было просто использовать || - или