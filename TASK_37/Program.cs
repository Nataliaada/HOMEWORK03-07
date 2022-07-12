// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = { 1, 2, 3, 4, 7, 9, 5};

int[] GetProizved(int[] arr)
{
    int newL = arr.Length / 2;
    if (arr.Length % 2 == 0)
    {
        int[] newArr = new int[newL];
        for (int i = 0; i < newL; i++)
        {
            newArr[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        return newArr;
    }
    else
    {
        int[] newArr = new int[newL + 1];
        for (int i = 0; i <= newL; i++)
        {
            if ( i == newL)
            {
                newArr[i] = arr[newL];
            }
            else
            {
                newArr[i] = arr[i] * arr[arr.Length - 1 - i];
            }
        }
            return newArr;
        
    }
}
    void PrintArray(int[] arr1)
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            if (i == 0) Console.Write("[");
            if (i < arr1.Length - 1) Console.Write(arr1[i] + ",");
            else Console.WriteLine(arr1[i] + "]");
        }
    }
    PrintArray(array);
    int[] newArray = GetProizved(array);
    PrintArray(newArray);
