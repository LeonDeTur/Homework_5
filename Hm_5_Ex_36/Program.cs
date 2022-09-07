// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] arrayFromFour = NewRandomArray(4);

PrintArray (arrayFromFour);
int output = CountSumOddI(arrayFromFour);

Console.WriteLine($"Сумма элементов на нечётных позициях: {output}");
// Методы

int[] NewRandomArray(int num)
{ 
    int [] array = new int[num];
    Random rand = new Random();
    int i = 0;
    while ( i < num)
    {
        array[i] = rand.Next(-2147483648, 2147483647);
        i++;
    }
    return array;
}

int CountSumOddI (int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

void PrintArray (int[] array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine(output);