Console.WriteLine("Введите число и мы покажем вам кратно ли оно 7 и 23.");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Это число является кратным 7 и 23.");
}
else
{
    Console.WriteLine("Это число не является кратным 7 и 23");
}
