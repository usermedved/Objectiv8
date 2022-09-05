Console.WriteLine($"Введите размер трехмерного массива X x Y x Z:");
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temporal = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temporal.GetLength(0); i++)
  {
    temporal[i] = new Random().Next(10, 100);
    number = temporal[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temporal[i] == temporal[j])
        {
          temporal[i] = new Random().Next(10, 100);
          j = 0;
          number = temporal[i];
        }
          number = temporal[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temporal[count];
        count++;
      }
    }
  }
}

