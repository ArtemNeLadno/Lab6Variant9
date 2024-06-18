using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Variant9
{
    public class Lab6Var9
    {
        public static int Task1(int[,] C)
        {

            int Sum = 0;
            for (int i = 8; i >= 4; i--)
            {
                for (int j = i; j >= 8 - i; j--)
                {
                    if (C[i, j] > 0)
                    {
                        Sum += C[i, j];
                    }
                }
            }
            return Sum;
        }
        public static int [] Task2(int[,] C)
        {
            int mas = 0;
            for (int i = 8; i >= 4; i--)
            {
                for (int j = i; j >= 8 - i; j--)
                {
                    if (C[i, j] > 10)
                        mas++;
                }
            }
            int[] U = new int[mas];
            int f = 0;
            for (int i = 8; i >= 4; i--)
            {
                for (int j = i; j >= 8 - i; j--)
                {
                    if (C[i, j] > 10)
                    {
                        U[f] = C[i, j];
                        f++;
                    }
                }
            }
            
            return U;
        }
        public static int[] Task3(int[,] C)
        {
            
            int rows = C.GetUpperBound(0) + 1;
            int columns = C.Length / rows;
            int[] D = new int[columns];
            int max = C[0, 0];
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (C[i, j] > max)
                    {
                        max = C[i, j];
                    }
                }
            }
            int f = 8;
            for (int i = 8; i >= 4; i--)
            {
                for (int j = i; j >= 8 - i; j--)
                {
                    if (C[i, j] == max)
                    {
                        D[f] = +1;
                    }

                }
                f--;
            }
            return D;
        }

    }
}
