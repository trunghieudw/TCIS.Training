using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCIS.Training.TestArray
{
    class Program
    {
        public static void SortArray(int[] array)
        {
            Array.Sort(array);
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
        }

        public static void EvenOddArray(int [] array)
        {
            // mang chan mang le
            
           
            int[] arr2 = new int[array.Length];
            int[] arr3 = new int [array.Length];
            int i, j = 0, k = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arr2[j] = array[i];
                    j++;
                }
                else
                {
                    arr3[k] = array[i];
                    k++;
                }
            }
            Console.WriteLine("\nSố phần tử chẵn trong mảng: ");
            for (i = 0; i < j; i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine("\nSố phần tử lẻ trong mảng: ");
            for (i = 0; i < k; i++)
            {
                Console.Write(arr3[i]+" ");
            }

        }
        public static void FindSecondMinest(int[] array)
        {
            int min, min2;
            min = min2 = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] < min2)
                 {
                    min2 = array[i];
                }
            }

            //for (int i = array.Length ; i <=0 ; i++)
            //{
            //    if (array[i]>min)
            //    {
            //        min2 = min;
            //        min = array[i];
            //    }
            //    else if (array[i] > min2)
            //    {
            //        min2 = array[i];
            //    }
            //}
            Console.WriteLine($"Phan tu nho thu 2 trong mang la: {min2}");
        }

        public static void CountOccurrences(int[] array)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                    dict[item]=1;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {item.Value} lan");
            }           
        }


    
    static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("BÀI TOÁN XỬ LÝ MẢNG TRONG C#");
            Console.Write("---------------------*---------------------");

            int[] array = { 1, 1,1,12, 3, 4, 5, 12, 31, 123, 123441, 12333,
                23, 1, 2, 3, 4 };
            Console.WriteLine("\nGiá trị của mảng");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }
            Console.WriteLine("\n\n1.Sắp xếp mảng theo thứ tự tăng dần");
            SortArray(array);
            Console.WriteLine("\n\n2.Chia mảng thành 2 mảng chẵn, lẻ");
            EvenOddArray(array);
            Console.WriteLine("\n\n3.Tìm phần tử nhỏ thứ 2 trong mảng");
            FindSecondMinest(array);
            Console.WriteLine("\n\n4.Đếm số lần xuất hiện của từng phần tử trong mảng");
            CountOccurrences(array);



            Console.ReadKey();
        }
    }
}
