
using System;

public class NumberOperations
{
    // Метод для округления вещественного числа
    public double Round(double number)
    {
        return Math.Round(number);
    }

    // Метод для взятия модуля числа
    public double Absolute(double number)
    {
        return Math.Abs(number);
    }

    // Метод для проверки на четность
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Метод для проверки на нечетность
    public bool IsOdd(int number)
    {
        return number % 2 != 0;
    }
}