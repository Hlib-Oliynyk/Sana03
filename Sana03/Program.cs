using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

double[] arr = { -3.5, 3.1, -7.2, 4.2, -1.8, 3.6, -6.8 };
double sum_neg = 0;
double min = arr[0];
int maxi = 0;
double max_abs = Math.Abs(arr[0]);
int sum_index = 0;
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    double num = arr[i];

    if (num < 0) sum_neg += num;
    if (num < min) min = num;
    if (num > arr[maxi]) maxi = i;
    if (Math.Abs(num) > max_abs) max_abs = Math.Abs(num);
    if (num > 0) sum_index += i;
    if (num == Math.Floor(num)) count++;
}

Console.WriteLine($"Сума від'ємних: {sum_neg}");
Console.WriteLine($"Мінімальний елемент: {min}");
Console.WriteLine($"Індекс максимального: {maxi}");
Console.WriteLine($"Максимальний за модулем: {max_abs}");
Console.WriteLine($"Сума індексів додатних: {sum_index}");
Console.WriteLine($"Кількість цілих чисел: {count}");