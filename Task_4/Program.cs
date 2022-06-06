// В прямоугольной матрице найти строку с наименьшей суммой элементов

void PrintMatrix (int[,]matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
}

int[,] FillMatrix (int rows, int columns, int minValue, int maxValue)
{
    int[,]matrix=new int[rows,columns];
    var Random=new Random();
    for (int i=0;i<rows;i++)
        for (int j=0;j<columns;j++)
            matrix[i,j]=new Random().Next(minValue,maxValue);
    return matrix;
}

int[] ArrOfSums(int[,]matr)
{
    int sum=0;
    int[]arr=new int[matr.GetLength(0)];
    for (int i=0;i<matr.GetLength(0); i++)
        for (int j=0;j<matr.GetLength(1); j++)
            arr[i]=sum+matr[i,j];
    return (arr);
}

void PrintArray(int[]arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int FindMin(int[]arr)
{
    int iMin=0;
    int min=arr[0];
    for (int i=1;i<arr.Length;i++)
    {
        if(arr[i]<min) 
        {
            min=arr[i];
            iMin = i;
        }
    }
    return(iMin);
}

Console.Clear();
Console.Write("Enter amount of matrix rows: ");
int rows=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter amount of matrix columns: ");
int columns=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter left side of matrix elements: ");
int start=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter right side of matrix elements: ");
int finish=int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
int[,]matrix=FillMatrix(rows,columns,start,finish);
PrintMatrix(matrix);
int[]arr=ArrOfSums(matrix);
Console.WriteLine();
Console.Write($"The sums of elements in rows: ");
PrintArray(arr);
Console.WriteLine();
Console.Write($"The row with the smallest sum of elements: {FindMin(arr)+1}");
Console.WriteLine();
Console.WriteLine();
