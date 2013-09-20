using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 12, 23, 13, 46, 78, 98, 64, 79, 5, 7, 97, 48, 18, 29, 68, 18, 59, 36, 97, 64, 81, 86, 97, 94, 91, 57, 68, 49, 34 };

            for (int i = 0; i < score.Length - 1; i++)
            {
                for (int j = 0; j < score.Length - 1 - i; j++)
                {
                    if (score[j] < score[j + 1])
                    {
                        int temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }
            Console.ReadKey();
        }
    }
}
