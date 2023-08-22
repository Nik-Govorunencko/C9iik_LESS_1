Console.WriteLine("Введите координаты двух точек (сначала x потом y). Мы покажем вам расстояние между ними (округлим до тысячных).");
int x_dot1 = Convert.ToInt32(Console.ReadLine());
int y_dot1 = Convert.ToInt32(Console.ReadLine());
int x_dot2 = Convert.ToInt32(Console.ReadLine());
int y_dot2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt((x_dot2 - x_dot1)*(x_dot2 - x_dot1)+(y_dot2 - y_dot1)*(y_dot2 - y_dot1)), 3);

Console.WriteLine(distance + " - расстояние между точками");
