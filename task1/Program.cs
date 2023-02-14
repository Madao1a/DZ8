// Показать натуральные числа от 1 до N, N задано

void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + " ");
}
PrintNumber(10);