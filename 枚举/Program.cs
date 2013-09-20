using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    enum age
    {
        男, 女
    }
    class Program
    {
        static void Main(string[] args)
        {
            age sex;
            //sex = age.男;
            Console.WriteLine("请输入你的性别：");
            string s = Console.ReadLine();
            try
            {
                sex = (age)(Enum.Parse(typeof(age), s));
                Console.WriteLine("{你的性别是：}", sex);
            }
            catch 
            {
                Console.WriteLine("你的性别是有误！");
            }

            Console.WriteLine("{0}");
            Console.ReadKey();
        }
    }
}
