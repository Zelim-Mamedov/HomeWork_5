// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArray(array);

double maxNumber = MaxNumber(array);
double minNumber = MinNumber(array);
double difference = Difference(maxNumber, minNumber);

Console.WriteLine($" -> {Math.Round(difference, 1, MidpointRounding.ToZero)}");
Console.WriteLine($"{maxNumber} - {minNumber}"); // Для проверки! Хотел посмотреть правильно ли получаю числа и разницу!

double Difference(double maxNumber, double minNumber)
{
    double difference = maxNumber - minNumber;
    return difference;
}

double MinNumber(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber )
        minNumber = arr[i];
    }
    return minNumber;
}

double MaxNumber(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber )
        maxNumber = arr[i];
    }
    return maxNumber;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)} | "); 
        }
        else Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)}]");
    }
}