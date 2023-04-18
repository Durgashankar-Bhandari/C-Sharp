using System;

class Program {
    static void Main(string[] args) {
        int[] array = {1, 2, 3, 4, 5};
        Console.WriteLine("Original Array:");
        PrintArray(array);

        ReverseArray(array);
        Console.WriteLine("\nReversed Array:");
        PrintArray(array);
    }

    static void ReverseArray(int[] array) {
        int start = 0;
        int end = array.Length - 1;

        while (start < end) {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            start++;
            end--;
        }
    }

    static void PrintArray(int[] array) {
        foreach (int element in array) {
            Console.Write(element + " ");
        }
    }
}