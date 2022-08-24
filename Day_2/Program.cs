int rnumber = new Random().Next(10,100);
Console.WriteLine(rnumber);
int a = rnumber % 10;
Console.WriteLine(a);
int b = (rnumber)/10;
Console.WriteLine(b);
if(a>b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}