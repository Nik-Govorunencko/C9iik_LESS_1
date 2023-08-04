int[] array = {23, 12, 54, 7, 2, 84, 2, 84, 82};

int find = 84;
int index = 0;

while(index < array.Length)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
