using System;

namespace ConsloleAppToDel;

internal class Calculator
{
    public Calculator(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }

    private int Num2 { get; }
    private int Num1 { get; }

    public int Adds()
    {
        return Num1 + Num2;
    }

    public void Add()
    {
        var sum = Num1 + Num2;
        Console.WriteLine("Sum of two numbers is " + sum);
    }

    public void Subtract()
    {
        var ghatau = Num1 - Num2;

        Console.WriteLine("ghatau of two numbers is " + ghatau);
    }

    public void Multiply()
    {
        var multi = Num1 * Num2;

        Console.WriteLine("Multiple is: " + multi);

        var multiple = new int[3, 4] {{0, 1, 2, 3}, {4, 5, 6, 7}, {8, 9, 10, 11}};
        Console.WriteLine("multidimensional array " + multiple[2, 3]);
    }
}