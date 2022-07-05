// Задача 29: Напишите программу, которая задаёт массив  из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  6, 1, 33 -> [6, 1, 33]


void printRndMassive(int [] arr)
{
int index = 0 ;
var rnd = new Random();

while (index < arr.Length)
{
    arr[index] = rnd.Next(0,10);
  index++;
}
// }
// void printMassive(int [] arr) 
// {
for ( int i  = 0; i < arr.Length; i ++)
{
    if (i == 0) Console.Write("[");
    if (i < arr.Length -1) Console.Write(arr[i] + ",");
    else Console.Write(arr[i]+"]");
}
}   

int [] array = new int [8];
printRndMassive(array);
// printMassive(array);

