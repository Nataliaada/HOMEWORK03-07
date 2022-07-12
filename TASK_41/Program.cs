// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите кол-во чисел которые будуете вводить ");
int number = Convert.ToInt32(Console.ReadLine());

int HowManyCountPositive(int b)
{
    int count1= 0;

    for (int i = 0; i < b; i++)
    {
        Console.WriteLine("Введите число ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
            count1++;
    }
    return count1;
}
int count = HowManyCountPositive(number);
Console.WriteLine($"{count} ");