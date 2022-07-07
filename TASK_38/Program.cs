
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = {3.2, 7.5, 22.0, 2.5, 78.3};

double FindMaxMin(double[] arr)

{
 double max = arr[0];
 double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
           
    }
    return max - min;
}


Console.WriteLine(FindMaxMin(array));