using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "张三";
            int age = 18;
            decimal money = 45678.698m;

            Console.WriteLine("我叫" + name + ",今年" + age + "岁了，月薪是" + money);
            Console.WriteLine("我叫{0},今年{1}岁了，月薪是{2}", name, age, money);
            Console.WriteLine("{0}我叫" + name, "今年" + age+ "岁了，月薪是"+money);
            Console.ReadKey();
            
        }
    }
}
