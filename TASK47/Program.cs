
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент: ");
// double minElement = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент: ");
// double maxElement = Convert.ToDouble(Console.ReadLine());


double[,] CreateMatrixRnddouble(int n, int m)
{
    double[,] array = new double[n, m];
    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            array[i, j] = Convert.ToDouble(random.Next(-100, 100))/10;
        }
    }
    return array;
}

void PrintdoubleArray(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ",  ");
            else Console.Write(arr[i, j] + "]");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrixRnddouble(num1, num2);
PrintdoubleArray(matrix);