﻿namespace ConsoleAppCalculator;

public class Lamda
{
    public static void Lamdas()
    {
        //var calculation = new Calculator(3, 4);

        Hisab cal = (x, y) => x + y;
        Hisab next = (a, y) => a - y;

        cal(4, 6);

        cal(5, 7);
        next(7, 1);
        //return calculation;
    }

    private delegate dynamic Hisab(int x, int y);
    //var calculation = new Calculator(3, 4);

    //int cal = x => calculation.Add();
}