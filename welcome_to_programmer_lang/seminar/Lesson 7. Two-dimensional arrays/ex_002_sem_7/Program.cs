Console.WriteLine("Эта программа создаст двумерный массив m на n, и покажет каждый элемент в нём. Причём каждый элемент c двумя не чётными индексами будет возведён в квадрат.");

int[,] CreateArray()
{
    Console.Write("Введите простое число, оно укажет количество строк в двумерном массиве: ");
    int numberOfLines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите простое число, оно укажет количество столбцов в двумерном массиве: ");
    int numberOfPillars = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[numberOfLines, numberOfPillars];
    return array;
}

int[,] FillAndPrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 101);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void SquareOfNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 != 0 && j % 2 != 0){
                array[i, j] = array[i, j] * array[i, j];
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArray();

int[,] filledArray = FillAndPrintArray(array);

SquareOfNumbers(filledArray);