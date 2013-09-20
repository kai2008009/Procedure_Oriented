using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组判断质数
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool result;
            int number=0;
            do
            {
                Console.WriteLine("请输入一个正整数");
                input = Console.ReadLine();
                if (input == "q")
                {
                    Console.WriteLine("程序结束！");
                    break;
                }
                try
                {
                    number = Convert.ToInt32(input);
                    result = Zhishu(number);
                    if (result == true)
                    {
                        Console.WriteLine("{0是质数}", number);
                    }
                    else
                    {
                        Console.WriteLine("{0}不是质数", number);
                    }
                }
                catch
                {
                    Console.WriteLine("输入的数据有误");
                    continue;
                }
            }
            while (true);

            Console.ReadKey();
        }

        /// <summary>
        /// 读入一个整数
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            int number = 0;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number <= 0)
                    {
                        Console.WriteLine("输入有误，请输入一个正数！");
                        continue;
                    }
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入！");
                }
            } while (true);
        }

        /// <summary>
        /// 判断一个数是否为质数
        /// </summary>
        public static bool Zhishu(int number)
        {
            for (int i = 2; i < number; i++)
            {
                //i不能等于number
                if (number % i == 0)
                {
                    Console.WriteLine("{0}不是质数", number);
                    //上面条件一旦成立，说明被2到本身-1之间的数除尽了，所以不上质数，返回false
                    return false;
                }
                else
                {
                    Console.WriteLine("{0}是质数", number);
                }
            }
            return true;
        }
    }
}
