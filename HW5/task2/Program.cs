// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0, 3}", array[i]);
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int EvenIndexNumSum(int[] array)        //нечетные числа 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        {
            sum += array[i];
        }
    }
    return sum;
}

int sizeArray = Prompt("Введите размер массива: ");
for (int i = 0; i < 2; i++)
{
    int[] newArray = FillArray(sizeArray);
    PrintArray(newArray);
    Console.Write(" -> ");
    Console.WriteLine(EvenIndexNumSum(newArray));
}