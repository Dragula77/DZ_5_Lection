// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int SumPositive(int[] array)
{
    int sumMin = array[0];
    int sumMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>sumMax)
        {
            sumMax = array[i];
        }
        if (array[i]<sumMin)
        {
            sumMin = array[i];
        }
    }
    return sumMax - sumMin;
}

int[] myArray = GenerateArray(5, 1, 100);
PrintArray(myArray);

System.Console.WriteLine($"разница между максимальным и минимальным элементов массива:  {SumPositive(myArray)}");
