//Задайте двумерный массив 3х4 запоненный случайными целыми числами.

// int[,] matrix=new int[3,4];

// void Randomizer(int[,] arr)
// {
//     for(int i=0;i<arr.GetLength(0);i++)
//     {
//         Console.WriteLine();
//         for(int j=0;j<arr.GetLength(1);j++)
//         {
//             matrix[i,j]=new Random().Next(1,101);
//             Console.Write(matrix[i,j]+"\t");
//         }
//     }
// }

// Randomizer(matrix);

//Задайте двумерный массив m*n, каждый элемент в массиве находится по формуле A=m+n
// int row = Convert.ToInt32(Console.ReadLine());
// int column = int.Parse(Console.ReadLine());

// int[,] matrix = new int[row,column];

// for(int i=0;i<matrix.GetLength(0);i++)
// {
//     Console.WriteLine();
//     for(int j=0;j<matrix.GetLength(1);j++)
//     {
//         matrix[i,j]=i+j;
//         Console.Write(matrix[i,j]+" ");
//     }
// }

//Задайте двумерный массив и если оба индекса четные то заменяем их элементы на их квадраты:
// int row=int.Parse(Console.ReadLine());
// int column=int.Parse(Console.ReadLine());

// int[,] matrix=new int[row,column];

// for(int i=0;i<matrix.GetLength(0);i++)
// {
//     Console.WriteLine();
//     for(int j=0;j<matrix.GetLength(1);j++)
//     {
//         matrix[i,j]=new Random().Next(1,10);
//         if(i%2==0&&j%2==0)
//         {
//             matrix[i,j]=Convert.ToInt32(Math.Pow(matrix[i,j],2));
//         }
//     Console.Write(matrix[i,j]+"\t");
//     }
// }

// Задайте двумерный массив. Найти сумму эл-ов на главной диагнонали (0,0) (1,1) и т.д.

int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());

int[,] matrix=new int[row,column];
int sum=0;

void ArrFiller(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        Console.WriteLine();
        for(int j=0;j<arr.GetLength(1);j++)
        {
        arr[i,j]=new Random().Next(1,10);
        Console.Write(arr[i,j]);
        }
    }
    Console.WriteLine();
}

int Summarizer(int[,] arr)
{
    Console.Write("Сумма элементов главной диагонали: ");
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            if(i==j)
            {
                Console.Write(arr[i,j]+"+");
                sum+=arr[i,j];
            }
        }
    }
    return sum;
}

ArrFiller(matrix);
Console.WriteLine($"= {Summarizer(matrix)}");