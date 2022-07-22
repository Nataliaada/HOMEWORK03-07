// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    return ( m == 0) ? n + 1 : ( n == 0 ) ? Akkerman(m - 1, 1) : Akkerman(m - 1, Akkerman(m, n - 1));
}
int akkerman= Akkerman(num1, num2);
Console.WriteLine(akkerman);