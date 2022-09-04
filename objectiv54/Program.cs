Console.WriteLine();
Console.Write("Введите размер ряда: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Двумерный массив: ");
int[,] matrix = new int[colums, rows];
GetArrayFillRandomNumbers(matrix);
WriteArray(matrix);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив: ");
DescendingRowArray(matrix);
WriteArray(matrix);

void DescendingRowArray( int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(1) - 1; c++)
            {
                if (array[a, c] < array[a, c + 1])
                {
                    int coup = array[a, c + 1];
                    array[a, c + 1] = array[a, c];
                    array[a, c] = coup;
                }
            }
        }
    }
}


void GetArrayFillRandomNumbers( int[,] array)
{
for (int a = 0; a < array.GetLength(0); a++)
{
    for (int b = 0; b < array.GetLength(1); b++)
    {
        array[a, b] = new Random().Next(-100, 100);
    }
}
}

void WriteArray(int[,] array)
{
   for (int a = 0; a < array.GetLength(0); a++)
{
    for (int b = 0; b < array.GetLength(1); b++)
    {
        Console.Write(array[a, b] + " ");
    }
    Console.WriteLine("");
}
}