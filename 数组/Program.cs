using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        //求和、平均值、最大值
        static void Main(string[] args)
        {
            //int sum = 0;
            //int[] score = new int[10];

            //for (int i = 0; i < score.Length; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的成绩", i + 1);
            //    score[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////清屏
            //Console.Clear();

            ////最大值
            //int max = score[0];
            //for (int i = 1; i < score.Length; i++)
            //{
            //    if (score[i] > max)
            //    {
            //        max = score[i];
            //    }

            //}


            //for (int i = 0; i < score.Length; i++)
            //{
            //    sum += score[i];
            //    Console.WriteLine("{0}个学生的成绩是{1}", i + 1, score[i]);
            //}

            //Console.WriteLine("{0}个人的评价成绩为{1},最高分为{2}", score.Length, sum / score.Length, max);


            //求最大值、最小、和、平均值
            int[] numbers = { 12, 23, 45, 56, 78, 89, 65, 45, 211, 32, 65, 98, 45, 32, 32, 32, 45, 45, 95 };
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            int num = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            Console.WriteLine("max={0},min={1},sum={2},平均值是{3}", max, min, sum,sum/numbers.Length);
                Console.ReadKey();
        }
    }
}
