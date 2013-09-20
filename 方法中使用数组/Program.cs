using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法中使用数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个num数组
            int[] num = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("数组是：{0}",num);
            //求和
            int n1 = Sum(num);
            Console.WriteLine("num数组中的和是：{0}",n1);

            //求最小值
            int n2 = Min(num);
            Console.WriteLine("num数组中的最小值是：{0}", n2);

            //求最大值
            int n3 = Max(num);
            Console.WriteLine("num数组中的最大值是：{0}", n3);

            Console.ReadKey();
        }

        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Sum(int[] number)
        {
            int numbers = 0;
            for (int i = 0; i < number.Length; i++)
            {
                numbers += number[i];
            }
            return numbers;
        }

        /// <summary>
        /// 求最小值
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Min(int[] number)
        {
            int min=number[0];
            for (int i = 0; i < number.Length;i++ )
            {
                if (min > number[i])
                {
                    min = number[i];
                }
            }
            return min;
        }

        /// <summary>
        /// 求最大值
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Max(int[] number)
        {
            int max = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (max < number[i])
                {
                    max = number[i];
                }
            }
            return max;
        }
    }
}
