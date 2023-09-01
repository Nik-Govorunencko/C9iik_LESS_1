//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Эта программа создаёт массив из указанного вами количества элементов, которые будут случайными числами, а после этого создавать второй массив в который поэлементно перекачает первый.");

int[] Array_and_length()
{
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}

int[] array = Array_and_length();

void Second_array(int[] array)
{
    int[] second_array = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        second_array[i] = array[i];
    }
    Console.WriteLine(String.Join(" ", second_array) + " - это уже другой массив, который равен первому.");
}

Second_array(array);
