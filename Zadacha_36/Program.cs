// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumNegative(int[] array)
{
    int result = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(i%2!=0)
        {
            result+=array[i];
        }
    }
    return result;
}

int[] myArray = GenerateArray(5, -10, 10);
PrintArray(myArray);

System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {SumNegative(myArray)}");
