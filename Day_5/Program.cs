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
if(size/2 % 2!=0)
{
    int end = size/2+1;
}
else
{
    int end = size/2;
}
int[] array_B=new int[end];

void Gener(int[] arr)
{
    for(int i=0;i<size;i++)
    arr[i]=new Random().Next(0,10);
}

void logics(int[] arr1, int[] arr2)
{
    for(int j=0;j<end;j++)
    size=size-1
    array_B[j]=array[j]+array[j+size-1]
}