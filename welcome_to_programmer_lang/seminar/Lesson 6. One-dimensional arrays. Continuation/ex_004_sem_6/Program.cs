// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число, и мы переведём его в двоичное!");

int number = Convert.ToInt32(Console.ReadLine());

void Convert_To_two(int number)
{
    string final_number = ("");
    while(number > 0)
    {
        if(number % 2 == 0)
        {
            final_number = ("0") + final_number;
        }
        else
        {
            final_number = ("1") + final_number;
        }
        number = number / 2;
    }
    Console.WriteLine($"{final_number} - это ваше число в двоичном виде.");
}

Convert_To_two(number);

// ГЕНИАЛЬНОЕ РЕШЕНИЕ!!!!!:::
// преобразование десятичного в двоичное

// Console.Write("Введите десятичное число: ");
// int decimalNumber = int.Parse(Console.ReadLine());
// string binaryString = string.Empty;
// while (decimalNumber > 0)
// {
//     int remainder = decimalNumber % 2;
//     decimalNumber /= 2;
//     binaryString = remainder.ToString() + binaryString;
// }
// Console.WriteLine($"Двоичное представление числа: {binaryString}");