// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int EvenNumberCounter(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
}

int sizeArray = Prompt("Введите размер массива: ");
for (int i = 0; i < 4; i++)
{
    int[] newArray = FillArray(sizeArray);
    PrintArray(newArray);
    Console.Write(" -> ");
    Console.WriteLine(EvenNumberCounter(newArray));
}