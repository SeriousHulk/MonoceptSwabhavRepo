using System;

namespace DynamicArraySimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] monoceptArray = new int[5];
            int count = 0;  
            while (true)
            {
                Console.Write("\nEnter a number: ");
                int input = int.Parse(Console.ReadLine());
                monoceptArray[count] = input;
                foreach (int value in monoceptArray)
                {
                    Console.Write(value + " ");
                }
                count++;
                if (count == monoceptArray.Length)
                {
                    int[] newArray = new int[monoceptArray.Length * 2];
                    for (int i = 0; i < monoceptArray.Length; i++)
                        newArray[i] = monoceptArray[i];
                    monoceptArray = newArray;
                    Console.WriteLine($"\nArray size doubled to {monoceptArray.Length}");
                }
            }
        }
    }
}