//Перевернуть одномерный массив:
// int size = new Random().Next(1,10);
// int[] mass =new int[size];
// int[] temp = new int[mass.Length];
// void Gener(int[] arr)
// {
//     for(int i=0;i<size;i++)
//     {
//         arr[i]=new Random().Next(1,100);
//     }
// }

// Gener(mass);
// Console.WriteLine("[{0}]",String.Join(",",mass));

// void Reverter(int[] arr)
// {
//     for(int i=0;i<size;i++)
//     {
//         temp[size-i-1]=arr[i];
//     }
// }
// Reverter(mass);
// Console.WriteLine("[{0}]",String.Join(",",temp));

//Альтернативный способ:
// int[] Array=GetArray(10,0,10);
// Console.WriteLine(String.Join(",",Array));

// ReversArray(Array);
// Console.WriteLine(String.Join(",",Array));

// int[] GetArray(int size, int minValue,int maxValue)
// {
//     int[] res = new int[size];
//     for(int i=0;i<size;i++)
//     {
//         res[i]= new Random().Next(minValue,maxValue+1);
//     }
//     return res;
// }

// void ReversArray(int[] inArray)
// {
//     for(int i=0;i<inArray.Length/2;i++)
//     {
//         int k=inArray[i];
//         inArray[i]=inArray[inArray.Length-1-i];
//         inArray[inArray.Length-1-i]=k; 
//     }
// }

//Перевод числа в двичную систему

// Console.WriteLine("Введите число для перевода в десятеричную: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void convert(int number)
// {
//     string result="";
//     while(number>0)
//     {
//     result=number%2+result;
//     number/=2;
//     }
//     Console.WriteLine(result);
// }

// convert(number);

//Выведите первые числа фибоначчи:
//----пример с лекции----
// int fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return fibonacci(n-1)+fibonacci(n-2);
// }

// for(int i=1;i<10;i++)
// {
//     Console.WriteLine(fibonacci(i));
// }

//---решение---
// Console.Write("Введите число n: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[number];
// Console.WriteLine(String.Join(",",array));
// array[0] = 1;
// array[1] = 1;
// for(int i=2; i<number-1;i++)
// {
//     array[i+1]=array[i]+array[i-1];
//     Console.Write(array[i+1]+" ");
// }

//---OR----//

int num=Convert.ToInt32(Console.ReadLine());

int firstN = 0;
int secondN = 1;

for(int i=3;i<=num;i++)
{
    int newN=firstN+secondN;
    Console.Write(newN+", ");
    firstN=secondN;
    secondN=newN;
}