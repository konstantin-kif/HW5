// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        if (new Random().Next(0, 2) == 0)       // или целое или дробное
        {
            array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 100), 1);
        }
        else
        {
            array[i] = new Random().Next(0, 100);
        }
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0, 4}", array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

double FindMin(double[] array)
{
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
        }

    }
    return minNum;
}

double FindMax(double[] array)
{

    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

double DifferenceMinMax(double[] array)
{
    return FindMax(array) - FindMin(array);
}

int sizeArray = Prompt("Введите размер массива: ");
{
    double[] newArray = FillArray(sizeArray);
    PrintArray(newArray);
    Console.Write(" -> ");
    Console.WriteLine($"{DifferenceMinMax(newArray)}");
}