/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumOfNumbers(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    if (M < N)
    {
        return (M + SumOfNumbers(M + 1, N));
    }
    else
    {
        return (M + SumOfNumbers(M - 1, N));
    }
}

Console.WriteLine("Введите первое число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int rezult = SumOfNumbers(firstNumber, secondNumber);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {firstNumber} до {secondNumber} = {rezult}");