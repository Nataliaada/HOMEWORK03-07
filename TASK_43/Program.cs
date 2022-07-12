 
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите  значения    b1 и k1");
Console.Write("b1 =");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 =");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите  значения   b2 и k2");
Console.Write("b2 =");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 =");
double k2 = Convert.ToDouble(Console.ReadLine());

double [] TochkaPeresecheniya( double x1, double y1, double x2, double y2)
{
       
    double x = ( (x1-x2)/ (y2-y1) );
    double y = x * y1 + x1;
    return new[] {x, y};

}
void PrintArray(double[] arr)
{
 
    for (int i  = 0; i < arr.Length; i ++)
    {
    if (i == 0) Console.Write("[");
    if (i < arr.Length -1) Console.Write(arr[i] + ",");
    else Console.Write(arr[i]+"]");
    }   
}

double [] tochkaPeresecheniya = TochkaPeresecheniya(b1, k1, b2, k2);
PrintArray(tochkaPeresecheniya);
