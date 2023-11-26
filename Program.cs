Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"

int numM = ReadData("Введите начало диапазона:");
int numN = ReadData("Введите конец диапазона:");


string res = GenRecLine(numM, numN);


Console.Write((numM > numN) ? GenRecLine(numN, numM) : GenRecLine(numM, numN));


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


string GenRecLine(int numM, int numN)
{
    string res = string.Empty;
    if (numM <= numN)
    {
        res = numM + "," + GenRecLine(numM + 1, numN);
    }

    return res;
}

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int numM = ReadData("Введите начало диапазона:");
int numN = ReadData("Введите конец диапазона:");


long res = SumNaturals(numM, numN);


Console.Write("Сумма натуральных чисел в диапазоне: " + ((numM > numN) ? SumNaturals(numN, numM) : SumNaturals(numM, numN)));


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


long SumNaturals(int numM, int numN)
{
    long sum = 0;
    if (numM <= numN)
    {
        sum += numM + SumNaturals(numM + 1, numN);
    }
    return sum;
}

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29


long numM = ReadData("Введите первое число для ф-ии Аккермана:");
long numN = ReadData("Введите второе число для ф-ии Аккермана:");

long res = CalcAckFunc(numM, numN);


Console.Write("Результат ф-ции Аккермана: " + res);


long ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод вычисления ф-ии Аккермана
long CalcAckFunc(long numM, long numN)
{

    if (numM == 0)
        return numN + 1;
    else
      if ((numM != 0) && (numN == 0))
        return CalcAckFunc(numM - 1, 1);
    else
        return CalcAckFunc(numM - 1, CalcAckFunc(numM, numN - 1));

}