// Найти сумму цифр числа

int SumNumber(int n)
{
    if (n/10==0) return n;
    return SumNumber(n/10) +n%10;
}
Console.WriteLine(SumNumber(222));