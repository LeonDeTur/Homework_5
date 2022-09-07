// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] result = CreateRandomArray();
PrintArray(result);
double res = FindDiff(result);

Console.WriteLine($"Разница наибольшего и наименьшего элементов массива: {res}");

// Методы

double[] CreateRandomArray ()
{
    Random rnd = new Random();
    int randomArrayLength = rnd.Next(1, 20);
    double[] randomArray = new double[randomArrayLength];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = rnd.Next(1, 10);
    }
    return randomArray;
}

double FindDiff (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max <= array[i])
        {
            max = array[i];
        }
        if (min >= array[i])
        {
            min = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

void PrintArray (double[] array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
