using System;

namespace ManipulatingArrays
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10, };
            SumAvgA(A);
            ReverseA(A);
            RotateA(A, A.Length, 2);

            int[] B = { 1, 3, 5, 7, 9 };
            SumAvgB(B);
            ReverseB(B);
            RotateB(B, B.Length, 4);

            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            SumAvgC(C);
            ReverseC(C);
            Rotate(C, C.Length, 4);
            BubbleSort(C);
        }

        private static void SumAvgA(int[] A)
        {
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                avg = sum / A.Length;
            }
            Console.WriteLine($"Number of elements in Array A: {A.Length}");
            Console.WriteLine($"The sum of elements in Array A is {sum}");
            Console.WriteLine($"The avg of elements in Array A is {avg}");
        }
        private static void ReverseA(int[] A)
        {
            Console.Write("Array A reversed is ");
            Array.Reverse(A);
            Console.WriteLine(String.Join(",", A));
        }

        private static void RotateA(int[] A, int length, int rotation)
        {
            Console.Write("Array A rotated to the left by 2 is: ");
            for (int i = rotation; i < rotation + length; i++)
            {
                Console.Write(A[i % length] + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void SumAvgB(int[] B)
        {
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < B.Length; i++)
            {
                sum += B[i];
                avg = sum / B.Length;
            }
            Console.WriteLine($"Number of elements in Array B: {B.Length}");
            Console.WriteLine($"The sum of elements in Array B is {sum}");
            Console.WriteLine($"The avg of elements in Array B is {avg}");
        }
        private static void ReverseB(int[] B)
        {
            Console.Write("Array B reversed is ");
            Array.Reverse(B);
            Console.WriteLine(String.Join(",", B));
        }

        private static void RotateB(int[] B, int length, int rotation)
        {
            Console.Write("Array B rotated to the right by 4 is: ");
            for (int i = rotation; i > -1; i--)
            {
                Console.Write(B[(length - i) % length] + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void SumAvgC(int[] C)
        {
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < C.Length; i++)
            {
                sum += C[i];
                avg = sum / C.Length;
            }
            Console.WriteLine($"Number of elements in Array C: {C.Length}");
            Console.WriteLine($"The sum of elements in Array C is {sum}");
            Console.WriteLine($"The avg of elements in Array C is {avg}");
        }

        private static void ReverseC(int[] C)
        {
            Console.Write("Array C reversed is ");
            Array.Reverse(C);
            Console.WriteLine(String.Join(",", C));
        }

        private static void Rotate(int[] C, int length, int rotation)
        {
            Console.Write("Array C rotated to the left by 4 is: ");
            for (int i = rotation; i < rotation + length; i++)
            {
                Console.Write(C[i % length] + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void BubbleSort(int[] C)
        {
            int t;
            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = 0; j < C.Length - 1; j++)
                {
                    if (C[j] > C [j+1])
                    {
                        t = C[j + 1];
                        C[j + 1] = C[j];
                        C[j] = t;
                    }
                }
            }
            Console.Write("Array C as sorted is: ");
            foreach (var cc in C)
            {
                Console.Write(cc + ",");
            }
            Console.WriteLine();
        }
    }
}
