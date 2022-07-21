
 // Задача 56. Задайте двумерный массив из целых чисел. Найдите 
//  В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int maxElement = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ", ");
            else Console.Write(arr[i, j] + "]");
        }
        Console.WriteLine();
    }

}

int[] GetStringSum(int[,] arr1)
{
    int[] result = new int[arr1.GetLength(0)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr1.GetLength(1); j++)
        {           
            sum += arr1[i, j];
           result[i] = sum;
         }
                         
    }
    
Console.Write($"Cумма цифр в  строках =  ");
    return result;
}

int LineMinSum(int[] arr)
{ 
    int minElement = arr[0];
        int minString = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        
        if (arr[i] < minElement)
        {
            minElement = arr[i];
                  minString = i;   
         }

           
}
     Console.WriteLine($" строкa {minString + 1} с наименьшей суммой  элементов в данной строке  = {minElement} ");
     return minString;
}



void PrintArray(int[] arr2)
{

    for (int i = 0; i < arr2.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr2.Length - 1) Console.Write(arr2[i] + ",  ");
        else Console.Write(arr2[i] + "]");
    }
}



int[,] matrix = CreateMatrixRndInt(num1, num2, minElement, maxElement);
PrintMatrix(matrix);
Console.WriteLine();
if (num1 != num2)
{
int[] getStringSum = GetStringSum(matrix);
PrintArray(getStringSum);
LineMinSum(getStringSum);
Console.WriteLine();


}
else Console.WriteLine("Это не прямоугольная матрица ");