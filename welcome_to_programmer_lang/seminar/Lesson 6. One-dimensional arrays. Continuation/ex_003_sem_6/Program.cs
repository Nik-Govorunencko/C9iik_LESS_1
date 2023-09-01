// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Напишите число, и мы покажем столько же чисел фибоначи, начиная с 0 и 1");

int[] Array_and_length()
{
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    return array;
}

int[] array = Array_and_length();

void Fibonacci(int[] array)
{
    array[1] = 1;
    int number_1 = 0;
    int number_2 = 1;
    for(int i = 2; i < array.Length; i++)
    {
        array[i] = array[number_1] + array[number_2];
        number_1++;
        number_2++;
    }
    Console.WriteLine(String.Join(" ", array));
}

Fibonacci(array);
