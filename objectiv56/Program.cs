Console.WriteLine();
Console.Write("Введите размер ряда: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Двумерный массив: ");
int[,] array = new int[rows, colums];
CreateArray(array);
WriteArray(array);

int minSumRows = 0;
int sumRows = SumRowsElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temporalSumRows = SumRowsElements(array, i);
  if (sumRows > temporalSumRows)
  {
    sumRows = temporalSumRows;
    minSumRows = i;
  }
}
Console.WriteLine();
Console.WriteLine($"{minSumRows+1} - строкa с наименьшей суммой элементов ({sumRows})");


int SumRowsElements(int[,] array, int i)
{
  int sumRows = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRows += array[i,j];
  }
  return sumRows;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(100);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}