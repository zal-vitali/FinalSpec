//Найти индексы минимального и минимального элемента массива

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] FindMinMaxIndElem(int[] numbers)
{
    int[] result = GetArray(2, 0, 0);
    int indexMin = 0;
    int indexMax = 0;

    if (numbers.Length <= 1)
    {
        result[0] = indexMin;
        result[1] = indexMax;
    }
    else
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[indexMax]) indexMax = i;
            else if (numbers[i] < numbers[indexMin]) indexMin = i;
        }
    }

    result[0] = indexMin;
    result[1] = indexMax;

    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(", ", array));
}

Console.Clear();
Console.WriteLine("Для поиска индексов мин. и макс. элементов массива введите количество его размер:");
int qt = int.Parse(Console.ReadLine()!);

int[] array = GetArray(qt, -10, 10);
PrintArray(array);
PrintArray(FindMinMaxIndElem(array));

