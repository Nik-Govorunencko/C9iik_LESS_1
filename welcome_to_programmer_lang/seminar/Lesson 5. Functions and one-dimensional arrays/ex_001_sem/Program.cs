Console.WriteLine("Мы покажем вам массив с рандомными числами от -10 до 10, и покажем вам его же с противоположными числами (в нём будет 10 чисел)");

int[] array = new int[10];

void Array_numbers(int[] array)
{
    for(int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine(String.Join(" ", array));
}

Array_numbers(array);


void Array_numbers_revers(int[] array)
{
    for(int i = 0; i < 10; i++)
    {
        array[i] = array[i] * -1;
    }
    Console.WriteLine(String.Join(" ", array));
}

Array_numbers_revers(array);