// Задать массив из 12ти элементов (-9 до 9) и просуммировать отрицательные и положительные числа

// int[] arr=new int[12];
// int size = arr.Length;
// void Randomizer(int[] array)
// {
//     for(int i=0;i<size;i++)
//     array[i]=new Random().Next(-9,10);
// }

// Randomizer(arr);
// Console.WriteLine(String.Join(", ",arr));
// void Summarizer(int[] array)
// {
//     int positive = 0;
//     int negative = 0;
//     for(int j=0;j<size;j++)
//     {
//         if(array[j]>=0)
//         {
//             positive+=array[j];
//         }
//         else
//         {
//             negative+=array[j];
//         }
//     }
//     Console.WriteLine("Sum Positive = "+positive+"; Sum Negative = "+negative);
// }

// Summarizer(arr);

//Найти произведение пар чисел в массиве. Парой считать первый и последний, второй и предпоследний и т.д.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array =new int[size];

int[] temp=new int[size/2+size%2];

void Gener(int[] arr)
{
    for(int i=0;i<size;i++)
    arr[i]=new Random().Next(0,10);
}

Gener(array);
Console.WriteLine(String.Join("; ", array));
for(int j=0;j<(size/2+size%2);j++)
{
    temp[j]=array[j]*array[size-1-j];
    if(j==size-1-j)
    {
        temp[j]=array[j];
    }
}
Console.WriteLine(String.Join("; ", temp));