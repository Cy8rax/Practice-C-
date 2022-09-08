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
int[] GetArray(int size, int minValue,int maxValue)
{
    int[] res = new int[size];
    for(int i=0;i<size;i++)
    {
        res[i]= new Random().Next(minValue,maxValue+1);
    }
    return res;
}

void ReversArray(int[] inArray)
{
    for(int i=0;i<inArray.Length/2;i++)
    int k=inArray[i];
    inArray[i]=inArray[inArray.Length-1-i];
    inArray[inArray.Length-1-i]=k; 
}