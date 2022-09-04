Console.WriteLine();
Console.Write("Введите число строк 1-й матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы и число сток 2 - й матрицы: ");
int colums1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2-й матрицы: ");
int colums2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[rows1, colums1];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[colums1, colums2];
CreateArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[rows1,colums2];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int a = 0; a < resultMatrix.GetLength(0); a++)
  {
    for (int b = 0; b < resultMatrix.GetLength(1); b++)
    {
      int sum = 0;
      for (int c = 0; c < firstMartrix.GetLength(1); c++)
      {
        sum += firstMartrix[a, c] * secondMartrix[c, b];
      }
      resultMatrix[a, b] = sum;
    }
  }
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