using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 强制转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入语文成绩：");
            int china = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("请输入数学成绩：");
            int match = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t总成绩是：{0}\n\t商是：{1}", china + match, china / match);
            Console.ReadKey();

        }
    }
}
