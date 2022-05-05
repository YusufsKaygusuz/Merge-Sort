using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {
        public static void MergeSort(int[] data)
        {
            DoMerge(data, 0, data.Length - 1);
        }
        
        static void DoMerge(int[] data, int left, int right)
        {
            if(left<right)
            {
                int middle = (left + right) / 2;
                DoMerge(data, left, middle);
                DoMerge(data, middle + 1, right);
                Merge(data, left, middle, right);
            }
        }

        static void Merge(int[] data, int left, int middle, int right)
        {
            int middle1 = middle + 1;
            int oldPosition = left;
            int size = right - left + 1;
            int[] temp = new int[size];
            int i = 0;

            while(left<=middle && middle1<=right)
            {
                if (data[left] <= data[middle1])
                    temp[i++] = data[left++];
                else
                    temp[i++] = data[middle1++];
            }

            if(left>middle)
                for (int j = middle1; j <= right; j++)
                {
                    temp[i++] = data[middle1++];
                }
            else
                for (int j = left; j <= middle; j++)
                {
                    temp[i++] = data[left++];
                }

            for (int k = 0; k < size; k++)
            {
                data[oldPosition++] = temp[k];
            }

        }


        static void Main(string[] args)
        {
            int[] arr = new int[] {12,65,42,6,24,99,75,3,45,8,2};
            MergeSort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + '\n');
            }
            Console.ReadLine();
        }
    }
}
