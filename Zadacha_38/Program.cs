// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

    double[] GenerateArray()
{
    double[] array = new double[5];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble()*100;
        System.Console.Write("{0,6:F2}\t", array[i]);
    }
    
    return array;
}

double SumPositive(double[] array)
{
    double sumMin = array[0];
    double sumMax = array[0];
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
    return Math.Round(sumMax - sumMin,2);
}

double[] myArray = GenerateArray();
System.Console.WriteLine();
System.Console.WriteLine($" разница между элементов массива: {SumPositive(myArray)}");
 
