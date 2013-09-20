using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组一维与二维
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];

            int[] arr2 = new int[] { 1, 2, 3 };

            string[] arr3 = { "siv|Age", "is", "刘阿哥" };

            int[,] arr4 = { { 1, 2 }, { 3, 4 } };

            int[,] arr5 = new int[3, 4];

            //一维数组
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i * i * i;
                Console.WriteLine("arr1[{0}]={1}", i, arr1[i]);
            }

            //二维数组
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr5[j, i] = i * j;
                    Console.WriteLine("arr5[{0},{1}]={2}", j, i, arr5[j, i]);
                }
            }

            Console.ReadKey();
        }
    }
}
