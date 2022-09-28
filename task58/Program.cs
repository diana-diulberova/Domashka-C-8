/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

int rows = new Random().Next(2,5);
int columns = new Random().Next(2,5);

int[,] firstMatrix = GetArray(rows, columns, 1, 5);
int[,] secondMatrix = GetArray(columns, rows, 1, 5);

PrintArray(firstMatrix);
Console.WriteLine();

PrintArray(secondMatrix);
Console.WriteLine();


int[,] resultMatrix = MatrixProduct(firstMatrix, secondMatrix);
Console.WriteLine("Результирующая матрица равна:");
PrintArray(resultMatrix);

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int[,] MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            for(int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + firstMatrix[i,k] * secondMatrix[k,j];
            }
        }
    }
    return result;
}