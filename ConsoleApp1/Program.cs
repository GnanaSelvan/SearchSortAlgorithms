using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] a1 = { 1, 3, 4, 6, 5, 7, 4, 8 };
            bool swapped = true;
          

            while(swapped)
            {
                swapped = false;
                for (int i = 0; i < 7; i++)
                {
                    
                    if (a1[i] > a1[i + 1])
                    {
                        int temp = a1[i];
                        a1[i] = a1[i + 1];
                        a1[i + 1] = temp;
                        swapped = true;
                    }
                    
                }
                
                
            }
    }
}
