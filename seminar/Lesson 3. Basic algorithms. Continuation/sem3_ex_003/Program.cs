Console.WriteLine("Введите число, и мы покажем его квадрат, а так же все квадраты чисел до него.");
int number = Convert.ToInt32(Console.ReadLine());
int number_multi = 0;

for (int i = 1; i <= number; i++)
{
    number_multi = i * i;
    Console.Write(number_multi + " ");
}
