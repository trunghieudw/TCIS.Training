using System;
using System.Collections.Generic;
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
            Console.WriteLine("In gia tri chan le trong mang");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    var evenarray = array[i];

                }
                
            }
            Console.WriteLine();
            //else
            //{
            //    var oddarray = array[i];
            //    Console.WriteLine($"Phan tu le trong mang: {oddarray}");
            //}
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
            Console.WriteLine("\n\nSắp xếp mảng theo thứ tự tăng dần");
            SortArray(array);


            Console.WriteLine("\n\nTìm phần tử nhỏ thứ 2 trong mảng");
            FindSecondMinest(array);
            Console.WriteLine("\n\nĐếm số lần xuất hiện của từng phần tử trong mảng");
            CountOccurrences(array);



            Console.ReadKey();
        }
    }
}
