// int rnumber = new Random().Next(10,100);
// Console.WriteLine(rnumber);
// int a = rnumber % 10;
// Console.WriteLine(a);
// int b = (rnumber)/10;
// Console.WriteLine(b);
// if(a>b)
// {
//     Console.WriteLine(a);
// }
// else
// {
//     Console.WriteLine(b);
// }

//App that delete 2nd number in 3rd Count
// int rnum = new Random().Next(100,1000);
// Console.WriteLine(rnum);
// int a = rnum/100;
// int c = rnum%10;
// Console.Write("{0}{1}",a,c);

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
double a = num1 % num2;
if(a == 0)
{
    Console.WriteLine("the number is Кратно ))");
}
else
{
    Console.WriteLine("The remainder" + a);
}
Console.WriteLine(a);