using System;

delegate int AddDelegate(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        AddDelegate addDelegate = new AddDelegate(AddNumbers);

        int sum = addDelegate(5, 7);

        Console.WriteLine("The sum of 5 and 7 is: " + sum);
        Console.ReadLine();
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}