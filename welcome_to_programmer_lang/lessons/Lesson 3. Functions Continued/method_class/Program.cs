//Method 1:
void Method1()
{
    Console.WriteLine("Я люблю Аньяната");
}
Method1();
















//Method 2:
void Method2(string text_002)
{
    Console.WriteLine(text_002);
}
Method2("А йа йа йа");

void Method2_1(int count, string text_002_1)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(text_002_1);
        i++;
    }
}
Method2_1(text_002_1: "А ой ой ой", count: 5);















//Method 3:

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);












// Method 4:
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string text_001 = Method4(6, " Ya lublu Anyanata ");
// Console.WriteLine(text_001);

string Method4(int count, string text)
{
    string result = String.Empty;

    for(int i=0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string text_001 = Method4(6, " Ya lublu Anyanata ");
Console.WriteLine(text_001);














