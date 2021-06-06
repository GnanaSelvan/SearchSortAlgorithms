using System;

namespace SearchSortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] unsortedarray = { 1, 3, 4, 7, 5, 4, 8 };
            int i;
            int temp;
            bool swapdone = true;

            while (swapdone)
            {
                swapdone = false;
                for (i = 0; i < unsortedarray.Length - 1; i++)
                {
                    //Console.WriteLine("unsortedarray[i]" + unsortedarray[i]);
                    //Console.WriteLine("unsortedarray[i++]" + unsortedarray[i + 1]);
                   
                    if (unsortedarray[i] > unsortedarray[i + 1])
                    {
                        temp = unsortedarray[i];
                        unsortedarray[i] = unsortedarray[i + 1];
                        unsortedarray[i + 1] = temp;
                        swapdone = true;
                    }
                }
            }

            Console.WriteLine("Sorted array");
            foreach (int item in unsortedarray)
            {             
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
