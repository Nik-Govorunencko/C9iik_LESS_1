Console.WriteLine("Вот массив из 8 эллементов, который состоит из нулей и единиц.");

void random_array()
{
    int[] array = new int[8];
    for(int i = 0; i <= 7; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}

random_array();
