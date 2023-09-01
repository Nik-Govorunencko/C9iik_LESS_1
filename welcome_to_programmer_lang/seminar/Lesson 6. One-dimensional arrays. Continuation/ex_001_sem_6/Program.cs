// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Напишите три числа, и мы покажем может ли существовать треугольник с такими сторонами (по длине(длина в сантиметрах!))");

int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());

void Proverka(int number_1, int number_2, int number_3)
{
    if(number_1 > number_2 + number_3 || number_2 > number_1 + number_3 || number_3 > number_1 + number_2)
    {
        Console.WriteLine("Треугольник с такими сторонами существовать не может!");
    }
    else
    {
        Console.WriteLine("Треугольник с такими сторонами существует!");
    }
}

Proverka(number_1, number_2, number_3);
