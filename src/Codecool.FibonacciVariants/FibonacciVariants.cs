using System;
using System.Collections.Generic;

namespace Codecool.FibonacciVariants
{
    public static class FibonacciVariants
    {
        public static int AdditionsCounter =0;

        public static List<int> Memory = new List<int> { 0, 1 };

        public static void ResetCounter()
        {
            AdditionsCounter = 0;
        }

        public static int Iterative(int n)
        {
            int first = 0;
            int last = 1;
            int current;
            if (n == 0) return first;
            if (n == 1) return last;
            for( int i = 2; i<=n; i++)
            {
                current = first + last;
                first = last;
                last = current;
                AdditionsCounter++;
            }
            return last;
        }


        public static int NaiveRecursive(int n)
        {
            if(n == 0 || n==1) return n;
            AdditionsCounter+=1;
            return NaiveRecursive(n-1) + NaiveRecursive(n-2);

        }

        public static int RecursiveWithMemoization(int n)
        {
            if(n == 0 || n==1) return n;
            AdditionsCounter+=1;
            if (Memory.Contains(n)) return n;
            int result = RecursiveWithMemoization(n - 1) + RecursiveWithMemoization(n - 2);
            Memory.Add(result);
            return result;
        }

        public static int TailRecursive(int n)
        {
            return TailRecursiveHelper(n - 1, 0, 1);
        }

        private static int TailRecursiveHelper(int n, int a, int b)
        {
            AdditionsCounter++;
            if (n < 1) return b;
            return TailRecursiveHelper(n - 1, b, a + b);
        }
    }
}
