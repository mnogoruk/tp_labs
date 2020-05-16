using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
           {
                int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] % 2 == 0) myArray[i] = 0;
                    Console.Write(myArray[i] + " ");
                }


            }
            Console.WriteLine("\n");
            {

                int[] MyArray;
                int n = int.Parse(Console.ReadLine());
                MyArray = new int[n];
                for (int i = 0; i < MyArray.Length; ++i)
                {
                    Console.Write("a[{0}]=", i);
                    MyArray[i] = int.Parse(Console.ReadLine());
                }
                foreach (int x in MyArray) Console.Write("{0} ", x);
            }
        }
    }
}
