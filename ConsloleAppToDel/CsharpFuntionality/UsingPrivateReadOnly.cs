using System;

namespace ConsoleAppCalculator;

public class UsingPrivateReadOnly
{
    public UsingPrivateReadOnly(int count)
    {
        Count = count;
    }

    public int Count { get; }

    public void printer()
    {
        Console.WriteLine(Count);
    }
}