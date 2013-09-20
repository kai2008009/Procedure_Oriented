using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法中计算大小
{
    class Program
    {
        /// <summary>
        /// 查找两个整数中最大的值
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4, 5, 6 };
            int resule = Sum(n);
            Console.WriteLine(resule);

            Console.WriteLine("请输入第一个数字");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("请输入第二个数字");
            int num2 = int.Parse(Console.ReadLine());

            int max = Max(num1,num2);

            Console.Clear();

            Console.WriteLine("第一个数是{0}\n第二个数是{1}\n最大的是{2}\n和是{3}\n",
                num1,num2,max,num1+num2);
            Console.ReadKey();
        }

        /// <summary>
        /// 比较两个数的大小
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        /// <summary>
        /// 数组求和
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Sum(int[] numbers)
        {
            int numberSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numberSum += numbers[i];
            }
            return numberSum;
        }

    }
}
