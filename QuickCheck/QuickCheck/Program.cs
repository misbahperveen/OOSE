using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            quick obj = new quick();
            int[] returnAry = obj.qsort(0, 7);
            foreach (var item in returnAry)
            {
                Console.WriteLine(item);
            }
        }
    }
    class quick
    {
        int[] a = { 11, 5, 15, 2, 7, 9, 12, 20, 4 };
        public int[] qsort(int l, int r)
        {
            int pivot;
            int lhold;
            int rhold;
            lhold = l;
            rhold = r;
            pivot = a[l];
            while (l < r)
            {
                while ((a[r] >= pivot) && l < r)
                {
                    r--;
                    if (l != r)
                    {
                        a[l] = a[r];
                        l++;
                    }
                    while ((a[l] <= pivot) && (l < r))
                    {
                        l++;

                        if (l != r)
                            a[r] = a[l];
                        r--;
                    }
                    a[l] = pivot;
                    pivot = l;
                    l = lhold;
                    r = rhold;

                    if (l < pivot)
                        qsort(l, pivot - 1);

                    if (r > pivot)
                        qsort(pivot + 1, r);
                }
            }
            return a;

        }
    }
}

