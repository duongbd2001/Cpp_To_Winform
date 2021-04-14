using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CppToWinform_GreedyArrangement
{
    class GreedyArrangement
    {

        #region Hàm sắp xếp mảng bằng Quick Sort :(((
        public static void Quick_Sort(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        public static int Partition(string[] arr, int left, int right)
        {
            int pivot = int.Parse(arr[left]);
            while (true)
            {

                while (int.Parse(arr[left]) < pivot)
                {
                    left++;
                }

                while (int.Parse(arr[right]) > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = int.Parse(arr[left]);
                    arr[left] = arr[right];
                    arr[right] = temp.ToString();


                }
                else
                {
                    return right;
                }
            }
        }
        #endregion
        public  int GreddyArray(string[] a,string[] b)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            int n = a.Length;
            //int[] a = new int[n];
            //int[] b = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = Int32.Parse(Console.ReadLine());
            //    b[i] = a[i];
            //}
            Quick_Sort(a, 0, n - 1);
            int check = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == b[i] || a[i] == b[n - i - 1])
                {
                    check++;
                }
            }
            return check;
        }
    }
}
