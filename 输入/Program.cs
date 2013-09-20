using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输入
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符：");
            string opp=Console.ReadLine();
            Console.WriteLine("现在时间是：{0:D}",DateTime.Now);
            Console.WriteLine("输入的字符是："+opp);
            Console.ReadKey();
        }
    }
}
