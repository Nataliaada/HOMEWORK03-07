﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.WriteLine("Введите размер 3х мерного массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());



int[, ,]  CreateMatrixRndInt(int m, int n, int K)
{
    int[, ,] array = new int[m, n, K];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          for (int g = 0; g < array.GetLength(2); g++)
       {
          array[i, j, g] = rnd.Next(10, 100);
        }
    
        }
    }
            return array;
}

void PrintMatrix(int[,,] arr)
{
    
    for (int k = 0; k < arr.GetLength(2); k++)
  
      {
      for (int i = 0; i < arr.GetLength(0); i++)
      {
         for (int j = 0; j < arr.GetLength(1); j++)
  
      {
        Console.Write( $"{arr[i,j,k]}  ({i} {j} {k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
    
}



int[, ,] matrix = CreateMatrixRndInt(num1, num2, num3);
PrintMatrix(matrix);
Console.WriteLine();
