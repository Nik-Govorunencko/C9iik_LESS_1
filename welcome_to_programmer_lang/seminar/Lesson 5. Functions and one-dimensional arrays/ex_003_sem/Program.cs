Console.WriteLine("Мы покажем вам массив из 123 случайных чисел (от 1 до 1000), и скажем сколько в нём чисел входящих в отрезок (10;99)");

int[] array = new int[123];

void Array_numbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1001);
    }
    Console.WriteLine(String.Join(" ", array));
}

Array_numbers(array);

void Count_numbers_inArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    Console.WriteLine($"В этом массиве вот столько чисел входящих в отрезок (10, 99): {count}");
}

Count_numbers_inArray(array);


// int[] array = new int[123];
// void FillArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(0, 124);
// }
// }
// FillArray(array);;
// int[] array2 = new int[80];
// void FillArray2(int[] array2)
// {
// int a = 10;
// for (int i = 0; i < array2.Length; i++)
// {
// array2[i] = a;
// a ++;
// }
// }
// int count = 0;
// FillArray2(array2);
// int metod(int[] array, int[] array2){
// for(int i = 0; i < 123; i++){
// for (int i2 = 0; i2 < 80; i2++){
// if(array[i] == array2[i2]){
// count++;
// }
// }
// }
// return count;
// }
// metod(array, array2);
// Console.WriteLine(count);