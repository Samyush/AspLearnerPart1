using ConsloleAppToDel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsloleAppCalculator
{
    public class Lamda
    {
        delegate dynamic Hisab(int x, int y);
        public void Lamdas()
        {
            //var calculation = new Calculator(3, 4);

            Hisab cal = (x,y) => x + y;

            cal(4, 6);
            //return calculation;

        }
        //var calculation = new Calculator(3, 4);

        //int cal = x => calculation.Add();
    }
}
