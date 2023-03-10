/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


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
int[,,] GetMatrix(int min, int max)
{
    int[,,] matrix = new int[2, 2, 2];
    Random rnd = new Random();
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
           for (int k = 0; k < 2; k++)
            matrix[i, j, k] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
            Console.Write($"{matr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
          }
           
}

int min = GetNumber("Введите начальное значение числового диапазона: ");
int max = GetNumber("Введите начальное значение числового диапазона: ");
int[,,] resultMatrix = GetMatrix(min, max);
PrintMatrix (resultMatrix);
