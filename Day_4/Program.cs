//Прога которая принимает на вход число А и выдает сумму чисел от 1 до А.

// Console.WriteLine("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Summarizer(int numb)
// {
//     int count = 0;
//     for(int i=0;i<=numb;i++)
//     {
//         count+=i;
//     }
//     return count;
// }

// Console.WriteLine("The Summary is: "+Summarizer(number));

//Программа которая принимает число N и выдает произведение чисел от 1 до N.

// int num = Convert.ToInt32(Console.ReadLine());

// int Multy(int number)
// {
//     int count = 0;
//     int smul =1;
//     while(count<number)
//     {
//         count++;
//         smul = smul*count;
//     }
//     return smul;
// }

// Console.WriteLine("Here's your number, son: "+Multy(num));

//Напишите программу которая выводит массив из 8 элементов заполненный 0 и 1 в случайном порядке.

int[] array= new int[8];

void Generator(int[] arr)
{
    for(int i=0;i<8;i++)
    arr[i]=new Random().Next(0,2);
}

Generator(array);

void Print(int[] arr)
{
    int count=0;
    while(count<8)
    {
        Console.Write(array[count]+", ");
        count++;
    }
}

Print(array);