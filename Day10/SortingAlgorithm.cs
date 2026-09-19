using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal static class SortingAlgorithm<T> where T : IComparable<T> , ICloneable
    {
        public static void Sort(T [] arr)          //the dynamic comparer modification is in class SortingTwo
        {
            T temp;
            for(int i = 0; i < arr.Length-1 ; i++)
            {
                for (int j = i+1 ; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        temp= arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }
                }
            }
        }

        public static void Swap(ref T x ,ref T y)
        {
            T tmp;
            tmp= x;
            x = y; 
            y = tmp;
        }



    }
}
