using System;
using System.Collections.Generic;
using System.Text;

namespace ConsloleAppToDel
{
    class Calculator
    {
        int Num2 { get; set; }
        int Num1 { get; set; }

        public Calculator(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public int Adds() =>  Num1 + Num2;

        public void Add()
        {
            int sum = Num1 + Num2;
            Console.WriteLine("Sum of two numbers is " + sum);
        }

        public void Subtract()
        {
            int ghatau = Num1 - Num2;

            Console.WriteLine("ghatau of two numbers is " + ghatau);
        }

        public void Multiply()
        {

            int multi = Num1 * Num2;

            Console.WriteLine("Multiple is: " + multi);

            var multiple = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, };
            Console.WriteLine("multidimension array " + multiple[2, 3]);

        }

    }
}
