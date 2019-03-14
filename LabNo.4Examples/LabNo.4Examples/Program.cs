using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNo._4Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3,5,9,10,12 };
            int[] B = { 1,2,4,6,7 };
            int[] C = new int[10];
            int i=0,j = 0,k;
            for (k = 0; k < C.Length; k++)
            {
                if(A[i]< B[j])
                {
                    C[k] = A[i];
                    if(i<A.Length-1)
                    {
                        i++;
                    }
                    else
                    {
                        i++;
                        break;
                    }                
                }
                else
                {
                    C[k] = B[j];
                    if (j < B.Length - 1)
                    {
                        j++;
                    }
                    else
                    {
                        j++;
                        break;
                    }
                }

            }
            while (i < A.Length)
            {
                C[++k] = A[i];
                i++;
            }
            while (j < B.Length)
            {
                C[++k] = B[j++];
            }
            for (int x=0;x<C.Length;x++)
            {
                Console.Write(C[x] + " ");
            }
        }
    }
}
