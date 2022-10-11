
Console.Clear();
Console.WriteLine("Напиште коардинаты x1: ");
Console.WriteLine("Напиште коардинаты y1: ");

double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напиште коардинаты x2 ");
Console.WriteLine("Напиште коардинаты y2: ");

double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)), 2));
