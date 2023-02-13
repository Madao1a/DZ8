// Найти сумму цифр числа

int N=44451;
int sum=0;

while (N!=0)
{
    sum+=N%10;
    N/=10;
}
Console.WriteLine(sum);