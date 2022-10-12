Console.Clear();
Console.WriteLine("Введите колличество кустов от 3 до 1000: ");

int N = Convert.ToInt32(Console.ReadLine());
int[] a = Enumerable.Range(1, 1000).ToArray();

int result = 0;

while (N <= 2 || N > 1000)
{
    Console.WriteLine("Вы ошиблись! Введите колличество кустов от 3 до 1000: ");
    N = Convert.ToInt32(Console.ReadLine());
}

result = a[N-1] + a[N-3] + a[N - 2];
Console.WriteLine(result);

