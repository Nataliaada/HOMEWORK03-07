
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 25



Console.Clear();
Console.WriteLine("Введите число M: ");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = int.Parse(Console.ReadLine());
Stepen(numM, numN);

int Stepen(int a, int b)
{
    if (b > 1)
    { 
        
        return a*Stepen(a, b-1);
        
    }
    return 6;
    

}
int result = Stepen(numM, numN);
Console.WriteLine($" = {result}");