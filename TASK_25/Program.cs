
// Задача 25: Напишите цикл, который принимает на вход  два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());
int St = 1;
int i = 1;
while (i <= B)
{
St = St*A;
i++;
}
Console.WriteLine($"{A} в стенени {B} = {St}");
        