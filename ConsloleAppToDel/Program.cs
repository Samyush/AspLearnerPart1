using ConsloleAppCalculator;
using ConsloleAppCalculator.FetchDataAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsloleAppToDel
{
    static class Program
    {
        private static void Main(string[] args)
        {

            //UsingPrivateReadOnly prv = new UsingPrivateReadOnly(5);
            
            // objects can be defined as follows too of line 14
            UsingPrivateReadOnly prv = new(5);

            prv.printer();

            //GetData getData = new GetData();

            //new object can be defined as follows too
            GetData getData = new();
            // if not static, it is done as follows:
            // getData.GettingData();

            //for static method, a static method belongs to the class rather than the object 
            // there is no need to create the object to call the static variable
            GetData.GettingData();


            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{Id = 1, Name = "sam"},
                new Employee{Id = 2, Name = "hari"},
                new Employee{Id = 3, Name= "sari"}
            };

            Employee emp = listEmployees.Find(x => x.Id == 1);
            Console.WriteLine(emp.Name);

            var count = listEmployees.Count(x => x.Name.StartsWith("s"));
            Console.WriteLine(count);

            string num1,num2;

            Console.WriteLine("Welcome to Our Console Calculator Application");

            //Console.WriteLine("Hello World!");
            Console.Write("Please Enter 1st num ");
            num1 = Console.ReadLine();

            Console.Write("Please Enter 2nd num ");
            num2 = Console.ReadLine();

            var calculus = new Calculator(int.Parse(num1), int.Parse(num2));
            calculus.Add();
            calculus.Subtract();
            calculus.Multiply();

            for (int i = 1; i < 10; i++)
            {
                //Console.WriteLine("Success " + testString);
            }
        }


    }
}
