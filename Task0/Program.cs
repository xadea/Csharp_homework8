// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Clear();

Console.Write("How many rows in your array? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns in your array? ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myarray = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
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

FillArray(myarray);
Console.WriteLine("Your array:");
Display(myarray);
Console.WriteLine();

void FromMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temporary = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
    }
}

FromMaxToMin(myarray);
Console.WriteLine("Array's rows in descending order:");
Display(myarray);
