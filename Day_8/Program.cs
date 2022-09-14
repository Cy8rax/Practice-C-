//Написать прогу которая меняет первую и последнюю строки массива.

// Random random = new Random();
// int[,] matrix=new int[random.Next(1,10),random.Next(1,10)];

// void printer(int[,] array)
// {
//     for(int i=0;i<matrix.GetLength(0);i++)
//     {
//         for(int j=0;j<matrix.GetLength(1);j++)
//         {
//             Console.Write((matrix[i,j]=random.Next(1,10))+"\t");
//         }
//         Console.WriteLine();
//     }
// }

// void changer(int[,] array)
// {
//     for(int j=0;j<matrix.GetLength(1);j++)
//     {
//         int a = matrix[0,j];
//         matrix[0,j]=matrix[matrix.GetLength(0)-1,j];
//         matrix[matrix.GetLength(0)-1,j]= a;
//     }
// }

// printer(matrix);
// changer(matrix);
// Console.WriteLine("----------------------");
// for(int i=0;i<matrix.GetLength(0);i++)
// {
//     for(int j=0;j<matrix.GetLength(1);j++)
//     {
//         Console.Write(matrix[i,j]+"\t");
//     }
//     Console.WriteLine();
// }

//Написать прогу которая заменяет строки на столбцы, еси не возможно прога об этом говорит.
// Random random = new Random();
// Console.WriteLine("Строки: ");
// int row=int.Parse(Console.ReadLine());
// Console.WriteLine("Столбцы: ");
// int column=int.Parse(Console.ReadLine());
// int[,] matrix= new int[row,column];

// void fillarray(int[,] array)
// {
//     for(int i=0;i<array.GetLength(0);i++)
//     {
//         for(int j=0;j<array.GetLength(1);j++)
//         {
//             array[i,j]=random.Next(1,10);
//             Console.Write(array[i,j]+"\t");
//         }
//         Console.WriteLine();
//     }
// }

// void changer(int[,] array)
// {
//     for(int i=0;i<array.GetLength(0);i++)
//     {
//         for(int j=0;j<array.GetLength(1);j++)
//         {
//             int a = array[i,j];
//             array[i,j]=array[j,i];
//             array[j,i]=a;
//         }
//     }
// }
// fillarray(matrix);
// changer(matrix);

// Console.WriteLine("----------------------");
// for(int i=0;i<matrix.GetLength(0);i++)
// {
//     for(int j=0;j<matrix.GetLength(1);j++)
//     {
//         Console.Write(matrix[i,j]+"\t");
//     }
//     Console.WriteLine();
// }

//Прога удаляющая строку и столбец с наименьшим числом.
