// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M = ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N = ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (IsNatural(numberM, numberN)) Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} равна: {NaturalNumbersSum(numberM, numberN)}");

int  NaturalNumbersSum(int numM, int numN)
{
    if (numM == 0 || numN == 0) return 0;
    else
        return numM + NaturalNumbersSum(numM + 1, numN - 1);
}

bool IsNatural(int numM, int numN)
{
    return numM > 0 && numN > 0;
}
    