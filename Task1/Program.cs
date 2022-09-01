// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    int x = 0, y = 3;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(array[i, j]);
            x = x + 4;
        }
        x = 0;
        y = y + 1;
    }
    Console.WriteLine();
}

FillArray(myarray);
Display(myarray);
Console.WriteLine();

int[] linearray = new int[myarray.GetLength(0)];

for (int i = 0; i < myarray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        sum = sum + myarray[i, j];
    }
    linearray[i] = sum;
}

 // foreach(int i in linearray) Console.Write (i+ " ");

void MinimumRow(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Minimum sum row index is {index} (Row number {index+1}) ");
}

MinimumRow(linearray); 
