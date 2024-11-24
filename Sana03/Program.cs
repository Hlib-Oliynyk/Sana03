using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

double[] arr = { -3.5, 3.1, -7.2, 4.2, -1.8, 3.6, -6.8 };
double sum_neg = 0;
double min = arr[0];
int maxi = 0;

for (int i = 0; i < arr.Length; i++)
{
    double num = arr[i];

    if (num < 0) sum_neg += num;
    if (num < min) min = num;
    if (num > arr[maxi]) maxi = i;
}

Console.WriteLine($"Сума від'ємних: {sum_neg}");
Console.WriteLine($"Мінімальний елемент: {min}");
Console.WriteLine($"Індекс максимального: {maxi}");