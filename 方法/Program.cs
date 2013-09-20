using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    class Program
    {
        //调用方法
        static void Main(string[] args)
        {
            //输入一个数字，判断是否为闰年
            Console.WriteLine("请输入年份:");
            int year = Convert.ToInt32(Console.ReadLine());

            bool s = Class1.Resout(year);
            if (s)
            {
                Console.WriteLine("是闰年");
            }
            else
            {
                Console.WriteLine("不上闰年");
            }

            Class1.Qinping();

            //计算数组的和
            int[] num = { 1, 2, 3, 4, 5, 6 };
            int result=Class1.Sum(num);
            Console.WriteLine("数组的和是{0}",result);

            Class1.Qinping();//清屏

            //输出年龄
            Console.WriteLine("请输入你的年龄");
            int age =Class1.RedInt();
            Console.WriteLine("你的年龄是:{0}", age);


            Console.ReadKey();
        }



    }
}
