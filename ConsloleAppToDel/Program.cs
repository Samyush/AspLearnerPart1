using System;
using System.Collections.Generic;
using System.Linq;
using ConsloleAppToDel;
using ConsoleAppCalculator.FetchDataAPI;

namespace ConsoleAppCalculator;

internal static class Program
{
    	
    public abstract class A{
        public void W1(){
            Console.WriteLine("hello");
        }
        public virtual void W2(){
            Console.WriteLine("test");
        }
    }

    public class B : A{
        
        /// <summary>
        /// the below method cannot be override as it needs to be virtual
        /// </summary>
        /*public override void w1(){
            Console.WriteLine("testing");
        }*/
        public override void W2(){
            Console.WriteLine("testing");
        }
    }
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


        var listEmployees = new List<Employee>
        {
            new() {Id = 1, Name = "sam"},
            new() {Id = 2, Name = "hari"},
            new() {Id = 3, Name = "sari"}
        };

        var emp = listEmployees.Find(x => x.Id == 1);
        Console.WriteLine(emp.Name);

        var count = listEmployees.Count(x => x.Name.StartsWith("s"));
        Console.WriteLine(count);

        string num1, num2;

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

        for (var i = 1; i < 10; i++)
        {
            //Console.WriteLine("Success " + testString);
        }
    }
}