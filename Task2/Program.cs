// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

Console.Write("How many rows in your array A? ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns in your array A? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns in your array B? ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] myarrayA = new int[l, m];
int[,] myarrayB = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

FillArray(myarrayA);
FillArray(myarrayB);

Display(myarrayA);
Display(myarrayB);

Console.WriteLine("The product of matrices:");

void MultiplyMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                sum = sum + arrayA[i, k] * arrayB[k, j];
            }
            arrayC[i, j] = sum;
        }
    }
    Display(arrayC);
}

void Display(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

MultiplyMatrix(myarrayA, myarrayB);