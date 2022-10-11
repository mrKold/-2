/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта 
точка*/

Console.Clear();
Console.WriteLine("Напиште коардинаты x: ");
Console.WriteLine("Напиште коардинаты y: ");

double x = Convert.ToInt32(Console.ReadLine());
double y = Convert.ToInt32(Console.ReadLine());

while (x == 0)
{
    Console.Write("Напиште коардинаты x: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.Write("Напиште коардинаты y: ");
    y = Convert.ToDouble(Console.ReadLine());
}

if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");