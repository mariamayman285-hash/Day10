using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class SortingTwo<T> where T: IComparable<T>
    {
        public static void Sort(T[] arr , Func<T,T,bool>compare)       //modified here
        {
            T temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare(arr[i] , arr[j]))                    //modified here
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
    
                }
            }
        }
    }
}
