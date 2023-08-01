Console.WriteLine("Напишите два числа, и мы сравиним является ли первое квадратом второго.");
string numberstring1 = Console.ReadLine();
string numberstring2 = Console.ReadLine();
int number1 = Convert.ToInt32(numberstring1);
int number2 = Convert.ToInt32(numberstring2);
int numbermulti = number2 * number2;

if(numbermulti == number1)
{
    Console.WriteLine("Да, первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго.");
}
