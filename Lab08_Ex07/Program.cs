using System;

class MyProgram
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyProgram adder = new MyProgram();

        int x = 2, y = 3;
        int add_result = adder.Add(x, y);
        Console.WriteLine($"{x} + {y} = {add_result}");

        int i = 2, j = 3;
        int multiply_result = adder.Multiply(i, j);
        Console.WriteLine($"{i} x {j} = {multiply_result}");
    }
}