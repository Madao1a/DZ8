// Показать натуральные числа от N до 1, N задано

void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write(number + " ");
    NumberCounter (number - 1);
}

NumberCounter(10);