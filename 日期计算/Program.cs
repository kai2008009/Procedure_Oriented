using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 日期计算
{
    class Program
    {
        static void Main(string[] args)
        {
            //查询天数
            //Console.WriteLine("请输入要查询的天：");
            //int day = Convert.ToInt32(Console.ReadLine());
            //int num1 = day / 30;
            //int num2 = day / 7;
            //int num3 = day % 7;
            //int num4 = day % 30;
            //int num5 = (day - num1*30) / 7;
            //int num6 = day - num1 * 30 - num5 * 7;
            //Console.WriteLine("第{0}天，是今年的第{1}月的第{5}周的第{6}天，是今年的第{2}周的第{3}天,第{1}个月的第{4}天", day, num1, num2, num3,num4,num5,num6);
            //Console.ReadKey();


            //查询秒数  
            //int second = 1578960;
            //int days = second / (24 * 3600);    //天数
            //int sse = second % (24 * 3600);
            //int hour = sse / 3600;   //小时
            //Console.WriteLine("{0}天{1}时{2}秒", days, hour, sse);
            //Console.ReadKey();

            //num1与num2的值均大与10时，为true
            Console.WriteLine("请输入一个数值：");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入一个数值：");
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool num3 = num1 > 10 && num2 > 10;
            Console.WriteLine(!num3);

            bool num4 = ++num1 > 10 && ++num2 > 10;
            Console.WriteLine("{0}{1}",num1,num2);

            Console.ReadKey();
        }
    }
}
