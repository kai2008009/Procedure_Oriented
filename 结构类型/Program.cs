using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t;//声明结构类型teacher的变量
            t.name = "司法官";
            t.phone = "138669885";
            t.age = 89;
            t.address = "VIP@qq.com";
            Console.WriteLine("{0}老师的电话是{1}，今年{2}岁了，邮箱是{3}",t.name,t.phone,t.age,t.address);
            Console.ReadKey();
        }


        struct Teacher//结构类型
        {
            public string name;//姓名
            public int age;//年龄
            public string phone;//电话
            public string address;//邮箱
        }
    }
}
