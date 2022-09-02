// Рекурсия.Показать натуральные числа от 1 до N, N заданно.
void number(int m,int n)
{
    if(m<=n)
    {
        Console.Write("{0}",m);number(m+1,n);

    }
}
int n = 5;
int m = 1;
number(m,n);
Console.WriteLine();
