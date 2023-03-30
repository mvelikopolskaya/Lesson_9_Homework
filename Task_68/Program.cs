// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число M = ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N = ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (IsPositive(numberM, numberN)) Console.WriteLine(Ackerman (numberN, numberM));
else Console.WriteLine("Число(а) не являются положительными");



int Ackerman (int numN, int numM)
{
    while (numN != 0)
    {
        if (numM == 0) numM = 1;
        else 
        {
            numM = Ackerman (numN, numM - 1);  
        }
        numN = numN - 1;
    }
    return numM + 1;
}



bool IsPositive(int numM, int numN)
{
    return numM > 0 && numN > 0;
}