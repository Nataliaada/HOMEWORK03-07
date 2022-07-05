// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sum = 0;

while (num != 0) //Не равно
{
    int num1 = num % 10;
    sum = sum + num1;
    num = num / 10; // num /=;
    count = count + 1; // count++;
}
Console.WriteLine($"Сумму цифр в числе =  {sum}");
