Console.WriteLine("Введите количество чисел в массиве, а потом мы покажем произведения последнего и первого числа, предпоследнего и второго и тд.");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

void Array_numbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    Console.WriteLine(String.Join(" ", array));
}

Array_numbers(array);

void Array_multi(int[] array)
{
    int number_multi = 0;
    int index_half = array.Length / 2;
    for(int i = 0; i < index_half; i++)
    {
        number_multi = array[array.Length - 1 - i] * array[i];
        Console.Write($"{number_multi} ");
    }
    if(array.Length % 2 != 0)
    {
        Console.Write(array[index_half]);
    }
}

Array_multi(array);