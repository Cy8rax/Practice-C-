int Grader(int a, int b)
{
        if(b==0) return 1;
        else
        {
            return (a*Grader(a,b-1));
        }
}
Console.WriteLine(Grader(2,3));