// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArrrayRnd(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 100);
        Console.Write(array[index] + " ");
        index++;

    }
    return array;
}

int FindSumNotEvenPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;

}

int[] array1 = GetArrrayRnd(5);
int sum1 = FindSumNotEvenPosition(array1);
Console.WriteLine();
Console.WriteLine(sum1);
