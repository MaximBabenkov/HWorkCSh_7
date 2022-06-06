// Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщает, что это невозможно (в случае, если матрица неквадратная)
void PrintMatrix (int[,]matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
}

int[,]FillMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,]matrix=new int[rows,columns];
    var Random=new Random();
    for (int i=0;i<rows;i++)
        for (int j=0;j<columns;j++)
            matrix[i,j]=new Random().Next(minValue,maxValue);
    return matrix;
}

int[,]RowsToColumns(int[,]matr)
{
    int[,]matr2=new int[matr.GetLength(1),matr.GetLength(0)];
    for (int i=0;i<matr.GetLength(0);i++)
          for (int j=0;j<matr.GetLength(1);j++)
                    matr2[j,i]=matr[i,j];                
    return matr2;
}

Console.Clear();
Console.Write("Enter amount of matrix rows: ");
int rows=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter amount of matrix columns: ");
int columns=int.Parse(Console.ReadLine()??"0");
if (rows!=columns)
    Console.WriteLine("This matrix is non-square. Replacing rows with columns is not possible");
else
{ 
Console.Write("Enter left side of matrix elements: ");
int start=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter right side of matrix elements: ");
int finish=int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
int[,]matrix=FillMatrix(rows,columns,start,finish);
PrintMatrix(matrix);
Console.WriteLine();
int[,]matrMod=RowsToColumns(matrix);
PrintMatrix(matrMod);
Console.WriteLine();
}
