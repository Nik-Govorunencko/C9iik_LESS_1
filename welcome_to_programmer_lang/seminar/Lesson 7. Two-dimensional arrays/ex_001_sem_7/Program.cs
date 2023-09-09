Console.WriteLine("Эта программа создаст двумерный массив m на n, и покажет каждый элемент в нём. Причём каждый элемент будет равняться его m + n.");

int[,] CreateArray()
{
    Console.WriteLine("Введите простое число, оно укажет количество строк в двумерном массиве");
    int numberOfLines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите простое число, оно укажет количество столбцов в двумерном массиве");
    int numberOfPillars = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[numberOfLines, numberOfPillars];
    return array;
}

int[,] array = CreateArray();

void FillAndPrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillAndPrintArray(array);