// Показать натуральные числа от M до N, N и M заданы

void NumberCounter(int M, int N)
{
    if (N<M) return;
    NumberCounter(M,N-1);
    Console.Write(N + " ");
}
NumberCounter(1,10);