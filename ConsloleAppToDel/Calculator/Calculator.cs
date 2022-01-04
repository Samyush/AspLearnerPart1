using System;
using System.Collections.Generic;
using System.Text;

namespace ConsloleAppToDel
{
    class Calculator
    {
        int num2 { get; set; }
        int num1 { get; set; }

        public Calculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Adds() =>  num1 + num2;

        public void Add()
        {
            int sum = num1 + num2;
            Console.WriteLine("Sum of two numbers is " + sum);
        }

        public void Subtract()
        {
            int ghatau = num1 - num2;

            Console.WriteLine("ghatau of two numbers is " + ghatau);
        }

        public void Multiply()
        {

            int multi = num1 * num2;

            Console.WriteLine("Multiple is: " + multi);

            var multiple = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, };
            Console.WriteLine("multidimension array " + multiple[2, 3]);

        }

    }
}
