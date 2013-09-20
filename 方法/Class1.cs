using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    class Class1
    {
        /// <summary>
        /// 计算闰年的方法
        /// </summary>
        /// <param name="year">计算年</param>
        /// <returns>返回年</returns>
        public static bool Resout(int year)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 计算数组相加的和
        /// </summary>
        /// <param name="numbers">和</param>
        /// <returns>返回和</returns>
        public static int Sum(int[] numbers)
        {
            int sunNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sunNumber += numbers[i];
            }
            return sunNumber;
        }

        /// <summary>
        /// 统计输入的年龄
        /// </summary>
        /// <returns>返回年龄</returns>
        public static int RedInt()
        {
            int number = 0;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误");

                }
            } while (true);
        }

        /// <summary>
        /// 清屏
        /// </summary>
        public static void Qinping()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
