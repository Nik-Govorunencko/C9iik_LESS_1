Console.Write("Введите ваше имя:");
string username = Console.ReadLine();

if(username.ToLower() == "никита")
{
    Console.WriteLine("Ты опять выходишь на связь?");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}