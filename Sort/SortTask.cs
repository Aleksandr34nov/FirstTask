using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class SortTask
    {
        public static void Sort(int[] items)
        {
            for (int i = 1; i < items.Length; i++)
            {
                for (int j = i; j > 0 && items[j - 1] > items[j]; j--)
                {
                    int temp;
                    temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                    //swap(x[j - 1], x[j]);
                }
            }

            return;
        }

        public static void Print(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
                //Console.WriteLine("\n");
            }
            Console.Write("\n");
        }
    }
}
