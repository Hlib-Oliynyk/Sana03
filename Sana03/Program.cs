using System;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Кількість елементів в масиві: ");
int n = int.Parse(Console.ReadLine());

double[] arr = new double[n];
Console.WriteLine("Введіть елементи масиву:");
for (int i = 0; i < n; i++)
{
    Console.Write($"Елемент {i + 1}: ");
    arr[i] = double.Parse(Console.ReadLine());
}

double sumNeg = 0;
double min = arr[0];
int maxIndex = 0;
double maxAbs = Math.Abs(arr[0]);
int sumIndexes = 0;
int countInt = 0;

for (int i = 0; i < n; i++)
{
    if (arr[i] < 0) sumNeg += arr[i];
    if (arr[i] < min) min = arr[i];
    if (arr[i] > arr[maxIndex]) maxIndex = i;
    if (Math.Abs(arr[i]) > maxAbs) maxAbs = Math.Abs(arr[i]);
    if (arr[i] > 0) sumIndexes += i;
    if (arr[i] == Math.Floor(arr[i])) countInt++;
}

Console.WriteLine("\nРезультати:");
Console.WriteLine($"Сума від'ємних: {sumNeg}");
Console.WriteLine($"Мінімальний елемент: {min}");
Console.WriteLine($"Індекс максимального елемента: {maxIndex}");
Console.WriteLine($"Максимальний за модулем: {maxAbs}");
Console.WriteLine($"Сума індексів додатних: {sumIndexes}");
Console.WriteLine($"Кількість цілих чисел: {countInt}");
