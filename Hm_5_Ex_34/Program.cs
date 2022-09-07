// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = CreateRandomArray();
Console.WriteLine("Массив:");
PrintArray(array);
int result = CheckArray(array);


// Методы

int[] CreateRandomArray ()
{
    Random rnd = new Random();
    int randomArrayLength = rnd.Next(1, 20);
    int [] randomArray = new int[randomArrayLength];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = rnd.Next(100, 1000);
    }
    return randomArray;
} 

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CheckArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        bool check = array[i] % 2 == 0;
        if (check == true)
        {
            count++;
        }
    }
    return count;
}


Console.Write($"Количество чётных числе в массиве: {result}");
