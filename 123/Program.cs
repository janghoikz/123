using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static public int[,] Answer(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];
            if (arr1.GetLength(1) == arr2.GetLength(0))
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        for (int k = 0; k < arr2.GetLength(1); k++)
                        {
                            answer[i, k] += arr1[i, j] * arr2[j, k];
                        }
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("c"+i+" "+j+" "+answer[i,j]);
                }
            }   
                return answer;
        }
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3] { { 2, 1, -1 }, { 0,7,3 }};
            int[,] b = new int[3, 4] { { -11, 2, 0, 1 },{-3,5,1,-2 }, { 2, 2, -6, 1 } };

            Answer(a, b);
        }
    }
}