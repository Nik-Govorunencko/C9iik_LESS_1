Console.WriteLine("Введите число и мы покажем вам есть ли оно в случайном массиве.");
int[] array = new int[10];

void Random_array(int[] array)
{
    for(int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(String.Join(" ", array));
}

Random_array(array);

int number = Convert.ToInt32(Console.ReadLine());

void Number_in_array(int number, int[] array)
{
    string number_true = "Вашего числа нет в массиве!";
    for(int i = 0; i < 10; i++)
    {
        if(array[i] == number)
        {
            number_true = "Ваше число есть в массиве!";
        }
    }
    Console.WriteLine(number_true);
}

Number_in_array(number, array);


