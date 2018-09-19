using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.DataStructures
{
    public class SimpleAndInsertionSort
    {
        public static void Do()
        {
            //Console.WriteLine("Enter number to be sorted...");
            //Sample input : -11 12 -42 0 1 90 68 6 -9
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            //int[] arr = Console.ReadLine().Split(new char[] { ' ' }).Select(i => Convert.ToInt32(i)).ToArray<int>();
            //SimpleSort(arr);
            //InsertionSort(arr);
            Quicksort<int>(arr,0,arr.Length-1,Comparer<int>.Default);
            foreach (var v in arr)
                Console.Write(v + " ");
        }

        private static void SimpleSort(int[] arr)
        {
            int tmp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        private static void InsertionSort(int[] arr)
        {
            int tmp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j].CompareTo(arr[j - 1]) < 0)
                {
                    tmp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = tmp;
                    j--;
                }
            }
        }

        private static void Quicksort<T>(T[] v, int left, int right, IComparer<T> comparer)
        {
            if (right - left > 1)
            {
                var mid = (left + right) / 2;
                T pivot = v[mid];
                T[] aux = new T[right - left + 1];

                Array.Copy(v, left, aux, 0, aux.Length);

                var vv = aux.Where(x => comparer.Compare(x, pivot) < 0)
                    .Concat(new T[] { pivot })
                    .Concat(aux.Where(x => comparer.Compare(x, pivot) > 0)).ToArray();

                Array.Copy(vv, 0, v, left, vv.Length);

                Quicksort(v, left, mid, comparer);
                Quicksort(v, mid + 1, right, comparer);
            }
        }
    }
}
