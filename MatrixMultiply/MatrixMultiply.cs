using System;

namespace MatrixMultiply
{
    class MatrixMultiply
    {
        static void Main(string[] args)
        {

            int[,] a = new int[2, 2];
            Input(a);

            int[,] b = new int[2, 2];
            Input(b);
            Console.WriteLine(Sum(a));
            Console.WriteLine(Avg(b));
            Console.WriteLine(PositiveNeagiveSum(a, -1));
            Console.WriteLine(OddEvenSum(b, 1));

        }

        private static void Input(int[,] a)
        {
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write("Enter value for [{0},{1}] : ", r, c);
                    string s = System.Console.ReadLine();
                    a[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();
        }

        private static int[,] Multiply(int[,] a, int[,] b) {
        
            int[,] result = new int[a.GetLength(0), b.GetLength(1)];

            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
            return result;
        }

        private static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }

        public static int Sum(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }

        public static double Avg(int[,] a)
        {
            return (double)Sum(a) / a.GetLength(0) / a.GetLength(1);
        }

        public static int PositiveNeagiveSum(int[,] a, int flag)
        {
            int c;
            if (flag >= 0)
                c = 1;
            else
                c = -1;
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j]*c >= 0) 
                        sum += a[i, j];
                }
            }
            return sum;
        }

        public static int OddEvenSum(int[,] a, int flag)
        {
            int c;
            if (flag >= 0)
                c = 0;
            else
                c = 1;
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 == c)
                        sum += a[i, j];
                }
            }
            return sum;
        }

    }
}
