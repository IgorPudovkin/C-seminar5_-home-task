// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
double[] startArray = GetArray(100, -5, -2);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница = {GetDifference(startArray)}");

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return res;
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    Console.WriteLine($"{min}, {max}");
    return max - min;
}

