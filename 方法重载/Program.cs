using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法重载
{
    class Program
    {
        /// <summary>
        /// 方法重载，同一个类中，同方法、同名称、不同参数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double s=Max(1.0, 2.3);
            Console.WriteLine(s);
            Console.ReadKey();
        }
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
        public static double Max(double num1, double num2)
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
    }
}
