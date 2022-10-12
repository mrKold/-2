//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string n = Console.ReadLine();


while (n.Length <= 4 || n.Length >= 6)
{
    Console.WriteLine("Вы ошиблись! Введите ПЯТИЗНАЧНОЕ число!: ");
    n = Console.ReadLine();
}

if (n[0] == n[4] && n[1] == n[3])
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}
