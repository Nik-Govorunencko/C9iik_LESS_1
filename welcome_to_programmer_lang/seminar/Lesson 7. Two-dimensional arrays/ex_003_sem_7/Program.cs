Console.WriteLine("Введите число m и n, после чего создасться массив из m строк и n столбцов. После этого вам покажет сумму всех элементов по главной диагонали");

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

void SumOfDiagonalNumbs(int[,] array)
{
    int sumOfNumbers = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j){
                sumOfNumbers += array[i, j];
            }
        }
    }
    Console.WriteLine($"Сумма всех чисел по главной диагонали равна: {sumOfNumbers}");
}

int[,] array = CreateArray();

int[,] filledArray = FillAndPrintArray(array);

SumOfDiagonalNumbs(filledArray);