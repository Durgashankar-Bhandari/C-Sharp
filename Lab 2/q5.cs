using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> customers = new Dictionary<int, string>();

        customers.Add(1001, "John");
        customers.Add(1002, "Smith");
        customers.Add(1003, "Bob");

        foreach (KeyValuePair<int, string> customer in customers)
        {
            Console.WriteLine("Customer ID: " + customer.Key + ", Name: " + customer.Value);
        }

        Console.ReadLine();
    }
}