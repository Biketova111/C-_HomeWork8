/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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


int [,] ProductOfMatrices (int[,] matr1, int[,] matr2)
{
    int [,] resultMatrix = new int [matr1.GetLength(0), matr2.GetLength(1)];
    
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
               resultMatrix[i,j] +=  matr1[i,k]*matr2 [k,j];
            }
           
        }
    }
   return resultMatrix; 
}

int sizeN1 = GetNumber("Введите количество строк первой матрицы: ");
int sizeM1 = GetNumber("Введите количество столбцов первой матрицы: ");
int sizeN2 = GetNumber("Введите количество строк второй матрицы: ");
int sizeM2 = GetNumber("Введите количество столбцов второй матрицы: ");
int min = GetNumber("Введите начальное значение числового диапазона: ");
int max = GetNumber("Введите начальное значение числового диапазона: ");
int[,] Matrix1 = GetMatrix(sizeN1, sizeM1, min, max);
int[,] Matrix2 = GetMatrix(sizeN2, sizeM2, min, max);
PrintMatrix(Matrix1);
Console.WriteLine();
PrintMatrix(Matrix2);
Console.WriteLine();
int [,] result = ProductOfMatrices (Matrix1, Matrix2);
PrintMatrix(result);


