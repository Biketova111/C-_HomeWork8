/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using System.Security.Principal;

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Повторите ввод");
        }
    }
    return result;
}
int[,] GetMatrix(int n, int m, int min, int max)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetNewMatrix (int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int x = 0; x<matr.GetLength(1)-1; x++)
           {
           if (matr [i,x]<matr [i,x+1])
          {
           temp = matr[i, x];
           matr[i, x] = matr[i, x + 1];
           matr[i, x + 1] = temp;
          }      
        }
}
}
}




int sizeN = GetNumber("Введите количество строк массива: ");
int sizeM = GetNumber("Введите количество столбцов массива: ");
int min = GetNumber("Введите начальное значение числового диапазона: ");
int max = GetNumber("Введите начальное значение числового диапазона: ");
int[,] resultMatrix = GetMatrix(sizeN, sizeM, min, max);
PrintMatrix(resultMatrix);
GetNewMatrix (resultMatrix);
Console.WriteLine();
PrintMatrix(resultMatrix);


