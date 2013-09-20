using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型的自动转换
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            //除法与余数的运算
            int num1 = 58;
            int num2 = 4;
            int num4 = num1 % num2;
            double num3 = num1 / num2;
            Console.WriteLine("{0}除以{1}等于：{2}", num1, num2, num3);
            Console.WriteLine("{0}除以{1}的余数是{2}", num1, num2, num4);
            Console.WriteLine(num1/(num2*1.0));
            Console.ReadKey();

        }
    }
}
