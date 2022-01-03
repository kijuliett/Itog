using System;

    class Program
    {
        static void Main()
        {
            Random myRnd = new Random();
            int[] a = new int[10];
            Console.WriteLine("Исходный массив:");


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = myRnd.Next(-50, 50);
                Console.Write(a[i] + " ");
                
            }
            Console.WriteLine("\nРезультат:");


            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)              
                Console.Write(a[i] + " ");
            }
            
            
        }
    }