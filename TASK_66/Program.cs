
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.WriteLine("Введите число M: ");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = int.Parse(Console.ReadLine());
SumNaturalNumber(numM, numN);

int SumNaturalNumber(int m, int n)
{
    if (m < n)
    {
        return m + SumNaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        return n + SumNaturalNumber(m, n + 1);
    }
    
    if (n == m) return n;

    return m;
}
int result = SumNaturalNumber(numM, numN);
Console.WriteLine($"Сумма ровна = {result}");