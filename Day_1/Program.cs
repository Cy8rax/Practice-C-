Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int number2= number*(-1);

while(number2<=number)
{
    Console.WriteLine(number2);
    number2++;
}