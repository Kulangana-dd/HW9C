/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int AckermanFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (N == 0 && M > 0)
    {
        return AckermanFunction(M - 1, 1);
    }
    else
    {
        return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
    }
}

Console.Write("Введите первое неотрицательное число N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число M: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int rezult = AckermanFunction(firstNumber, secondNumber);
Console.WriteLine($"А({firstNumber},{secondNumber}) = {rezult}");